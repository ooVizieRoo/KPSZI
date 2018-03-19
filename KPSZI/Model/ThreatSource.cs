using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPSZI.Model
{
    /// <summary>
    /// Класс-сущность для справочника 
    /// </summary>
    public class ThreatSource
    {
        /// <summary>
        /// Id для записи
        /// </summary>
        public int ThreatSourceId { get; set; }
        /// <summary>
        /// Внешняя ссылка на Id угрозы
        /// </summary>
        public int ThreatId { get; set; }
        /// <summary>
        /// Внутренний ли нарушитель? true - да, false - нет.
        /// </summary>
        public bool InternalIntruder { get; set; }
        /// <summary>
        /// Потенциал нарушителя. 0 - низкий, 1 - средний, 2 - высокий.
        /// </summary>
        public int Potencial { get; set; }

    }
}
