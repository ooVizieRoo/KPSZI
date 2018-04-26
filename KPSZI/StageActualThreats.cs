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
        List<Threat> listThreatsFiltered;
        List<Vulnerability> listVulnerabilities;

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
                listVulnerabilities = db.Vulnerabilities.ToList();
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

            mf.dgvThreats.Columns["ThreatNumber"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            mf.dgvThreats.Columns["ConfidenceViolation"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            mf.dgvThreats.Columns["IntegrityViolation"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            mf.dgvThreats.Columns["AvailabilityViolation"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            mf.dgvThreats.Columns["ThreatNumber"].Width = 60;
            mf.dgvThreats.Columns["ConfidenceViolation"].Width = 30;
            mf.dgvThreats.Columns["IntegrityViolation"].Width = 30;
            mf.dgvThreats.Columns["AvailabilityViolation"].Width = 30;
            mf.dgvThreats.Columns["ThreatNumber"].HeaderText = "№ УБИ";
            mf.dgvThreats.Columns["ConfidenceViolation"].HeaderText = "К";
            mf.dgvThreats.Columns["IntegrityViolation"].HeaderText = "Ц";
            mf.dgvThreats.Columns["AvailabilityViolation"].HeaderText = "Д";
            mf.dgvThreats.Columns["Name"].HeaderText = "Название УБИ";
            mf.dgvThreats.Columns["ObjectOfInfluence"].HeaderText = "Объект воздействия";

            mf.dgvThreats.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            mf.dgvThreats.SelectionChanged += new System.EventHandler(dgvThreats_SelectionChanged);
            mf.tpActualThreats.Resize += new System.EventHandler(tpActualThreats_Resize);
            mf.clbThreatFilter.SelectedIndexChanged += new System.EventHandler(clbThreatFilter_SelectedIndexChanged);
            
        }


        public override void enterTabPage()
        {
            mf.dgvThreats.ClearSelection();
        }

        public override void saveChanges()
        {
        }

        private void dgvThreats_SelectionChanged(object sender, EventArgs e)
        {
            if (mf.dgvThreats.SelectedRows.Count > 0)
                mf.tbThreatDescription.Text =
                    listThreats.Where(t => t.ThreatNumber == (int)mf.dgvThreats.SelectedRows[0].Cells[1].Value).First().Description;
            else
                mf.tbThreatDescription.Text = "Выберите угрозу для просмотра описания...";
            
        }

        private void tpActualThreats_Resize(object sender, EventArgs e)
        {
            mf.dgvThreats.Height = mf.tpActualThreats.Height - 100;
        }

        private void clbThreatFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            listThreatsFiltered = new List<Threat>();
            listThreatsFiltered.AddRange(listThreats);
            using (KPSZIContext db = new KPSZIContext())
            {
                if (mf.clbThreatFilter.GetItemCheckState(0) == CheckState.Checked)
                {
                    listThreatsFiltered.Clear();
                    foreach (Vulnerability v in IS.listOfVulnerabilities)
                        listThreatsFiltered = unionLists(listThreatsFiltered, db.Vulnerabilities.Where(w => w.VulnerabilityNumber == v.VulnerabilityNumber).First().Threats.ToList());
                    
                    mf.dgvThreats.DataSource = listThreatsFiltered;
                }
                else
                {
                    listThreatsFiltered = listThreats.ToList();
                    mf.dgvThreats.DataSource = listThreatsFiltered;
                }
            }
        }

        private List<Threat> unionLists(List<Threat> first, List<Threat> second)
        {
            List<Threat> result = new List<Threat>();
            result.AddRange(first);

            foreach(Threat item in second)
                if (!result.Contains(item))
                    result.Add(item);
            return result;
        }
    }
}
