using KPSZI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KPSZI
{
    class StageOptions : Stage
    {
        //gbSFH

        public StageOptions (TabPage stageTab, TreeNode stageNode, MainForm mainForm)
            :base(stageTab, stageNode, mainForm)
        {
            initClass();
        }
         public void initClass()
        {
            using (KPSZIContext db = new KPSZIContext())
            {
                var hui = db.SFHTypes.ToList();

                for (int i = 0; i < hui.Count; i++)
                {
                    mf.Controls.Add(new GroupBox());
                }

                
            }
        } 
    }
}
