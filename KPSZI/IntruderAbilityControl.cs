using KPSZI.Model;
using System.Windows.Forms;

namespace KPSZI
{
    public partial class IntruderAbilityControl : UserControl
    {
        public string thr;
        public string TCUI;
        public IntruderAbilityControl(string nameOfThreat, string TCUI, string TCUIType)
        {
            InitializeComponent();
            thr = nameOfThreat;
            lbNameOfThreat.Text = thr;
            this.TCUI = TCUI;
            lbTCUInTCUIType.Text = TCUIType + ", " + TCUI;
        }
    }
}
