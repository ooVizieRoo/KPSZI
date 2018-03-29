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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (KPSZIContext db = new KPSZIContext())
            {
                FileInfo fi = new FileInfo("thrlist.xlsx");
                
                db.Threats.AddRange(Threat.GetThreatsFromXlsx(fi, db));
                db.SaveChanges();
            }
        }
    }
}
