using KPSZI.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KPSZI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //using (KPSZIContext db = new KPSZIContext())
            //{
            //    foreach (Threat thr in db.Threats)
            //    {
            //        Console.WriteLine("{0}:{1}:{2}:{3}", thr.ThreatId, thr.ThreatNumber, thr.Name, thr.Description);
            //    }
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo("thrlist.xlsx");
            Threat.GetThreatsFromXlsx(fi);
        }
    }
}
