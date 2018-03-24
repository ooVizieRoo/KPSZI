using KPSZI.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            using (KPSZIContext db = new KPSZIContext())
            {
                //Threat thr1 = new Threat();
                //thr1.ThreatNumber = 1;
                //thr1.Name = "Threat1";
                //thr1.Description = "Description1";
                //thr1.AvailabilityViolation = false;
                //thr1.IntegrityViolation = false;
                //thr1.ConfidenceViolation = true;
                //thr1.DateOfAdd = DateTime.Today;
                //thr1.DateOfChange = DateTime.Now;
                //thr1.ObjectOfInfluence = "PC";

                //db.Threats.Add(thr1);
                //db.SaveChanges();

                foreach (Threat thr in db.Threats)
                {
                    Console.WriteLine("{0}:{1}:{2}:{3}", thr.ThreatId, thr.ThreatNumber, thr.Name, thr.Description);
                }
            }
        }

    }
}
