using KPSZI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace KPSZI
{
    class StageSZI:Stage
    {
        protected override ImageList imageListForTabPage { get; set; }
        List<SZI> listOfSZIsFromDB;
        List<RadioButton> radiobuttonsSZISorts;
        List<CheckBox> checkboxesSZISorts;

        public StageSZI(TabPage stageTab, TreeNode stageNode, MainForm mainForm, InformationSystem IS)
            : base(stageTab, stageNode, mainForm, IS)
        {
            mf.btnGetRequirm.Click += BtnTest_Click;
            mf.btnGetSZI.Click += BtnGetSZI_Click;
        }

        private void BtnGetSZI_Click(object sender, EventArgs e)
        {
            mf.dgvTest.Rows.Clear();
            //using (KPSZIContext db = new KPSZIContext())
            //{
            //    int i = 0;
            //    var listSZI = db.SZIs.ToList().Intersect(IS.listOfSZIs);
            //    foreach (SZI szi in listSZI)
            //        mf.dgvTest.Rows.Add(i++, szi.Name);
            //}

            using (KPSZIContext db = new KPSZIContext())
            {
                int i = 0;
                var listSZISorts = db.SZISorts.ToList();

                foreach (SZISort ss in listSZISorts)
                {
                    string measures = "";
                    foreach (GISMeasure gm in ss.GISMeasures)
                        measures += gm.MeasureGroup.ShortName + "." + gm.Number + "\n";

                    mf.dgvTest.Rows.Add(++i, ss.Name, measures);
                }
            }

        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            switch (IS.GISClass)
            {
                case 1: { mf.tbtpSZISVT.Text = "не ниже 5-го класса"; mf.tbtpSZISZI.Text = "не ниже 4-го класса"; mf.tbtpSZINDV.Text = "4";  break; }
                case 2: { mf.tbtpSZISVT.Text = "не ниже 5-го класса"; mf.tbtpSZISZI.Text = "не ниже 5-го класса"; mf.tbtpSZINDV.Text = "4"; break; }
                case 3: { mf.tbtpSZISVT.Text = "не ниже 5-го класса"; mf.tbtpSZISZI.Text = "не ниже 6-го класса"; mf.tbtpSZINDV.Text = "не требуется"; break; }
                default:
                    {
                        if (MessageBox.Show("Не определен класс защищенности для дальнейшней работы. \nПерейти во вкладку \"Классификация\"?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            mf.treeView.SelectedNode = mf.returnTreeNode("tnClassification");
                            return;
                        }
                        else
                            return;
                    }
            }

            using (KPSZIContext db = new KPSZIContext())
            {
                listOfSZIsFromDB = db.SZIs.ToList();
                var listSZISorts = db.SZISorts.ToList();

                GroupBox gb;
                RadioButton rb;
                CheckBox cb;
                radiobuttonsSZISorts = new List<RadioButton>();
                checkboxesSZISorts = new List<CheckBox>();

                int i = 0;
                int j = 0;
                int gbY = 173;

                foreach (SZISort szisort in listSZISorts)
                {
                    gb = new GroupBox();
                    gb.Location = new Point(7, gbY);
                    gb.Text = szisort.Name;

                    foreach (SZI szi in szisort.SZIs)
                    {
                        if (szisort.ShortName != "САВЗ")
                        {
                            rb = new RadioButton();
                            rb.Text = szi.Name;
                            rb.Margin = new Padding(10, 5, 5, 5);
                            rb.Location = new Point(10, 17 + (17 * j));
                            rb.Size = new Size(440, 17);
                            rb.CheckedChanged += Rb_CheckedChanged;
                            radiobuttonsSZISorts.Add(rb);
                            gb.Controls.Add(rb);
                            j++;
                        }
                        else
                        {
                            cb = new CheckBox();
                            cb.Text = szi.Name;
                            cb.Margin = new Padding(10, 5, 5, 5);
                            cb.Location = new Point(10, 17 + (17 * j));
                            cb.Size = new Size(440, 17);
                            cb.CheckedChanged += Rb_CheckedChanged;
                            checkboxesSZISorts.Add(cb);
                            gb.Controls.Add(cb);
                            j++;
                        }
                    }

                    gb.Size = new Size(440, 25 + j * 17);
                    gbY += 30 + j * 17;
                    j = 0;
                    //stageTab.Controls.Add(gb);
                    mf.tpOne.Controls.Add(gb);

                    i++;
                }
            }
        }

        private void Rb_CheckedChanged(object sender, EventArgs e)
        {
            foreach (RadioButton rb in radiobuttonsSZISorts)
            {
                SZI szi = listOfSZIsFromDB.Where(s => s.Name == rb.Text).First();
                if (rb.Checked && !IS.listOfSZIs.Contains(szi))
                    IS.listOfSZIs.Add(szi);
                if (!rb.Checked && IS.listOfSZIs.Contains(szi))
                    IS.listOfSZIs.Remove(szi);
            }

            foreach (CheckBox cb in checkboxesSZISorts)
            {
                SZI szi = listOfSZIsFromDB.Where(s => s.Name == cb.Text).First();
                if (cb.Checked && !IS.listOfSZIs.Contains(szi))
                    IS.listOfSZIs.Add(szi);
                if (!cb.Checked && IS.listOfSZIs.Contains(szi))
                    IS.listOfSZIs.Remove(szi);
            }

            
        }



        protected override void initTabPage()
        {
            mf.dgvTest.Columns.Add("Count", "№");
            mf.dgvTest.Columns.Add("SZI", "Наименование СЗИ");
            mf.dgvTest.Columns.Add("Measures", "Перечень реализуемых мер");
        }

        public override void saveChanges()
        {

        }

        public override void enterTabPage()
        {

        }
    }
}
