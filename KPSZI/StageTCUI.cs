using System.Windows.Forms;
using KPSZI.Model;
using System.Collections.Generic;
using System;
using System.Linq;

namespace KPSZI
{
    class StageTCUI : Stage
    {
        public List<TCUI> listOfTCUIs;
        public List<IntruderAbilityControl> controlsIAC;
        
        public StageTCUI(TabPage stageTab, TreeNode stageNode, MainForm mainForm, InformationSystem IS)
            : base(stageTab, stageNode, mainForm, IS)
        {
            initTabPage();
        }

        public override void enterTabPage()
        {
            
        }

        public override void saveChanges()
        {

        }

        protected override void initTabPage()
        {
            listOfTCUIs = new List<TCUI>();
            controlsIAC = new List<IntruderAbilityControl>();
            
            foreach (Control cb in mf.tabControlTCUI.TabPages["tabPageTCUIExist"].Controls)
            {
                if(cb as CheckBox != null)
                    ((CheckBox)cb).CheckedChanged += new EventHandler(cbClick);
            }
            mf.tabControlTCUI.TabPages["tabPageIntrAbil"].Enter += new System.EventHandler(enterAtPageAbilsOfIntruder);
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
                    IntruderAbilityControl iac = new IntruderAbilityControl(tct.Name,cui.Name,cui.TCUIType.Name);
                    if (controlsIAC.Find(t => t.thr == tct.Name) == null)
                    {
                        controlsIAC.Add(iac);
                    }
                }
            else
            {
                foreach (TCUIThreat tct in cui.TCUIThreats)
                {
                    int index = controlsIAC.FindIndex(t => t.thr == tct.Name && t.TCUI == cui.Name);
                    controlsIAC.RemoveAt(index);
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
    }
}
