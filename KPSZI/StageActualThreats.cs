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

        public StageActualThreats(TabPage stageTab, TreeNode stageNode, MainForm mainForm, InformationSystem IS)
            : base(stageTab, stageNode, mainForm, IS)
        {
            using (KPSZIContext db = new KPSZIContext())
            {
                // Инициализация списка угроз

                listThreats = db.Threats.ToList();
                mf.dgvThreats.DataSource = listThreats;
                mf.dgvThreats.Columns["ThreatID"].Visible = false;
                mf.dgvThreats.Columns["ThreatSources"].Visible = false;
                mf.dgvThreats.Columns["DateOfChange"].Visible = false;
                mf.dgvThreats.Columns["DateOfAdd"].Visible = false;

            }
        }

        public override void enterTabPage()
        {
            
        }

        public override void saveChanges()
        {
        }
    }
}
