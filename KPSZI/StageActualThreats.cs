using KPSZI.Model;
using System;
using System.Collections.Generic;
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

        public StageActualThreats(TabPage stageTab, TreeNode stageNode, MainForm mainForm, InformationSystem IS)
            : base(stageTab, stageNode, mainForm, IS)
        {            
        }
        
        protected override void initTabPage()
        {
            using (KPSZIContext db = new KPSZIContext())
            {
                // Инициализация списка угроз
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

            }

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
            
        }


        public override void enterTabPage()
        {
            mf.dgvThreats.ClearSelection();
            mf.lblThreatsCount.Text = "Кол-во УБИ: " + mf.dgvThreats.RowCount;
            filterThreatList();
        }

        public override void saveChanges()
        {
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
            mf.dgvThreats.Height = mf.tpActualThreats.Height - 100;
        }

        private void clbThreatFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterThreatList();    
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

            mf.dgvThreats.DataSource = intersectThreatLists(listThreatsBySource, intersectThreatLists(listThreatsByWay, intersectThreatLists(listThreatsByVul, listThreatsBySFH)));
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
    }
}
