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
        List<Threat> listThreats;
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
            mf.dgvActualThreats.SelectionChanged += new System.EventHandler(dgvActualThreats_SelectionChanged);


        }

        public void initTabPageThreatsNSD2()
        {
            // дизайн DataGridView для определения актуальных УБИ
            mf.dgvActualThreats.DataSource = null;
            mf.dgvActualThreats.Columns.Clear();
            mf.dgvActualThreats.Rows.Clear();

            mf.dgvActualThreats.DataSource = listFilteredThreats;

            mf.dgvActualThreats.Columns["ThreatID"].Visible = false;
            mf.dgvActualThreats.Columns["ThreatSources"].Visible = false;
            mf.dgvActualThreats.Columns["DateOfChange"].Visible = false;
            mf.dgvActualThreats.Columns["DateOfAdd"].Visible = false;
            mf.dgvActualThreats.Columns["ImplementWays"].Visible = false;
            mf.dgvActualThreats.Columns["SFHs"].Visible = false;
            mf.dgvActualThreats.Columns["Vulnerabilities"].Visible = false;
            mf.dgvActualThreats.Columns["Description"].Visible = false;
            mf.dgvActualThreats.Columns["ObjectOfInfluence"].Visible = false;
            mf.dgvActualThreats.Columns["ConfidenceViolation"].Visible = false;
            mf.dgvActualThreats.Columns["IntegrityViolation"].Visible = false;
            mf.dgvActualThreats.Columns["AvailabilityViolation"].Visible = false;
            mf.dgvActualThreats.Columns["stringVuls"].Visible = false;
            mf.dgvActualThreats.Columns["stringWays"].Visible = false;
            mf.dgvActualThreats.Columns["stringSFHS"].Visible = false;
            mf.dgvActualThreats.Columns["stringSources"].Visible = false;
            mf.dgvActualThreats.Columns["GISMeasures"].Visible = false;

            mf.dgvActualThreats.Columns["ThreatNumber"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            mf.dgvActualThreats.Columns["ThreatNumber"].Width = 60;
            mf.dgvActualThreats.Columns["ThreatNumber"].DisplayIndex = 1;
            mf.dgvActualThreats.Columns["ThreatNumber"].HeaderText = "№ УБИ";
            mf.dgvActualThreats.Columns["Name"].HeaderText = "Название УБИ";
            mf.dgvActualThreats.Columns["Name"].DisplayIndex = 2;

            mf.dgvActualThreats.Columns.Add("DamageDegree", "Степень ущерба");

            damageDegreeInput = new Dictionary<int, int[,,]>();
            foreach (DataGridViewRow dgvRow in mf.dgvActualThreats.Rows)
                damageDegreeInput.Add((int)dgvRow.Cells[mf.dgvActualThreats.Columns["ThreatNumber"].Index].Value, 
                    new int[IS.listOfInfoTypes.Count, 3, 7]);

            DDControl = new DamageDegreeControl(IS.listOfInfoTypes);
            DDControl.Location = new Point(mf.dgvActualThreats.Width + 20, 0);
            mf.tpThreatsNSD2.Controls.Add(DDControl);
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
            filterThreatList();
            mf.dgvThreats.ClearSelection();
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

            listFilteredThreats = intersectThreatLists(listThreatsBySource, intersectThreatLists(listThreatsByWay, intersectThreatLists(listThreatsByVul, listThreatsBySFH)));
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

        private List<Threat> intersectThreatLists(List<Threat> first, List<Threat> second)
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
            mf.dgvThreats.Height = mf.tpThreatsNSD1.Height - 125;
        }

        private void clbThreatFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterThreatList();

            foreach (Threat threat in listFilteredThreats)
            {
                int maxPotencial = 0;
                int implementPossibility = 2;
                List<ThreatSource> tsList = threat.ThreatSources.ToList();
                foreach (ThreatSource ts in tsList)
                    if (ts.Potencial > maxPotencial) maxPotencial = ts.Potencial;

                if (IS.ProjectSecutiryLvl == 2 && maxPotencial == 0)
                    implementPossibility = 0;
                if ((IS.ProjectSecutiryLvl == 1 && maxPotencial == 0) || (IS.ProjectSecutiryLvl == 2 && maxPotencial == 1))
                    implementPossibility = 1;
                Console.WriteLine("#" + threat.ThreatNumber + ": потенциал нарушителя - " + maxPotencial + ". Возможность реализации: " + implementPossibility);
            }
        }

        private void tcThreatsNSD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mf.tcThreatsNSD.SelectedTab == mf.tpThreatsNSD2)
            {
                
            }
        }

        private void btnGotoDamage_Click(object sender, EventArgs e)
        {
            // выбрать все критерии фильтра УБИ
            for (int i = 0; i < mf.clbThreatFilter.Items.Count; i++)
                mf.clbThreatFilter.SetItemChecked(i, true);

            if (mf.dgvThreats.Rows.Count == 0)
            {
                MessageBox.Show("Введите исходные данные для получения списка УБИ", "Список УБИ пуст", MessageBoxButtons.OK);
                return;
            }                

            if (IS.listOfInfoTypes.Count == 0)
            {
                if (MessageBox.Show("Для определения степеней ущерба, необходимо выбрать виды информации. Перейти к выбору?", "Недостаточно исходных данных", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    mf.treeView.SelectedNode = mf.returnTreeNode("tnOptions");
                }
                return;
            }

            if (!mf.tcThreatsNSD.TabPages.Contains(mf.tpThreatsNSD2))
            {
                mf.tcThreatsNSD.TabPages.Add(mf.tpThreatsNSD2);
                initTabPageThreatsNSD2();
                mf.tcThreatsNSD.SelectedTab = mf.tpThreatsNSD2;
            }
            else
                if (MessageBox.Show("Запустить инициализацию формы определения степеней ущерба заново?", "Требуется подтверждение!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    initTabPageThreatsNSD2();
                    mf.tcThreatsNSD.SelectedTab = mf.tpThreatsNSD2;
                }

        }

        private void dgvActualThreats_SelectionChanged(object sender, EventArgs e)
        {
            // сохраняем данные по Уби
            //foreach()

            if (mf.dgvActualThreats.SelectedRows.Count == 0)
                return;
            int threatN = (int)mf.dgvActualThreats.SelectedRows[0].Cells[mf.dgvActualThreats.Columns["ThreatNumber"].Index].Value;
            DDControl.currentThreatNumber = threatN;
            // выгружаем данные по Уби
        }
    }
}
