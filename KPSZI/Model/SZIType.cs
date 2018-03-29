using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPSZI.Model
{
    /// <summary>
    /// Типы СЗИ - СОВ, СДЗ, etc.
    /// </summary>
    public class SZIType
    {
        /// <summary>
        /// Первичный ключ
        /// </summary>
        public int SZITypeId { get; set; }
        
        /// <summary>
        /// Название типа СЗИ
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Список средств СЗИ данного типа
        /// </summary>
        public virtual ICollection<SZI> SZIs { get; set; }

        /// <summary>
        /// Конструктор для создания списка
        /// </summary>
        public SZIType()
        {
            this.SZIs = new List<SZI>();
        }
    }
}
