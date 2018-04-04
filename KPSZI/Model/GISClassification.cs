using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPSZI.Model
{
    /// <summary>
    /// Маленькая справочная таблица для определения класса защищенности ГИС/МИС
    /// </summary>
    public class GISClassification
    {
        /// <summary>
        /// Уровень значимости информации: 0 - низкий, 1 - средний, 2 - высокий
        /// </summary>
        public int InfoSignificanceLevel { get; set; }

        /// <summary>
        /// Класс защищенности для федерального масштаба
        /// </summary>
        public int FederalScaleClass { get; set; }

        /// <summary>
        /// Класс защищенности для регионального масштаба 
        /// </summary>
        public int RegionScaleClass { get; set; }

        /// <summary>
        /// Класс защищенности для объектового масштаба
        /// </summary>
        public int ObjectScaleClass { get; set; }
    }
}
