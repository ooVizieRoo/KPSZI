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
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
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
