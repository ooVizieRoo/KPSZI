using KPSZI.Model;
using System;
using System.Windows.Forms;

namespace KPSZI
{
    public partial class IntruderAbilityControl : UserControl
    {
        public string threatName;
        public string TCUI;
        public int threatValue;
        public bool Checked;

        bool timeChecked;
        bool accessChecked;
        bool projectChecked;
        bool competChecked;
        bool osnastChecked;
        int timeValue;
        int accessValue;
        int competValue;
        int projectValue;
        int osnastValue;

        public IntruderAbilityControl(string nameOfThreat, string TCUI, string TCUIType)
        {
            InitializeComponent();

            timeChecked= false;
            accessChecked= false;
            projectChecked= false;
            competChecked= false;
            osnastChecked= false;

            threatName = nameOfThreat;
            lbNameOfThreat.Text = threatName;
            this.TCUI = TCUI;
            lbTCUInTCUIType.Text = TCUIType + ", " + TCUI;
        }

        public void selectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            #region Большоо-о-о-ой свич
            switch (cb.Name)
            {
                case "cbTime":
                    {
                        switch (cb.SelectedIndex)
                        {
                            case 0:
                                {
                                    timeValue = 0;
                                    break;
                                }
                            case 1:
                                {
                                    timeValue = 5;
                                    break;
                                }
                            case 2:
                                {
                                    timeValue = 8;
                                    break;
                                }
                            case 3:
                                {
                                    timeValue = 13;
                                    break;
                                }
                        }
                        timeChecked = true;
                        break;
                    }
                case "cbCompet":
                    {
                        switch (cb.SelectedIndex)
                        {
                            case 0:
                                {
                                    competValue = 0;
                                    break;
                                }
                            case 1:
                                {
                                    competValue = 5;
                                    break;
                                }
                            case 2:
                                {
                                    competValue = 9;
                                    break;
                                }
                        }
                        competChecked = true;
                        break;
                    }
                case "cbProject":
                    {
                        switch (cb.SelectedIndex)
                        {
                            case 0:
                                {
                                    projectValue = 0;
                                    break;
                                }
                            case 1:
                                {
                                    projectValue = 4;
                                    break;
                                }
                            case 2:
                                {
                                    projectValue = 9;
                                    break;
                                }
                        }
                        projectChecked = true;
                        break;
                    }
                case "cbAccess":
                    {
                        switch (cb.SelectedIndex)
                        {
                            case 0:
                                {
                                    accessValue = 0;
                                    break;
                                }
                            case 1:
                                {
                                    accessValue = 6;
                                    break;
                                }
                            case 2:
                                {
                                    accessValue = 9;
                                    break;
                                }
                            case 3:
                                {
                                    accessValue = 13;
                                    break;
                                }
                        }
                        accessChecked = true;
                        break;
                    }
                case "cbOsnast":
                    {
                        switch (cb.SelectedIndex)
                        {
                            case 0:
                                {
                                    osnastValue = 0;
                                    break;
                                }
                            case 1:
                                {
                                    osnastValue = 3;
                                    break;
                                }
                            case 2:
                                {
                                    osnastValue = 7;
                                    break;
                                }
                            case 3:
                                {
                                    osnastValue = 11;
                                    break;
                                }
                        }
                        osnastChecked = true;
                        break;
                    }
            }
            #endregion
            Checked = osnastChecked && timeChecked && accessChecked && projectChecked && competChecked;
            threatValue = accessValue + competValue + projectValue + timeValue + osnastValue;
        }
    }
}
