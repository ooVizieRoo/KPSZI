using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPSZI.Model
{
    /// <summary>
    /// Справочная таблица (класс) для определения возможности реализации угрозы
    /// </summary>
    public class RealizationPossibility
    {
        /// <summary>
        /// 0 - Нет потенциала нарушителя, 1 - Низкий, 2 - Средний, 3 - Высокий
        /// </summary>
        public int IntruderPotencial { get; set; }

        /// <summary>
        /// Определение вероятности реализации угрозы при заданном высоком уровне проектной защищенности
        /// </summary>
        public int HighPD { get; set; }

        /// <summary>
        /// Определение вероятности реализации угрозы при заданном среднем уровне проектной защищенности
        /// </summary>
        public int MediumPD { get; set; }

        /// <summary>
        /// Определение вероятности реализации угрозы при заданном низком уровне проектной защищенности
        /// </summary>
        public int LowPD { get; set; }
    }
}
