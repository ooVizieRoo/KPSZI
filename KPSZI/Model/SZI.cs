using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPSZI.Model
{
    /// <summary>
    /// Средства защиты информации
    /// </summary>
    public class SZI
    {
        /// <summary>
        /// Первичный ключ
        /// </summary>
        /// 
        public int SZIId { get; set; }

        /// <summary>
        /// Класс защиты, который обеспечивает данное СЗИ
        /// </summary>
        public string DefenceClass { get; set; }
        
        /// <summary>
        /// Системные требования к частоте ЦПУ 
        /// </summary>
        public int CPUFrequencyRequirements { get; set; }

        /// <summary>
        /// Системные требования к количеству ядер ЦПУ
        /// </summary>
        public int CPUCoresRequirements { get; set; }

        /// <summary>
        /// Системные требования к оперативной памяти
        /// </summary>
        public int MemoryRequirements { get; set; }

        /// <summary>
        /// Системные требования к свободному месту на диске
        /// </summary>
        public int DiscSpaceRequirements { get; set; }

        /// <summary>
        /// Навигационное поле - внешний ключ на тип СЗИ
        /// </summary>
        public virtual SZIType SZIType { get; set; }

        /// <summary>
        /// Список мер ЗИ в ГИС, реализуемых данным СЗИ - навигационное поле
        /// </summary>
        public virtual ICollection<GISMeasure> GISMeasures { get; set; }

        /// <summary>
        /// Список мер ЗИ в ИСПДН, реализуемых данным СЗИ - навигационное поле
        /// </summary>
        public virtual ICollection<ISPDNMeasure> ISPDNMeasures { get; set; }

        public SZI()
        {
            this.GISMeasures = new List<GISMeasures>();
            this.ISPDNMeasures = new List<ISPDNMeasures>();
        }
    }
}
