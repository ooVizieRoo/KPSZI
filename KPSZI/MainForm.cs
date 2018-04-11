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

        InformationSystem IS = new InformationSystem();

        public MainForm()
        {
            InitializeComponent();

            // Заполняем коллекцию этапами (название, ссылка на вкладку, ссылка на пункт в дереве) 
            stages.Add("tnOptions", new StageOptions(returnTabPage("tpOptions"), returnTreeNode("tnOptions"), this));
            stages.Add("tnClassification", new StageClassification(returnTabPage("tpClassification"), returnTreeNode("tnClassification"), this));

            // закрываем все вкладки в TabControl
            tabControl.TabPages.Clear();

            // связываем дерево с набором иконок
            treeView.ImageList = iconList;


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

        // переключение этапа в дереве
        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            tabControl.TabPages.Clear();
            // берем снова
            string nodeName = treeView.SelectedNode.Name;
            if (treeView.SelectedNode.Nodes.Count == 0)
            {
                tabControl.TabPages.Add(stages[nodeName].stageTab);
                tabControl.SelectedTab.Text = treeView.SelectedNode.Text;
            }

            #region Загрузка вкладки "Классификация"
            if (treeView.SelectedNode.Name == "tnClassification")
            {
                
                tabControlInfoTypes.TabPages.Clear();
                //
                panelPDN.Enabled = false;
                panelPDN.Visible = false;
                foreach (InfoType it in IS.listOfInfoTypes)
                {
                    if (it.TypeName == "Персональные данные")
                    {
                        panelPDN.Enabled = true;
                        panelPDN.Visible = true;
                        continue;
                    }
                    tabControlInfoTypes.TabPages.Add(((StageClassification)stages["tnClassification"]).tabPagesInfoTypes.FindLast(t => t.Name == it.TypeName));
                }
                GISClassCalculate(null, null);               
            }
            #endregion
            if (treeView.SelectedNode.Name == "tnOptions")
            {
                // берем из экземпляра выбранные виды информации и возвращаем их в чеклистбокс при переходе по вкладкам
                for (int i = 0; i < IS.listOfInfoTypes.Count; i++)
                {
                    int k = lbInfoTypes.Items.IndexOf(IS.listOfInfoTypes[i]);
                    lbInfoTypes.SetItemChecked(k, true);
                }
            }
        }

        private void lbInfoTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // При нажатии на галочку все выбранные 
            // виды информации помещаются в экземпляр ИС
            IS.ISName = textBox1.Text;
            object[] buf = new object[lbInfoTypes.CheckedItems.Count];
            IS.listOfInfoTypes.Clear();
            lbInfoTypes.CheckedItems.CopyTo(buf, 0);
            for (int i = 0; i < buf.Length; i++)
            {
                IS.listOfInfoTypes.Add((InfoType)buf.GetValue(i));
            }
        }

        private void rewriteThreatsDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Перезаписать базу угроз
            if (MessageBox.Show("Будут удалены все угрозы из таблицы в БД и записаны заново.\nПродолжить?", "Ахтунг!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (KPSZIContext db = new KPSZIContext())
                {
                    FileInfo fi = new FileInfo("thrlist.xlsx");

                    db.Threats.RemoveRange(db.Threats.ToList());

                    db.Threats.AddRange(Threat.GetThreatsFromXlsx(fi, db));
                    db.SaveChanges();
                }
            }
        }

        private void deleteAllTablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Снести всю базу
            MessageBox.Show("WiP", "WiP", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
        }

        private void refreshThreatDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Обновить список угроз
            if (MessageBox.Show("Будет проведено сравнение локальной базы угроз с данными из файла \"thrlist.xlsx\" и автоматическое обновление данных.\nПродолжить?", "Ахтунг!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

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
                Console.WriteLine("Проблемы при загрузке файла\n{0}", ex.Message);
            }
        }

        public void GISClassCalculate(object sender, EventArgs e)
        {
            //Определение класса защищенности ГИС
            if (comboBoxScale.SelectedItem == null || tabControlInfoTypes.TabPages.Count==0)
            {
                return;
            }

            string scaleGIS = comboBoxScale.SelectedItem.ToString();
            string maxDegreeDamage = "";
            List<string> scales = new List<string>();
            foreach (TabPage tp in tabControlInfoTypes.TabPages)
            {
                foreach (Control con in tp.Controls)
                    if (con is ComboBox)
                    {
                        if (((ComboBox)con).SelectedItem == null)
                        {
                            return;
                        }
                        scales.Add(((ComboBox)con).SelectedItem.ToString());
                    }
            }

            maxDegreeDamage = "Низкий";
            if (scales.Contains("Средний"))
            {
                maxDegreeDamage = "Средний";
            }
            if (scales.Contains("Высокий"))
            {
                maxDegreeDamage = "Высокий";
            }

            switch (maxDegreeDamage)
            {
                case "Высокий":
                    {
                        labelGISClass.Text = "К1 - 1 класс защищенности";
                        break;
                    }
                case "Средний":
                    {
                        if (scaleGIS == "Федеральный")
                            labelGISClass.Text = "К1 - 1 класс защищенности";
                        else
                            labelGISClass.Text = "К2 - 2 класс защищенности";
                        break;
                    }
                case "Низкий":
                    {
                        if (scaleGIS == "Федеральный")
                            labelGISClass.Text = "К2 - 2 класс защищенности";
                        else
                            labelGISClass.Text = "К3 - 3 класс защищенности";
                        break;
                    }
            }
        }

        public void ISPDNLevelCalculate(object sender, EventArgs e)
        {
            string ActualThreats = comboBoxActualThreatsType.SelectedItem.ToString();
            bool isStaffSubjects = checkBoxSubjectsStaff.Checked;
            string SubjectsPDN = comboBoxHundred.SelectedItem.ToString();

            switch (ActualThreats)
            {
                case "1-го типа":
                    {
                        break;
                    }

                case "2-го типа":
                    {
                        break;
                    }

                case "3-го типа":
                    {
                        break;
                    }
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            object[] buf = new object[checkedListBoxCategoryPDN.CheckedItems.Count];
            IS.listOfCategoriesPDN.Clear();
            checkedListBoxCategoryPDN.CheckedItems.CopyTo(buf, 0);
            for (int i = 0; i < buf.Length; i++)
            {
                IS.listOfCategoriesPDN.Add((string)buf.GetValue(i));
            }
        }
    }
}