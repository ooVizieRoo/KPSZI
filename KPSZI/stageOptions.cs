using KPSZI.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KPSZI
{
    class StageOptions : Stage
    {
        public StageOptions (TabPage stageTab, TreeNode stageNode, MainForm mainForm)
            :base(stageTab, stageNode, mainForm)
        {
            initClass();
        }
         public void initClass()
        {
            using (KPSZIContext db = new KPSZIContext())
            {
                // Инициализация списка видов угроз
                var hui = db.InfoTypes.ToList();

                ((ListBox)mf.lbInfoTypes).DataSource = hui;
                ((ListBox)mf.lbInfoTypes).DisplayMember = "TypeName";
                ((ListBox)mf.lbInfoTypes).ValueMember = "InfoTypeId";

                //Инициализация СФХ групбоксов
                List<SFHType> listSFHTypes = db.SFHTypes.ToList();
                List<SFH> listSFHs = db.SFHs.ToList();

                GroupBox gb;
                RadioButton rb;
                CheckBox cb;
                Dictionary<int, object> rbs = new Dictionary<int, object>();
                int i = 0;
                int j = 0;
                int gbY = 7;

                foreach (SFHType itemSFHType in listSFHTypes)
                {
                    gb = new GroupBox();
                    gb.Location = new Point(306, gbY);                    
                    gb.Text = itemSFHType.Name;
                    foreach(SFH itemSFH in itemSFHType.SFHs)
                    {
                        if (itemSFHType.MultipleChoice)
                        {
                            cb = new CheckBox();
                            cb.Text = itemSFH.Name;
                            cb.Margin = new Padding(10, 5, 5, 5);
                            cb.Location = new Point(10, 17 + (17 * j));
                            cb.Size = new Size(440, 17);
                            rbs.Add(itemSFH.SFHId, cb);
                            gb.Controls.Add(cb);
                            j++;
                        } else
                        {
                            rb = new RadioButton();
                            rb.Text = itemSFH.Name;
                            rb.Margin = new Padding(10, 5, 5, 5);
                            rb.Location = new Point(10, 17 + (17 * j));
                            rb.Size = new Size(440, 17);
                            rbs.Add(itemSFH.SFHId, rb);
                            gb.Controls.Add(rb);
                            j++;
                        }
                    }

                    gb.Size = new Size(440, 25 + j * 17);
                    gbY += 30 + j * 17;
                    j = 0;
                    stageTab.Controls.Add(gb);
                    i++;
                }
            }
        } 
    }
}
