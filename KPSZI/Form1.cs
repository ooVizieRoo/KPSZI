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
                //FileInfo fi = new FileInfo("thrlist.xlsx");

                //db.Threats.AddRange(Threat.GetThreatsFromXlsx(fi, db));
                //db.SaveChanges();

                KPSZIContext.Seed(db);

                var hui = db.SFHTypes.ToList();
                foreach (SFHType st in hui)
                {
                    Console.Write("\n{0}:{1}", st.SFHTypeId, st.Name);
                    foreach (SFH s in st.SFHs)
                    {
                        Console.Write("\n\t{0}:{1}:{2}", s.SFHId, s.Name, s.ProjectSecurity);
                    }
                }
            }
        }
    }
}
