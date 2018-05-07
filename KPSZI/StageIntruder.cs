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
    class StageIntruder : Stage
    {
        List<ImplementWay> ListImplementWays;
        List<IntruderType> ListIntruderTypes;
        List<ThreatSource> ListSources;

        protected override ImageList imageListForTabPage { get; set; }

        public StageIntruder(TabPage stageTab, TreeNode stageNode, MainForm mainForm, InformationSystem IS)
            : base(stageTab, stageNode, mainForm, IS)
        {
            
        }

        public override void enterTabPage()
        {
            
            
        }

        protected override void initTabPage()
        {
            using (KPSZIContext db = new KPSZIContext())
            {
                ListImplementWays = db.ImplementWays.OrderBy(i => i.WayNumber).ToList();
                ListIntruderTypes = db.IntruderTypes.OrderBy(t => t.IntruderTypeId).ToList();
                ListSources = db.ThreatSources.ToList();
            }

            int k = 0;
            int yLoc = 0;
            foreach (ImplementWay iw in ListImplementWays)
            {
                CheckBox cb = new CheckBox();
                cb.Text = iw.WayName;
                cb.AutoSize = false;
                int y = 13 * ((TextRenderer.MeasureText(iw.WayName, mf.clbImplementWays.Font).Width + 50) / (mf.clbImplementWays.Width - 25) + 1) + 4;
                cb.Size = new Size(mf.clbImplementWays.Width - 25, y);
                cb.Location = new Point(4, yLoc);
                cb.CheckedChanged += new System.EventHandler(cbWay_CheckedChanged);
                yLoc += y;
                k++;
                mf.clbImplementWays.Controls.Add(cb);                
            }
            yLoc += 14;
            mf.clbImplementWays.Height = yLoc;

            k = 0;
            yLoc = 0;
            foreach (IntruderType it in ListIntruderTypes)
            {
                CheckBox cb = new CheckBox();
                cb.Text = it.TypeName;
                cb.AutoSize = false;
                int y = 13 * ((TextRenderer.MeasureText(it.TypeName, mf.clbIntruderTypes.Font).Width + 50) / (mf.clbIntruderTypes.Width - 25) + 1) + 4;
                cb.Size = new Size(mf.clbIntruderTypes.Width - 25, y);
                cb.Location = new Point(4, yLoc);
                cb.CheckedChanged += new System.EventHandler(cbIntruder_CheckedChanged);
                yLoc += y;
                k++;
                mf.clbIntruderTypes.Controls.Add(cb);
            }

            yLoc += 14;
            mf.clbIntruderTypes.Height = yLoc;
        }

        public override void saveChanges()
        {
            
        }

        public void calculatePotencial()
        {
            int[] potencial = new int[2] { -1, -1 };

            foreach (CheckBox i in mf.clbIntruderTypes.Controls)
            {
                if (i.CheckState == CheckState.Checked)
                {
                    switch (i.Text)
                    {
                        case "Специальные службы иностранных государств (блоков государств)":
                            potencial[0] = 2;
                            potencial[1] = 2;
                            break;
                        case "Террористические, экстремистские группировки":
                            potencial[1] = potencial[1] < 2 ? 1 : potencial[1];
                            break;
                        case "Преступные группы (криминальные структуры)":
                            potencial[1] = potencial[1] < 2 ? 1 : potencial[1];
                            break;
                        case "Конкурирующие организации":
                            potencial[1] = potencial[1] < 2 ? 1 : potencial[1];
                            break;
                        case "Разработчики, производители, поставщики программных, технических и программно-технических средств":
                            potencial[1] = potencial[1] < 2 ? 1 : potencial[1];
                            break;
                        case "Администраторы информационной системы и администраторы безопасности":
                            potencial[0] = potencial[0] < 2 ? 1 : potencial[0];
                            break;
                        case "Внешние субъекты (физические лица)":
                            potencial[1] = potencial[1] == -1 ? 0 : potencial[1];
                            break;
                        case "Бывшие работники (пользователи)":
                            potencial[1] = potencial[1] == -1 ? 0 : potencial[1];
                            break;
                        case "Пользователи информационной системы":
                            potencial[0] = potencial[0] == -1 ? 0 : potencial[0];
                            break;
                        case "Лица, привлекаемые для установки, наладки, монтажа, пусконаладочных и иных видов работ":
                            potencial[0] = potencial[0] == -1 ? 0 : potencial[0];
                            break;
                        case "Лица, обеспечивающие функционирование информационных систем или обслуживающие инфраструктуру оператора (администрация, охрана, уборщики и т.д.)":
                            potencial[0] = potencial[0] == -1 ? 0 : potencial[0];
                            break;
                    }
                }
            }
            Console.WriteLine("Internal: " + potencial[0] + ", external: " + potencial[1]);
            IS.listOfSources.Clear();            
            if (potencial[0] != -1)
                for (int i = 0; i <= potencial[0]; i++)
                    IS.listOfSources.Add(ListSources.Where(s2 => s2.Potencial == i && s2.InternalIntruder == true).FirstOrDefault());
            if (potencial[1] != -1)
                for (int i = 0; i <= potencial[1]; i++)
                    IS.listOfSources.Add(ListSources.Where(s3 => s3.Potencial == i && s3.InternalIntruder == false).FirstOrDefault());
            IS.listOfSources.Add(ListSources.Where(s1 => s1.Potencial == 3).FirstOrDefault());
            foreach (ThreatSource ts in IS.listOfSources)
                Console.WriteLine(ts.ThreatSourceId);
            Console.WriteLine();
        }

        private void cbWay_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cbWay = (CheckBox)sender;
            ImplementWay way = ListImplementWays.Where(w => w.WayName == cbWay.Text).FirstOrDefault();
            if (cbWay.Checked && !IS.listOfImplementWays.Contains(way))                
                IS.listOfImplementWays.Add(way);
            if (!cbWay.Checked && IS.listOfImplementWays.Contains(way))
                IS.listOfImplementWays.Remove(way);
        }

        private void cbIntruder_CheckedChanged(object sender, EventArgs e)
        {
            calculatePotencial();
            string s = "";
            foreach (ThreatSource ts in IS.listOfSources)
            {
                if (ts.Potencial == 3) continue;
                s += (ts.InternalIntruder ? "Внутренний" : "Внешний") + " нарушитель " +
                    (ts.Potencial == 0 ? "с низким" : (ts.Potencial == 1 ? "со средним" : "с высоким")) + " потенциалом; \n";
            }
            mf.lblPotencial.Text = s;
        }
    }
}
