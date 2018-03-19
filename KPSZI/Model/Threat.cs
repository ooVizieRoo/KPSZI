using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPSZI.Model
{
    /// <summary>
    /// Класс-сущность угроза
    /// </summary>
    public class Threat
    {
        /// <summary>
        /// ID угрозы
        /// </summary>
        public int ThreatId { get; set; }
        /// <summary>
        /// Наименование УБИ
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Описание УБИ
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Объект воздействия
        /// </summary>
        public string ObjectOfInfluence { get; set; }
        /// <summary>
        /// Нарушение конфиденциальности
        /// </summary>
        public bool ConfidenceViolation { get; set; }
        /// <summary>
        /// Нарушение целостности
        /// </summary>
        public bool IntegrityViolation { get; set; }
        /// <summary>
        /// Нарушение доступности
        /// </summary>
        public bool AvailabilityViolation { get; set; }
        /// <summary>
        /// Дата добавления угрозы в БДУ
        /// </summary>
        public DateTime DateOfAdd { get; set; }
        /// <summary>
        /// Последняя дата изменения угрозы
        /// </summary>
        public DateTime DateOfChange { get; set; }
    }
}
