using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KPSZI
{
    class StageTopology : Stage
    {
        protected override ImageList imageListForTabPage { get; set; }

        public StageTopology(TabPage stageTab, TreeNode stageNode, MainForm mainForm, InformationSystem IS)
            : base(stageTab, stageNode, mainForm, IS)
        {

        }

        public override void enterTabPage()
        {

        }

        public override void saveChanges()
        {

        }

        protected override void initTabPage()
        {

        }
    }
}
