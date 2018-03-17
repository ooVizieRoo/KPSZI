using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPSZI.Model
{
    public class Threat
    {
        //Класс-сущность для угрозы
        public int ThreatId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ThreatSource { get; set; }
    }
}
