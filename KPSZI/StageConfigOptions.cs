using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KPSZI.Model;

namespace KPSZI
{
    class StageConfigOptions:Stage
    {
        public StageConfigOptions(TabPage stageTab, TreeNode stageNode, MainForm mainForm, InformationSystem IS) : base(stageTab, stageNode, mainForm, IS)
        {
        }

        protected override ImageList imageListForTabPage
        {
            get;
            set;
        }
        
        public override void enterTabPage()
        {
            using (KPSZIContext db = new KPSZIContext())
            {
                var tempGM = db.GisMeasures.ToList().Intersect(IS.listOfAllNSDMeasures).ToList();
                foreach (GISMeasure gm in tempGM)
                {
                    DataGridViewRow dgr = new DataGridViewRow();
                    dgr.CreateCells(mf.dgvConfigNMeasures);
                    dgr.Cells[0].Value = gm.MeasureGroup.ShortName + "." + gm.Number + " " + gm.Description;

                    foreach (ConfigOption co in gm.ConfigOptions)
                    {
                        dgr.Cells[1].Value += co.Name +" (" + co.Description+ ").\n";
                    }
                    if(dgr.Cells[1].Value!=null)
                        mf.dgvConfigNMeasures.Rows.Add(dgr);
                }
            }
        }

        public override void saveChanges()
        {

        }

        protected override void initTabPage()
        {

        }
    }
}
