using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KPSZI.Model;
using System.Drawing;

namespace KPSZI
{
    class StageClassification : Stage
    {
        public StageClassification(TabPage stageTab, TreeNode stageNode, MainForm mainForm)
            :base(stageTab, stageNode, mainForm)
        {
            Init();
        }

        public List<TabPage> tabPagesInfoTypes = new List<TabPage>();

        public void Init()
        {
            using (Model.KPSZIContext db = new KPSZIContext())
            {
                foreach (InfoType it in db.InfoTypes)
                {
                    if (it.TypeName == "Персональные данные")
                        continue;

                    TabPage tp = new TabPage { Name = it.TypeName, Text = it.TypeName };

                    Label labelConf = new Label { Text = "Конфиденциальность" };
                    labelConf.Location = new Point { X = 10, Y = 10 };
                    labelConf.Width = 200;

                    Label labelInteg = new Label { Text = "Целостность" };
                    labelInteg.Location = new Point { X = 10, Y = 40 };

                    Label labelAvail = new Label { Text = "Доступность" };
                    labelAvail.Location = new Point { X = 10, Y = 70 };


                    ComboBox cbConf = new ComboBox { Name = "cbConf", DropDownStyle = ComboBoxStyle.DropDownList };
                    cbConf.Location = new Point { X = 135, Y = 7 };
                    cbConf.Items.Add("Высокий");
                    cbConf.Items.Add("Средний");
                    cbConf.Items.Add("Низкий");

                    ComboBox cbInteg = new ComboBox { Name = "cbInteg", DropDownStyle = ComboBoxStyle.DropDownList };
                    cbInteg.Location = new Point { X = 135, Y = 37 };
                    cbInteg.Items.Add("Высокий");
                    cbInteg.Items.Add("Средний");
                    cbInteg.Items.Add("Низкий");

                    ComboBox cbAvail = new ComboBox { Name = "cbAvail", DropDownStyle = ComboBoxStyle.DropDownList };
                    cbAvail.Location = new Point { X = 135, Y = 67 };
                    cbAvail.Items.Add("Высокий");
                    cbAvail.Items.Add("Средний");
                    cbAvail.Items.Add("Низкий");

                    tp.Controls.AddRange(new Control[] { cbConf, cbAvail, cbInteg, labelAvail, labelConf, labelInteg });
                    tabPagesInfoTypes.Add(tp);
                }
            }
        }

    }
}
