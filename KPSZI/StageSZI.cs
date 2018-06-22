using KPSZI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KPSZI
{
    class StageSZI:Stage
    {
        protected override ImageList imageListForTabPage { get; set; }

        public StageSZI(TabPage stageTab, TreeNode stageNode, MainForm mainForm, InformationSystem IS)
            : base(stageTab, stageNode, mainForm, IS)
        {
            mf.btnGetRequirm.Click += BtnTest_Click;
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            using (KPSZIContext db = new KPSZIContext())
            {
                var list = db.SZISorts.ToList();

                int i = 0;
                foreach(SZISort ss in list)
                {
                    foreach(SZI szi in ss.SZIs)
                        mf.dgvTest.Rows.Add(i++, ss.ShortName+ " "+ szi.Name);
                }
            }
        }

        protected override void initTabPage()
        {
            mf.dgvTest.Columns.Add("Count", "№");
            mf.dgvTest.Columns.Add("Name", "Наименование");

        }

        public override void saveChanges()
        {

        }

        public override void enterTabPage()
        {

        }
    }
}
