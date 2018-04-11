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
        List<InfoType> listInfoTypes;

        public StageOptions (TabPage stageTab, TreeNode stageNode, MainForm mainForm, InformationSystem IS)
            :base(stageTab, stageNode, mainForm, IS)
        {
            initClass();
        }
         public void initClass()
        {
            using (KPSZIContext db = new KPSZIContext())
            {
                // Инициализация списка видов угроз

                listInfoTypes = db.InfoTypes.ToList();

                ((ListBox)mf.lbInfoTypes).DataSource = listInfoTypes;
                ((ListBox)mf.lbInfoTypes).DisplayMember = "TypeName";
                ((ListBox)mf.lbInfoTypes).ValueMember = "InfoTypeId";

                mf.lbInfoTypes.Size = new Size(293, 4 + 15 * mf.lbInfoTypes.Items.Count);

                //Инициализация СФХ групбоксов
                List<SFHType> listSFHTypes = db.SFHTypes.ToList();
                List<SFH> listSFHs = db.SFHs.ToList();

                GroupBox gb;
                RadioButton rb;
                CheckBox cb;
                Dictionary<int, CheckBox> cbs = new Dictionary<int, CheckBox>();
                Dictionary<int, RadioButton> rbs = new Dictionary<int, RadioButton>();
                int i = 0;
                int j = 0;
                int gbY = 30;

                foreach (SFHType itemSFHType in listSFHTypes)
                {
                    gb = new GroupBox();
                    gb.Location = new Point(313, gbY);                    
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
                            cbs.Add(itemSFH.SFHId, cb);
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
        
        public override void saveChanges()
        {
            Console.WriteLine(stageName);

            //IS.listOfInfoTypes.Add();
        }

        public override void enterTabPage()
        {
            // берем из экземпляра выбранные виды информации и возвращаем их в чеклистбокс при переходе по вкладкам
            for (int i = 0; i < IS.listOfInfoTypes.Count; i++)
            {
                int k = mf.lbInfoTypes.Items.IndexOf(IS.listOfInfoTypes[i]);
                mf.lbInfoTypes.SetItemChecked(k, true);
            }
        }
    }
}
