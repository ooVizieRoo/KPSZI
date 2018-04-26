using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KPSZI.Model;
using System.Windows.Forms;
using System.Drawing;

namespace KPSZI
{
    class stageTechnoGenThreats : Stage
    {
        List<TechnogenicThreat> tgThreats;
        public stageTechnoGenThreats(TabPage stageTab, TreeNode stageNode, MainForm mainForm, InformationSystem IS) : base(stageTab, stageNode, mainForm, IS)
        {

        }

        public override void enterTabPage()
        {
            int dgvtgm = 0;
            foreach (DataGridViewRow dgvr in mf.dgvTGMeasures.Rows)
            {
                dgvtgm += dgvr.Height;
            }
            mf.dgvTGMeasures.Height = dgvtgm + mf.dgvTGMeasures.ColumnHeadersHeight;

            int dgvtgt = 0;
            foreach (DataGridViewRow dgvr in mf.dgvTGThreats.Rows)
            {
                dgvtgt += dgvr.Height;
            }
            mf.dgvTGThreats.Location = new Point { X = mf.dgvTGMeasures.Location.X, Y = 30 + mf.dgvTGMeasures.Height };
            mf.dgvTGThreats.Height = dgvtgt + mf.dgvTGThreats.ColumnHeadersHeight;
            mf.tcTGThreats.TabPages["tpTGThreatsMeasures"].SetAutoScrollMargin(3, 15);
        }

        public override void initTabPage()
        {
            using (KPSZIContext db = new KPSZIContext())
            {
                tgThreats = db.TechnogenicThreats.ToList();
                foreach (TechnogenicMeasure tgm in db.TechnogenicMeasures)
                {
                    mf.dgvTGMeasures.Rows.Add(false, tgm.Description);
                }
                foreach (TechnogenicThreat tgt in tgThreats)
                {
                    mf.dgvTGThreats.Rows.Add(tgt.Identificator + " " + tgt.Description);
                }
            }
            mf.tcTGThreats.TabPages[1].Enter += enterPageActualThreats;
        }

        public override void saveChanges()
        {

        }

        public void enterPageActualThreats(object sender, EventArgs e)
        {
            mf.dgvActualTGThreats.Rows.Clear();

            bool[] damageGrades = new bool[6];
            
            double[] TUprobs = new double[6];
            double allTU1 = 6;
            TUprobs[0] = allTU1;
            double allTU2 = 6;
            TUprobs[1] = allTU2;
            double allTU3 = 3;
            TUprobs[2] = allTU3;
            double allTU4 = 2;
            TUprobs[3] = allTU4;
            double allTU5 = 2;
            TUprobs[4] = allTU5;
            double allTU6 = 2;
            TUprobs[5] = allTU6;

            double[] TUexists = new double[6];
            double existTU1 = 0;
            double existTU2 = 0;
            double existTU3 = 0;
            double existTU4 = 0;
            double existTU5 = 0;
            double existTU6 = 0;

            #region ++ к вероятности реализации угроз в зав-ти от выбранных реализованных мер
            if ((bool)((DataGridViewCheckBoxCell)(mf.dgvTGMeasures.Rows[0].Cells[0])).Value == false)
            {
                existTU1++;
                existTU2++;
                existTU4++;
            }
            if ((bool)((DataGridViewCheckBoxCell)(mf.dgvTGMeasures.Rows[1].Cells[0])).Value == false)
            {
                existTU5++;
                existTU6++;
            }
            if ((bool)((DataGridViewCheckBoxCell)(mf.dgvTGMeasures.Rows[2].Cells[0])).Value == false)
            {
                existTU1++;
                existTU2++;
                existTU3++;
            }
            if ((bool)((DataGridViewCheckBoxCell)(mf.dgvTGMeasures.Rows[3].Cells[0])).Value == false)
            {
                existTU1++;
                existTU2++;
                existTU3++;
            }
            if ((bool)((DataGridViewCheckBoxCell)(mf.dgvTGMeasures.Rows[4].Cells[0])).Value == false)
            {
                existTU1++;
                existTU2++;
                existTU3++;
            }
            if ((bool)((DataGridViewCheckBoxCell)(mf.dgvTGMeasures.Rows[5].Cells[0])).Value == false)
            {
                existTU1++;
                existTU2++;
                existTU4++;
                existTU5++;
                existTU6++;
            }
            if ((bool)((DataGridViewCheckBoxCell)(mf.dgvTGMeasures.Rows[6].Cells[0])).Value == false)
            {
                existTU1++;
                existTU2++;
            }
            TUexists[0] = existTU1;
            TUexists[1] = existTU2;
            TUexists[2] = existTU3;
            TUexists[3] = existTU4;
            TUexists[4] = existTU5;
            TUexists[5] = existTU6;
            #endregion

            bool damages = true;
            

            for (int i =0; i<6;i++)
            {

                double prob = TUexists[i]/TUprobs[i];
                DataGridViewComboBoxCell cbc = (DataGridViewComboBoxCell)(mf.dgvTGThreats.Rows[i].Cells[1]);
                string damage = cbc.Value==null ? "" : cbc.Value.ToString();
                if (damage != "")
                    damageGrades[i] = true;

                if (prob > 0 && prob < 0.5 && damage == "Высокая" )
                {
                    TechnogenicThreat tg = tgThreats.Find(t => t.Identificator.Contains((i+1).ToString()));
                    mf.dgvActualTGThreats.Rows.Add(tg.Identificator+" "+tg.Description);
                }
                if (prob == 0.5 && (damage == "Высокая"|| damage=="Средняя"))
                {
                    TechnogenicThreat tg = tgThreats.Find(t => t.Identificator.Contains((i + 1).ToString()));
                    mf.dgvActualTGThreats.Rows.Add(tg.Identificator + " " + tg.Description);
                }
                if (prob > 0.5 && damage != "")
                {
                    TechnogenicThreat tg = tgThreats.Find(t => t.Identificator.Contains((i + 1).ToString()));
                    mf.dgvActualTGThreats.Rows.Add(tg.Identificator + " " + tg.Description);
                }
            }
            foreach (bool b in damageGrades)
                if (!b)
                    damages = false;
            mf.lbTGInfo2.Visible = damages;
            mf.lbTGInfo.Visible = !damages;

            if (mf.dgvActualTGThreats.Rows.Count != 0)
            {
                int dgvtgm = 0;
                foreach (DataGridViewRow dgvr in mf.dgvActualTGThreats.Rows)
                {
                    dgvtgm += dgvr.Height;
                }
                mf.dgvActualTGThreats.Height = dgvtgm + mf.dgvTGMeasures.ColumnHeadersHeight;
            }
        }
    }
}
