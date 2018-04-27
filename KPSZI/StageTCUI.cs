using System.Windows.Forms;
using KPSZI.Model;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Data;

namespace KPSZI
{
    public enum intruderPotencial { Низкий = 0, Средний = 1, Высокий = 2, Невозможен = 3};

    class StageTCUI : Stage
    {
        public List<TCUI> listOfTCUIs;
        public List<IntruderAbilityControl> controlsIAC;
        public List<TCUIThreat> listOfTCUIThreats;

        public StageTCUI(TabPage stageTab, TreeNode stageNode, MainForm mainForm, InformationSystem IS)
            : base(stageTab, stageNode, mainForm, IS)
        {

        }

        public override void enterTabPage()
        {
            
        }

        public override void saveChanges()
        {

        }

        public override void initTabPage()
        {
            listOfTCUIs = new List<TCUI>();
            controlsIAC = new List<IntruderAbilityControl>();
            listOfTCUIThreats = new List<TCUIThreat>();

            foreach (Control cb in mf.tabControlTCUI.TabPages["tabPageTCUIExist"].Controls)
            {
                if(cb as CheckBox != null)
                    ((CheckBox)cb).Click += new EventHandler(cbClick);
            }
            mf.tabControlTCUI.TabPages["tabPageIntrAbil"].Enter += new System.EventHandler(enterAtPageAbilsOfIntruder);
            mf.tabControlTCUI.TabPages["tabPageListOfTCUIThreats"].Enter += new System.EventHandler(enterTabPageThreatsList);
            mf.tabControlTCUI.TabPages["tabPageIntrAbil"].AutoScroll = true;
        }

        public void cbClick(object sender, EventArgs e)
        {
            string nameOfChannel = ((CheckBox)sender).Text;
            if (((CheckBox)sender).CheckState == CheckState.Checked)
            {
                using (KPSZIContext db = new KPSZIContext())
                {
                    string tcuitype = getTypeOfTCUI(((CheckBox)sender).Name);
                    TCUI tc = db.TCUIs.ToList().First(t => t.Name == nameOfChannel && t.TCUIType.Name == tcuitype);
                    tc.TCUIThreats = new List<TCUIThreat>(tc.TCUIThreats);
                    listOfTCUIs.Add(tc);
                    updateListOfControls(true, tc);
                }
            }
            if (((CheckBox)sender).CheckState == CheckState.Unchecked)
            {
                int index = listOfTCUIs.FindLastIndex(t => t.Name == nameOfChannel);
                updateListOfControls(false, listOfTCUIs[index]);
                listOfTCUIs.RemoveAt(index);
            }
        }

        public void enterAtPageAbilsOfIntruder(object sender, EventArgs e)
        { 
            mf.tabControlTCUI.TabPages["tabPageIntrAbil"].Controls.Clear();
            if (controlsIAC.Count == 0)
                mf.tabControlTCUI.TabPages["tabPageIntrAbil"].Controls.Add(mf.lbAvilitiesInfo);
            for (int i = 0; i < controlsIAC.Count; i++)
            {
                controlsIAC[i].Location = new System.Drawing.Point { X = 15, Y = (i * (controlsIAC[i].Height+15)) + 15 };
                mf.tabControlTCUI.TabPages["tabPageIntrAbil"].Controls.Add(controlsIAC[i]);
            }
        }

        public void updateListOfControls(bool adding, TCUI cui)
        {
            if (adding)
                foreach (TCUIThreat tct in cui.TCUIThreats)
                {
                    IntruderAbilityControl iac = new IntruderAbilityControl(tct.Name,cui.Name,cui.TCUIType.Name,mf);
                    if (controlsIAC.Find(t => t.threatName == tct.Name) == null)
                    {
                        listOfTCUIThreats.Add(tct);
                        controlsIAC.Add(iac);
                    }
                }
            else
            {
                foreach (TCUIThreat tct in cui.TCUIThreats)
                {
                    int index = controlsIAC.FindIndex(t => t.threatName == tct.Name && t.TCUI == cui.Name);
                    controlsIAC.RemoveAt(index);
                    listOfTCUIThreats.RemoveAt(index);
                }
            }
        }

