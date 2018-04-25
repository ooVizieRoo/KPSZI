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

        public StageActualThreats(TabPage stageTab, TreeNode stageNode, MainForm mainForm, InformationSystem IS)
            : base(stageTab, stageNode, mainForm, IS)
        {            
        }
        
        public override void initTabPage()
        {
            using (KPSZIContext db = new KPSZIContext())
            {
                // Инициализация списка угроз
                listThreats = db.Threats.OrderBy(t => t.ThreatNumber).ToList();
                foreach (Threat threat in listThreats)
                {
                    threat.Vulnerabilities = db.Threats.Where(t1 => t1.ThreatNumber == threat.ThreatNumber).First().Vulnerabilities;
                    threat.getStringVulnerabilities();
                }
                    
                listVulnerabilities = db.Vulnerabilities.OrderBy(v => v.VulnerabilityNumber).ToList();
                listSFHs = db.SFHs.OrderBy(s => s.SFHNumber).ToList();
                foreach(Vulnerability vul in listVulnerabilities)
                    vul.Threats = db.Vulnerabilities.Where(v1 => v1.VulnerabilityNumber == vul.VulnerabilityNumber).First().Threats;
                foreach (SFH sfh in listSFHs)
                    sfh.Threats = db.SFHs.Where(s1 => s1.SFHNumber == sfh.SFHNumber).First().Threats;

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

            
            mf.dgvThreats.Columns.Add("ThreatVuls", "Уязвимости");
            mf.dgvThreats.Columns["ThreatVuls"].DisplayIndex = 6;
            //mf.dgvThreats.Columns["ThreatVuls"].

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

            mf.dgvThreats.DataSource = intersectThreatLists(listThreatsByVul, listThreatsBySFH);
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
