using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KPSZI
{
    class StageIntruder : Stage
    {
        List<string> implementWays = new List<string>();

        public StageIntruder(TabPage stageTab, TreeNode stageNode, MainForm mainForm, InformationSystem IS)
            : base(stageTab, stageNode, mainForm, IS)
        {
            
        }

        public override void enterTabPage()
        {
            int k = 0;
            int yLoc = 0;
            foreach (string s in implementWays)
            {
                CheckBox cb = new CheckBox();
                cb.Text = s;
                cb.AutoSize = false;
                int y = 13 * ((TextRenderer.MeasureText(s, mf.clbImplementWays.Font).Width+50) / (mf.clbImplementWays.Width - 25) + 1) + 4;
                cb.Size = new Size(mf.clbImplementWays.Width - 25, y);
                cb.Location = new Point(0, yLoc);
                yLoc += y;                                
                k++;
                mf.clbImplementWays.Controls.Add(cb);
                //Console.WriteLine(TextRenderer.MeasureText(s, mf.clbImplementWays.Font).Width + ", " + (mf.clbImplementWays.Width - 25) + ", " + (TextRenderer.MeasureText(s, mf.clbImplementWays.Font).Width / (mf.clbImplementWays.Width - 25)));
                
            }

            yLoc += 14;
            mf.clbImplementWays.Height = yLoc;
            
        }

        public override void initTabPage()
        {

        }

        public override void saveChanges()
        {

        }
    }
}
