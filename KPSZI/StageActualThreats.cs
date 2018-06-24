using KPSZI.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KPSZI
{
    class StageActualThreats : Stage
    {
        public List<Threat> listThreats;
        List<Vulnerability> listVulnerabilities;
        List<SFH> listSFHs;
        List<ImplementWay> listImplementWays;
        List<ThreatSource> listSources;
        List<Threat> listFilteredThreats;
        Color[] headerColors = new Color[4] { Color.LemonChiffon, Color.PowderBlue, Color.LightGreen, Color.Plum };
        Dictionary<int, int[,,]> damageDegreeInput;
        DamageDegreeControl DDControl;
        bool firstEnter = true;

        protected override ImageList imageListForTabPage { get; set; }

        public StageActualThreats(TabPage stageTab, TreeNode stageNode, MainForm mainForm, InformationSystem IS)
            : base(stageTab, stageNode, mainForm, IS)
        {
            
            
        }
        
        protected override void initTabPage()
        {
            
            using (KPSZIContext db = new KPSZIContext())
            {
                //Инициализация списка угроз
                listThreats = db.Threats.OrderBy(t => t.ThreatNumber).ToList();
                foreach (Threat threat in listThreats)
                {
                    threat.Vulnerabilities = db.Threats.Where(t1 => t1.ThreatNumber == threat.ThreatNumber).First().Vulnerabilities;
                    threat.SFHs = db.Threats.Where(t2 => t2.ThreatNumber == threat.ThreatNumber).First().SFHs;
                    threat.ImplementWays = db.Threats.Where(t3 => t3.ThreatNumber == threat.ThreatNumber).First().ImplementWays;
                    threat.ThreatSources = db.Threats.Where(t4 => t4.ThreatNumber == threat.ThreatNumber).First().ThreatSources;
                    threat.GISMeasures = db.Threats.Where(t5 => t5.ThreatNumber == threat.ThreatNumber).First().GISMeasures;
                    threat.setStringVulnerabilities();
                    threat.setStringSFHs();
                    threat.setStringImplementWays();
                    threat.setStringSources();
                }

                listVulnerabilities = db.Vulnerabilities.OrderBy(v => v.VulnerabilityNumber).ToList();
                listSFHs = db.SFHs.OrderBy(s => s.SFHNumber).ToList();
                listImplementWays = db.ImplementWays.OrderBy(w => w.WayNumber).ToList();
                listSources = db.ThreatSources.OrderBy(so => so.ThreatSourceId).ToList();
                foreach (Vulnerability vul in listVulnerabilities)
                    vul.Threats = db.Vulnerabilities.Where(v1 => v1.VulnerabilityNumber == vul.VulnerabilityNumber).First().Threats;
                foreach (SFH sfh in listSFHs)
                    sfh.Threats = db.SFHs.Where(s1 => s1.SFHNumber == sfh.SFHNumber).First().Threats;
                foreach (ImplementWay iw in listImplementWays)
                    iw.Threats = db.ImplementWays.Where(w1 => w1.WayNumber == iw.WayNumber).First().Threats;
                foreach (ThreatSource ts in listSources)
                    ts.Threats = db.ThreatSources.Where(so1 => so1.ThreatSourceId == ts.ThreatSourceId).First().Threats;
                listFilteredThreats = new List<Threat>();
            }

            mf.tcThreatsNSD.TabPages.Remove(mf.tpThreatsNSD2);
            mf.tcThreatsNSD.TabPages.Remove(mf.tpThreatsNSD3);

            mf.dgvThreats.DataSource = listThreats;
            mf.dgvThreats.Columns["ThreatID"].Visible = false;
            mf.dgvThreats.Columns["ThreatSources"].Visible = false;
            mf.dgvThreats.Columns["DateOfChange"].Visible = false;
            mf.dgvThreats.Columns["DateOfAdd"].Visible = false;
            mf.dgvThreats.Columns["ImplementWays"].Visible = false;
            mf.dgvThreats.Columns["SFHs"].Visible = false;
            mf.dgvThreats.Columns["Vulnerabilities"].Visible = false;
            mf.dgvThreats.Columns["Description"].Visible = false;
            mf.dgvThreats.Columns["ObjectOfInfluence"].Visible = false;
            mf.dgvThreats.Columns["GISMeasures"].Visible = false;

            mf.dgvThreats.Columns["ThreatNumber"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            mf.dgvThreats.Columns["ConfidenceViolation"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            mf.dgvThreats.Columns["IntegrityViolation"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            mf.dgvThreats.Columns["AvailabilityViolation"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            mf.dgvThreats.Columns["ThreatID"].DisplayIndex = 0;
            mf.dgvThreats.Columns["ThreatNumber"].Width = 60;
            mf.dgvThreats.Columns["ThreatNumber"].DisplayIndex = 1;
            mf.dgvThreats.Columns["ThreatNumber"].HeaderText = "№ УБИ";
            mf.dgvThreats.Columns["Name"].HeaderText = "Название УБИ";
            mf.dgvThreats.Columns["Name"].DisplayIndex = 2;
            mf.dgvThreats.Columns["ConfidenceViolation"].Width = 30;
            mf.dgvThreats.Columns["ConfidenceViolation"].HeaderText = "К";
            mf.dgvThreats.Columns["ConfidenceViolation"].DisplayIndex = 3;
            mf.dgvThreats.Columns["IntegrityViolation"].Width = 30;
            mf.dgvThreats.Columns["IntegrityViolation"].HeaderText = "Ц";
            mf.dgvThreats.Columns["IntegrityViolation"].DisplayIndex = 4;
            mf.dgvThreats.Columns["AvailabilityViolation"].Width = 30;
            mf.dgvThreats.Columns["AvailabilityViolation"].HeaderText = "Д";
            mf.dgvThreats.Columns["AvailabilityViolation"].DisplayIndex = 5;
            mf.dgvThreats.Columns["stringVuls"].HeaderText = "Уязвимости";
            mf.dgvThreats.Columns["stringVuls"].DisplayIndex = 6;
            mf.dgvThreats.Columns["stringWays"].HeaderText = "Способы реализации УБИ";
            mf.dgvThreats.Columns["stringWays"].DisplayIndex = 7;
            mf.dgvThreats.Columns["stringSFHS"].HeaderText = "СФХ";
            mf.dgvThreats.Columns["stringSFHS"].DisplayIndex = 8;
            mf.dgvThreats.Columns["stringSources"].HeaderText = "Источник угрозы";
            mf.dgvThreats.Columns["stringSources"].DisplayIndex = 9;

            mf.dgvThreats.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            mf.dgvThreats.SelectionChanged += new System.EventHandler(dgvThreats_SelectionChanged);
            mf.tpActualThreats.Resize += new System.EventHandler(tpActualThreats_Resize);
            mf.clbThreatFilter.SelectedIndexChanged += new System.EventHandler(clbThreatFilter_SelectedIndexChanged);
            mf.tcThreatsNSD.SelectedIndexChanged += new System.EventHandler(tcThreatsNSD_SelectedIndexChanged);
            mf.btnGotoDamage.Click += new System.EventHandler(btnGotoDamage_Click);
            mf.dgvActualThreatsNSD.SelectionChanged += new System.EventHandler(dgvActualThreats_SelectionChanged);
            mf.btnReady.Click += new System.EventHandler(btnReady_Click);
        }

        public void initTabPageThreatsNSD2()
        {
            // дизайн DataGridView для определения актуальных УБИ
            mf.dgvActualThreatsNSD.Columns.Clear();
            mf.dgvActualThreatsNSD.Rows.Clear();
            
            mf.dgvActualThreatsNSD.Columns.Add("ThreatNumber", "№");
            mf.dgvActualThreatsNSD.Columns["ThreatNumber"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            mf.dgvActualThreatsNSD.Columns["ThreatNumber"].Width = 40;

            mf.dgvActualThreatsNSD.Columns.Add("Name", "Название УБИ");

            mf.dgvActualThreatsNSD.Columns.Add("Feasibility", "Возможность реализации УБИ");
            mf.dgvActualThreatsNSD.Columns["Feasibility"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            mf.dgvActualThreatsNSD.Columns["Feasibility"].Width = 115;

            mf.dgvActualThreatsNSD.Columns.Add("DamageDegree", "Степень ущерба от реализации УБИ");
            mf.dgvActualThreatsNSD.Columns["DamageDegree"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            mf.dgvActualThreatsNSD.Columns["DamageDegree"].Width = 115;

            mf.dgvActualThreatsNSD.Columns.Add("IsActual", "Актуальность");
            mf.dgvActualThreatsNSD.Columns["IsActual"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            mf.dgvActualThreatsNSD.Columns["IsActual"].Width = 95;

            int i = 0;
            foreach (Threat t in listFilteredThreats)
            {
                mf.dgvActualThreatsNSD.Rows.Add();
                mf.dgvActualThreatsNSD.Rows[i].Cells[mf.dgvActualThreatsNSD.Columns["ThreatNumber"].Index].Value = t.ThreatNumber;
                mf.dgvActualThreatsNSD.Rows[i].Cells[mf.dgvActualThreatsNSD.Columns["Name"].Index].Value = t.Name;
                i++;
            }
            
            calcFeasibility();

            damageDegreeInput = new Dictionary<int, int[,,]>();
            foreach (DataGridViewRow dgvRow in mf.dgvActualThreatsNSD.Rows)
                damageDegreeInput.Add((int)dgvRow.Cells[mf.dgvActualThreatsNSD.Columns["ThreatNumber"].Index].Value,
                    new int[IS.listOfInfoTypes.Count, 3, 7]);

            DDControl = new DamageDegreeControl(IS.listOfInfoTypes, listFilteredThreats, damageDegreeInput, mf);
            DDControl.Location = new Point(mf.tpThreatsNSD2.Width - DDControl.Width, 0);
            DDControl.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            mf.tpThreatsNSD2.Controls.Add(DDControl);   

            mf.tcThreatsNSD.SelectedTab = mf.tpThreatsNSD2;
        }

        public void initTabPageThreatsNSD3()
        {
            // дизайн DataGridView для вывода перечня актуальных УБИ
            mf.dgvFinalNSDThreats.Columns.Clear();
            mf.dgvFinalNSDThreats.Rows.Clear();

            mf.dgvFinalNSDThreats.Columns.Add("ThreatNumber", "№");
            mf.dgvFinalNSDThreats.Columns["ThreatNumber"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            mf.dgvFinalNSDThreats.Columns["ThreatNumber"].Width = 40;

            mf.dgvFinalNSDThreats.Columns.Add("Name", "Название УБИ");

            // Заполнение Dgv
            int i = 0;
            IS.listOfActualNSDThreats.Clear();
            foreach (DataGridViewRow row in mf.dgvActualThreatsNSD.Rows)
            {
                int indexActuality = mf.dgvActualThreatsNSD.Columns["IsActual"].Index;
                if (row.Cells[indexActuality].Value.ToString() != "Актуальная") continue;
                int indexNumber = mf.dgvFinalNSDThreats.Columns["ThreatNumber"].Index;

                mf.dgvFinalNSDThreats.Rows.Add();
                mf.dgvFinalNSDThreats.Rows[i].Cells[mf.dgvFinalNSDThreats.Columns["ThreatNumber"].Index].Value = 
                    row.Cells[mf.dgvActualThreatsNSD.Columns["ThreatNumber"].Index].Value.ToString();
                mf.dgvFinalNSDThreats.Rows[i].Cells[mf.dgvFinalNSDThreats.Columns["Name"].Index].Value =
                    row.Cells[mf.dgvActualThreatsNSD.Columns["Name"].Index].Value.ToString();

                int tNumber = Convert.ToInt32(row.Cells[mf.dgvActualThreatsNSD.Columns["ThreatNumber"].Index].Value.ToString());
                
                IS.listOfActualNSDThreats.Add(listThreats.Where(t => t.ThreatNumber == tNumber).FirstOrDefault());
                i++;
            }

            mf.tcThreatsNSD.SelectedTab = mf.tpThreatsNSD3;
        }

        public void calcFeasibility()
        {
            foreach (Threat threat in listFilteredThreats)
            {
                int maxPotencial = 0;
                int feasibility = 2;
                List<ThreatSource> tsList = threat.ThreatSources.ToList();
                foreach (ThreatSource ts in tsList)
                    if (ts.Potencial != 3 && ts.Potencial > maxPotencial) maxPotencial = ts.Potencial;

                // implementPossibility: 0 - низкий, 1 - средний, 2 - высокий
                if (IS.ProjectSecutiryLvl == 2 && maxPotencial == 0)
                    feasibility = 0;
                if ((IS.ProjectSecutiryLvl == 1 && maxPotencial == 0) || (IS.ProjectSecutiryLvl == 2 && maxPotencial == 1))
                    feasibility = 1;
                
                foreach (DataGridViewRow row in mf.dgvActualThreatsNSD.Rows)
                {
                    int indexNumber = mf.dgvActualThreatsNSD.Columns["ThreatNumber"].Index;
                    int indexDamage = mf.dgvActualThreatsNSD.Columns["DamageDegree"].Index;
                    int indexActuality = mf.dgvActualThreatsNSD.Columns["IsActual"].Index;
                    int indexFeasibility = mf.dgvActualThreatsNSD.Columns["Feasibility"].Index;
                    if (row.Cells[indexNumber].Value.ToString() == threat.ThreatNumber.ToString())
                        switch (feasibility)
                        {
                            case 0:
                                row.Cells[indexFeasibility].Value = "Низкая";
                                break;
                            case 1:
                                row.Cells[indexFeasibility].Value = "Средняя";
                                break;
                            case 2:
                                row.Cells[indexFeasibility].Value = "Высокая";
                                row.Cells[indexDamage].Value = "Не определена";
                                row.Cells[indexActuality].Value = "Актуальная";
                                row.DefaultCellStyle.BackColor = Color.LightGreen;
                                break;                            
                        }
                }
            }
        }

        
        private void btnReady_Click(object sender, EventArgs e)
        {
            int k = 0;
            foreach (DataGridViewRow row in mf.dgvActualThreatsNSD.Rows)
            {
                int indexActuality = mf.dgvActualThreatsNSD.Columns["IsActual"].Index;
                if (row.Cells[indexActuality].Value != null && row.Cells[indexActuality].Value.ToString() != "")
                    k++;
            }

            if (k == mf.dgvActualThreatsNSD.Rows.Count)
            {
                if (!mf.tcThreatsNSD.TabPages.Contains(mf.tpThreatsNSD3))
                {
                    mf.tcThreatsNSD.TabPages.Add(mf.tpThreatsNSD3);
                    initTabPageThreatsNSD3();
                }
                else
                if (MessageBox.Show("Обновить итоговый список актуальных угроз?", "Требуется подтверждение!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    initTabPageThreatsNSD3();
                }
            }
            else
                MessageBox.Show("Актуальность не определена для всех угроз. Укажите степень ущерба.", "Внимание", MessageBoxButtons.OK);
        }

        public override void enterTabPage()
        {
            mf.lblThreatsCount.Text = "Кол-во УБИ: " + mf.dgvThreats.RowCount;
            if (firstEnter)
            {
                mf.clbThreatFilter.SetItemChecked(0, true);
                mf.clbThreatFilter.SetItemChecked(1, true);
                mf.clbThreatFilter.SetItemChecked(2, true);
                mf.clbThreatFilter.SetItemChecked(3, true);
                firstEnter = false;
            }
            if (mf.tcThreatsNSD.SelectedTab == mf.tpThreatsNSD1)
            {
                filterThreatList();
                checkInputData();
            }
               
            mf.dgvThreats.ClearSelection();
        }

        public void checkInputData()
        {
            if (IS.listOfSources.Count < 2)
            {
                if (MessageBox.Show("Определите характерные для ИС виды нарушителя для получения итогового перечня УБИ. Перейти к выбору?", "Недостаточно исходных данных", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    mf.treeView.SelectedNode = mf.returnTreeNode("tnIntruder");
                return;
            }
            if (IS.listOfImplementWays.Count == 0)
            {
                if (MessageBox.Show("Определите характерные для ИС способы реализации угроз для получения итогового перечня УБИ. Перейти к выбору?", "Недостаточно исходных данных", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    mf.treeView.SelectedNode = mf.returnTreeNode("tnIntruder");
                return;
            }
            if (IS.listOfVulnerabilities.Count == 0)
            {
                if (MessageBox.Show("Определите характерные для ИС потенциальные уязвимости для получения итогового перечня УБИ. Перейти к выбору?", "Недостаточно исходных данных", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    mf.treeView.SelectedNode = mf.returnTreeNode("tnVulnerabilities");
                return;
            }
            if (IS.listOfSFHs.Count == 0)
            {
                if (MessageBox.Show("Определите структурно-функциональные характеристики ИС для получения итогового перечня УБИ. Перейти к выбору?", "Недостаточно исходных данных", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    mf.treeView.SelectedNode = mf.returnTreeNode("tnOptions");
                return;
            }
        }

        public override void saveChanges()
        {
        }

        private void filterThreatList()
        {
            List<Threat> listThreatsByVul = new List<Threat>();
            List<Threat> listThreatsBySFH = new List<Threat>();
            List<Threat> listThreatsByWay = new List<Threat>();
            List<Threat> listThreatsBySource = new List<Threat>();

            // фильтрация УБИ по источнику угрозы
            if (mf.clbThreatFilter.GetItemCheckState(0) == CheckState.Checked)
            {
                listThreatsBySource = new List<Threat>();

                foreach (ThreatSource ts in IS.listOfSources)
                    listThreatsBySource = unionLists(listThreatsBySource, listSources.Where(lts => lts.ThreatSourceId == ts.ThreatSourceId).First().Threats.ToList());
            }
            else
                listThreatsBySource.AddRange(listThreats);

            // фильтрация УБИ по способам реализации
            if (mf.clbThreatFilter.GetItemCheckState(1) == CheckState.Checked)
            {
                listThreatsByWay = new List<Threat>();

                foreach (ImplementWay iw in IS.listOfImplementWays)
                    listThreatsByWay = unionLists(listThreatsByWay, listImplementWays.Where(way => way.WayNumber == iw.WayNumber).First().Threats.ToList());
            }
            else
                listThreatsByWay.AddRange(listThreats);

            // фильтрация УБИ по уязвимостям
            if (mf.clbThreatFilter.GetItemCheckState(2) == CheckState.Checked)
            {
                listThreatsByVul = new List<Threat>();

                foreach (Vulnerability vul in IS.listOfVulnerabilities)
                    listThreatsByVul = unionLists(listThreatsByVul, listVulnerabilities.Where(w => w.VulnerabilityNumber == vul.VulnerabilityNumber).First().Threats.ToList());
            }
            else
                listThreatsByVul.AddRange(listThreats);

            // фильтрация УБИ по СФХ
            if (mf.clbThreatFilter.GetItemCheckState(3) == CheckState.Checked)
            {
                listThreatsBySFH = new List<Threat>();

                foreach (SFH sfh in IS.listOfSFHs)
                    listThreatsBySFH = unionLists(listThreatsBySFH, listSFHs.Where(s => s.SFHNumber == sfh.SFHNumber).First().Threats.ToList());
            }
            else
                listThreatsBySFH.AddRange(listThreats);

            listFilteredThreats = intersectLists(listThreatsBySource, intersectLists(listThreatsByWay, intersectLists(listThreatsByVul, listThreatsBySFH)));
            mf.dgvThreats.DataSource = listFilteredThreats;
            mf.lblThreatsCount.Text = "Кол-во УБИ: " + mf.dgvThreats.RowCount;
        }

        private List<Threat> unionLists(List<Threat> first, List<Threat> second)
        {
            List<Threat> result = new List<Threat>();
            result.AddRange(first);

            foreach(Threat item in second)
                if (!result.Exists(r => r.ThreatNumber == item.ThreatNumber))
                    result.Add(item);
            return result;
        }

        private List<Threat> intersectLists(List<Threat> first, List<Threat> second)
        {
            List<Threat> result = new List<Threat>();
            
            foreach (Threat item in first)
                if (second.Exists(r => r.ThreatNumber == item.ThreatNumber))
                    result.Add(item);
            return result.OrderBy(o => o.ThreatNumber).ToList();
        }

        private void dgvThreats_SelectionChanged(object sender, EventArgs e)
        {
            if (mf.dgvThreats.SelectedRows.Count > 0)
                mf.tbThreatDescription.Text =
                    listThreats.Where(t => t.ThreatNumber == (int)mf.dgvThreats.SelectedCells[mf.dgvThreats.Columns["ThreatNumber"].Index].Value).FirstOrDefault().Description;
            else
                mf.tbThreatDescription.Text = "Выберите угрозу для просмотра описания...";
        }

        private void tpActualThreats_Resize(object sender, EventArgs e)
        {
            mf.dgvThreats.Height = mf.tpThreatsNSD1.Height - 145;
            if (DDControl != null)
                mf.dgvActualThreatsNSD.Width = mf.tpThreatsNSD2.Width - DDControl.Width - 30;
            mf.dgvActualThreatsNSD.Height = mf.tpThreatsNSD2.Height - 5;
        }

        private void clbThreatFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterThreatList();
        }

        private void tcThreatsNSD_SelectedIndexChanged(object sender, EventArgs e)
        {
            tpActualThreats_Resize(null, null);
        }

        private void btnGotoDamage_Click(object sender, EventArgs e)
        {
            // выбрать все критерии фильтра УБИ
            for (int i = 0; i < mf.clbThreatFilter.Items.Count; i++)
                mf.clbThreatFilter.SetItemChecked(i, true);

            if (mf.dgvThreats.Rows.Count == 0)
            {
                MessageBox.Show("Введите исходные данные для получения списка УБИ", "Список УБИ пуст", MessageBoxButtons.OK);
                checkInputData();
                return;
            }                

            if (IS.listOfInfoTypes.Count == 0)
            {
                if (MessageBox.Show("Для определения степеней ущерба, требуется выбрать виды информации. Перейти к выбору?", "Недостаточно исходных данных", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    mf.treeView.SelectedNode = mf.returnTreeNode("tnOptions");
                }
                return;
            }

            if (!mf.tcThreatsNSD.TabPages.Contains(mf.tpThreatsNSD2))
            {
                mf.tcThreatsNSD.TabPages.Add(mf.tpThreatsNSD2);
                initTabPageThreatsNSD2();
            }
            else
                if (MessageBox.Show("Запустить инициализацию формы определения степеней ущерба заново?", "Требуется подтверждение!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    mf.tpThreatsNSD2.Controls.Remove(DDControl);
                    DDControl = null;
                    damageDegreeInput = null;
                    initTabPageThreatsNSD2();
                }
        }

        private void dgvActualThreats_SelectionChanged(object sender, EventArgs e)
        {
            if (mf.dgvActualThreatsNSD.SelectedRows.Count == 0)
                return;
            if (DDControl == null)
                return;
            int threatNnew = (int)mf.dgvActualThreatsNSD.SelectedRows[0].Cells[mf.dgvActualThreatsNSD.Columns["ThreatNumber"].Index].Value;
            DDControl.Update(threatNnew);
        }
    }
}