        public string getTypeOfTCUI(string TCUI)
        {
            if (TCUI.Contains("Voice"))
                return "Каналы утечки акустической (речевой) информации";
            if (TCUI.Contains("Pereh"))
                return "Каналы перехвата информации при ее передаче по каналам связи";
            if(TCUI.Contains("PEMIN"))
                return "Каналы побочных электромагнитных излучений и наводок (ПЭМИН)";
            return "Каналы утечки видовой информации";
        }

        public void enterTabPageThreatsList (object sender, EventArgs e)
        {
            //вместо ts нужен определенный потенциал нарушителя
            ThreatSource ts = new ThreatSource { Potencial = 0 };


            var source = new BindingSource();
            List<TCUIThreat> actualTCUIThreats = new List<TCUIThreat>();
            foreach(IntruderAbilityControl iac in controlsIAC)
            {
                iac.updateIac();
                int intrPot = (int)iac.intrud;
                if ((iac.threatValue > 10 && iac.Checked) && iac.abilityOfRealization != "" && iac.damage != "")
                {
                    if (iac.damage == "Высокая" && intrPot <= ts.Potencial)
                        actualTCUIThreats.Add(listOfTCUIThreats.Find(t => t.Name == iac.threatName));

                    if (iac.damage == "Средняя" && (iac.abilityOfRealization == "Средняя" || iac.abilityOfRealization == "Высокая") && intrPot <= ts.Potencial)
                        actualTCUIThreats.Add(listOfTCUIThreats.Find(t => t.Name == iac.threatName));

                    if (iac.damage == "Низкая" && iac.abilityOfRealization == "Высокая" && intrPot <= ts.Potencial)
                        actualTCUIThreats.Add(listOfTCUIThreats.Find(t => t.Name == iac.threatName));
                }
            }
            source.DataSource = actualTCUIThreats;
            mf.dgvActualTCUIThreats.DataSource = source;
            bool fullList = true;
            foreach(IntruderAbilityControl iac in controlsIAC)
            {
                if (!iac.Checked)
                    fullList = false;
            }
            if (fullList)
                if (mf.dgvActualTCUIThreats.Rows.Count == 0)
                    mf.lbTCUIInfo.Text = "Угрозы утечки информации по техническим каналам не актуальны для информационной системы.";
                else
                    mf.lbTCUIInfo.Text = "Угрозы утечки информации по техническим каналам в списке являются актуальными для информационной системы.";
            else
                mf.lbTCUIInfo.Text = "Для определения списка актуальных угроз утечки по техническим каналам, выберите все поля на предыдущих вкладках.";


            mf.dgvActualTCUIThreats.Columns[0].Visible = false;
            mf.dgvActualTCUIThreats.Columns[1].Visible = false;
            mf.dgvActualTCUIThreats.Columns[2].HeaderText = "Идентификатор угрозы";
            mf.dgvActualTCUIThreats.Columns[2].Width = 100;
            mf.dgvActualTCUIThreats.Columns[3].HeaderText = "Название угрозы";
            mf.dgvActualTCUIThreats.Columns[3].Width = 200;
            mf.dgvActualTCUIThreats.Columns[4].HeaderText = "Описание угрозы";
            mf.dgvActualTCUIThreats.Columns[4].Width = 300;
            mf.dgvActualTCUIThreats.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            mf.tabControlTCUI.TabPages[2].AutoScroll = true;
            mf.tabControlTCUI.TabPages[2].AutoScrollMargin = new System.Drawing.Size(3, 15);
            if (mf.dgvActualTCUIThreats.Rows.Count != 0)
            {
                int dgvtcui = 0;
                foreach (DataGridViewRow dgvr in mf.dgvActualTCUIThreats.Rows)
                {
                    dgvtcui += dgvr.Height;
                }
                mf.dgvActualTCUIThreats.Height = dgvtcui + mf.dgvActualTCUIThreats.ColumnHeadersHeight;
            }
        }
    }
}
