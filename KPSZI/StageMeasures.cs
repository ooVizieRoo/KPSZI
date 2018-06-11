using KPSZI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KPSZI
{
    class StageMeasures:Stage
    {
        protected override ImageList imageListForTabPage { get; set; }
        Button btn = new Button();

        public StageMeasures(TabPage stageTab, TreeNode stageNode, MainForm mainForm, InformationSystem IS)
            : base(stageTab, stageNode, mainForm, IS)
        {
            
        }

        protected override void initTabPage()
        {
            btn.Location = new System.Drawing.Point(100, 100);
            btn.Text = "Вывести все меры в консоль";
            btn.Click += Btn_Click;
            mf.tabControl.TabPages[stageTab.Name].Controls.Add(btn);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            using (KPSZIContext db = new KPSZIContext())
            {
                var threats = db.Threats.OrderBy(t => t.ThreatNumber).ToList();

                foreach (Threat thr in threats)
                {
                    Console.WriteLine("{0}. {1}", thr.ThreatNumber, thr.Name);
                    foreach (GISMeasure gm in thr.GISMeasures.OrderBy(m => m.GISMeasureId))
                    {
                        Console.WriteLine("\t {0}.{1} {2}", gm.MeasureGroup.ShortName, gm.Number, gm.Description);
                    }
                }
            }
        }

        public override void saveChanges()
        {

        }

        public override void enterTabPage()
        {

        }



    }
}
