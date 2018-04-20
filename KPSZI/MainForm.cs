using KPSZI.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KPSZI
{
    public partial class MainForm : Form
    {
        // Dictionary - аналог ассоциативных массивов в C#
        // Обращаемся к элементу массива (коллекции) по названию (string)
        // 
        internal Dictionary<string, Stage> stages = new Dictionary<string, Stage>();
        TreeNode previousSelectedNode;
        InformationSystem IS = new InformationSystem();

        public MainForm()
        {
            InitializeComponent();

            // Заполняем коллекцию этапами (название, ссылка на вкладку, ссылка на пункт в дереве) 
            stages.Add("tnOptions", new StageOptions(returnTabPage("tpOptions"), returnTreeNode("tnOptions"), this, IS));
            stages.Add("tnClassification", new StageClassification(returnTabPage("tpClassification"), 
                returnTreeNode("tnClassification"), this, IS));
            stages.Add("tnAccessMatrix", new StageAccessMatrix(returnTabPage("tpAccessMatrix"), returnTreeNode("tnAccessMatrix"), this, IS));
            stages.Add("tnTopology", new StageTopology(returnTabPage("tpTopology"), returnTreeNode("tnTopology"), this, IS));
            stages.Add("tnIntruder", new StageIntruder(returnTabPage("tpIntruder"), returnTreeNode("tnIntruder"), this, IS));
            stages.Add("tnActualThreats", new StageActualThreats(returnTabPage("tpActualThreats"), returnTreeNode("tnActualThreats"), this, IS));
            stages.Add("tnHardware", new StageHardware(returnTabPage("tpHardware"), returnTreeNode("tnHardware"), this, IS));

            
            //returnTreeNode("tnActualThreats").ForeColor = Color.Gray;
            //returnTreeNode("tnActualThreats").BackColor = Color.White;

            // закрываем все вкладки в TabControl
            tabControl.TabPages.Clear();

            // связываем дерево с набором иконок
            iconList.Images.Add(Image.FromFile(@"res\icons\folder-icon.png"));
            iconList.Images.Add(Image.FromFile(@"res\icons\document-settings-icon.png"));
            iconList.Images.Add(Image.FromFile(@"res\icons\left-arrow-icon.png"));
            iconList.Images.Add(Image.FromFile(@"res\icons\right-arrow-icon.png"));
            treeView.ImageList = iconList;

            // развернуть дерево
            treeView.ExpandAll();

            btPrevStage.ImageList = iconList;
            btPrevStage.ImageIndex = 2;
            btPrevStage.TextImageRelation = TextImageRelation.ImageBeforeText;
            btNextStage.ImageList = iconList;
            btNextStage.ImageIndex = 3;
            btNextStage.TextImageRelation = TextImageRelation.TextBeforeImage;
            
            foreach(TabPage tab in tabControl.TabPages)
            {
                tab.AutoScroll = true;
            }

            tabControlInfoTypes.TabPages.AddRange(((StageClassification)stages["tnClassification"]).tabPagesInfoTypes.ToArray());

        }

        // возвращает ссылку на TabPage по имени вкладки
        private TabPage returnTabPage(string tpName)
        {
            return tabControl.TabPages[tabControl.TabPages.IndexOfKey(tpName)];
        }
        // возвращает ссылку на TreeNode по имени пункта дерева
        private TreeNode returnTreeNode(string tnName)
        {
            return treeView.Nodes.Find(tnName, true)[0];
        }

        // Событие: После переключения вкладки
        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView.SelectedNode.ForeColor == Color.Gray)
            {
                treeView.SelectedNode = previousSelectedNode;
                return;
            }

            tabControl.TabPages.Clear();
            
            // Получаем имя Node в дереве
            string nodeName = treeView.SelectedNode.Name;
            // Если дочерних Нодов нет ...
            if (treeView.SelectedNode.Nodes.Count == 0)
            {
                // ... Открываем вкладку этапа и выполняем enterTabPage
                tabControl.TabPages.Add(stages[nodeName].stageTab);
                tabControl.SelectedTab.Text = treeView.SelectedNode.Text;
                stages[nodeName].enterTabPage();
            }

            treeView.Focus();
        }

        // Событие: До переключения вкладки
        private void treeView_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            previousSelectedNode = treeView.SelectedNode;
            if (treeView.SelectedNode != null && treeView.SelectedNode.Nodes.Count == 0)
                stages[treeView.SelectedNode.Name].saveChanges();
        }

        private void rewriteThreatsDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Перезаписать базу угроз
            if (MessageBox.Show("Будут удалены все угрозы из таблицы в БД и записаны заново.\nПродолжить?", "Ахтунг!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (KPSZIContext db = new KPSZIContext())
                {
                    FileInfo fi = new FileInfo("thrlist.xlsx");

                    //db.Threats.RemoveRange(db.Threats.ToList());
                    try
                    {
                        // Каскадное удаление данных вместе с внешними ключами
                        db.Database.ExecuteSqlCommand("SET SCHEMA '" + KPSZIContext.schema_name + "'; TRUNCATE \"Threats\" CASCADE;");

                        db.Threats.AddRange(Threat.GetThreatsFromXlsx(fi, db));
                        db.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("В rewriteThreatsDBToolStripMenuItem_Click Exception!\n" + ex.Message, "Ахтунг!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }
                MessageBox.Show("Таблица угроз успешно перезаписана!", "Это успех, парень!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void clearDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Снести всю базу
            if (MessageBox.Show("Будут очищены все таблицы (не удалены) кроме данных о миграциях", "Ахтунг!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                using (KPSZIContext db = new KPSZIContext())
                {
                    try
                    {
                        db.Database.ExecuteSqlCommand("SET SCHEMA '" + KPSZIContext.schema_name + "'; TRUNCATE \"GISMeasures\", \"ISPDNMeasures\", \"InfoTypes\", \"IntruderTypes\", \"IntruderTypeThreats\", \"MeasureGroups\", \"SFHTypes\", \"SFHs\", \"SZIGISMeasures\", \"SZIISPDNMeasures\", \"SZITypes\", \"SZIs\", \"TCUIThreats\", \"TCUITypes\", \"TCUIs\", \"TechnogenicMeasures\", \"TechnogenicThreats\", \"ThreatSources\", \"ThreatSourceThreats\", \"Threats\", \"ImplementWays\", \"ThreatImplementWays\", \"Vulnerabilities\", \"VulnerabilityThreats\" CASCADE");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("В clearDBToolStripMenuItem_Click Exception!\n" + ex.Message, "Ахтунг!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                MessageBox.Show("Таблицы базы данных успешно очищены", "Это успех, парень!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void refreshThreatDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Обновить список угроз
            if (MessageBox.Show("Будет проведено сравнение локальной базы угроз с данными из файла \"thrlist.xlsx\" и автоматическое обновление данных.\nПродолжить?", "Ахтунг!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (KPSZIContext db = new KPSZIContext())
                {
                    try
                    {
                        FileInfo fi = new FileInfo("thrlist.xlsx");
                        List<Threat> listThreatsFromFile = Threat.GetThreatsFromXlsx(fi, db);
                        List<Threat> listThreatsFromDB = db.Threats.OrderBy(t => t.ThreatNumber).ToList();

                        DateTime lastUpdateOfLocalDB;
                        if (listThreatsFromDB != null)
                        {
                            // Получение даты последнего обновления угроз из БД
                            lastUpdateOfLocalDB = listThreatsFromDB.Select(t => t.DateOfChange).Max();
                        }
                        else
                        {
                            lastUpdateOfLocalDB = DateTime.MinValue;
                        }

                        // Получение даты последнего обновления угроз из актуального файла с угрозами
                        DateTime lastUpdateOfFile = listThreatsFromFile.Select(t => t.DateOfChange).Max();

                        // Если нет изменений, то прекратить обновление
                        if (lastUpdateOfLocalDB == lastUpdateOfFile)
                        {
                            MessageBox.Show("База угроз не требует обновления!", "КПСЗИ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        // Отбор угроз, претерпевших изменения
                        List<Threat> listChangedOrAddedThreats = listThreatsFromFile.Where(t => t.DateOfChange > lastUpdateOfLocalDB).ToList();

                        // Внесение изменений
                        foreach(Threat thr in listChangedOrAddedThreats)
                        {
                            Threat ThrFromDB = listThreatsFromDB.Where(t => t.ThreatNumber == thr.ThreatNumber).FirstOrDefault();

                            if (ThrFromDB == null)
                            {
                                //listThreatsFromDB.Add(thr);
                                db.Threats.Add(thr);

                                continue;
                            }

                            ThrFromDB.AvailabilityViolation = thr.AvailabilityViolation;
                            ThrFromDB.ConfidenceViolation = thr.ConfidenceViolation;
                            ThrFromDB.DateOfAdd = thr.DateOfAdd;
                            ThrFromDB.DateOfChange = thr.DateOfChange;
                            ThrFromDB.Description = thr.Description;
                            ThrFromDB.IntegrityViolation = thr.IntegrityViolation;
                            ThrFromDB.Name = thr.Name;
                            ThrFromDB.ObjectOfInfluence = thr.Name;
                            ThrFromDB.ThreatNumber = thr.ThreatNumber;
                            ThrFromDB.ThreatSources = thr.ThreatSources;
                        }

                        db.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("В refreshThreatDBToolStripMenuItem_Click Exception!\n" + ex.Message, "Ахтунг!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                MessageBox.Show("Список угроз обновлен", "Это успех, парень!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void downloadThreatListthrlistxlsxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Загрузить список угроз
            try
            {
                using (var client = new WebClient())
                {
                    client.DownloadFile("http://bdu.fstec.ru/documents/files/thrlist.xlsx", "thrlist.xlsx");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проблемы при загрузке файла thrlist.xlsx.\n"+ ex.Message, "Ошибка загрузки файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Файл успешно загружен", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Перключение по вкладкам Вперед и Назад
        // Работает в пределах одного родительского элемента
        private void PrevStage_Click(object sender, EventArgs e)
        {
            TreeNode tn = treeView.SelectedNode.PrevNode;
            if (tn != null)
                treeView.SelectedNode = tn;
        }
        private void NextStage_Click(object sender, EventArgs e)
        {
            TreeNode tn = treeView.SelectedNode.NextNode;
            if (tn != null)
                treeView.SelectedNode = tn;
        }

        private void initDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // инициализация БД начальным значениями из метода Model.KPSZIContext.Seed()

            if (MessageBox.Show("БД будет проинициализирована начальными значениями. Перед выполнением процедуры необходимо очистить (не удалить!) все таблицы.\nПродолжить?", "Ахтунг!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                using (KPSZIContext db = new KPSZIContext())
                {
                    try
                    {
                        db.Seed();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ахтунг!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                MessageBox.Show("База данных проинициализирована начальными значениями", "Это успех, парень!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void PressTheKey(KeyPressEventArgs e)
        {
            OnKeyPress(e);
        } 

        protected override void OnKeyPress(KeyPressEventArgs e)
        { 
            base.OnKeyPress(e);
        }
    }
}