using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPSZI.Model
{
    /// <summary>
    /// Класс справочник типов структурно-функциональных характеристик (По архитектуре, по подкл. и другим сетям, etc.)
    /// </summary>
    public class SFHType
    {
        /// <summary>
        /// Первичный ключ - Id типа СФХ
        /// </summary>
        public int SFHTypeId { get; set; }
        /// <summary>
        /// Наименование типа СФХ
        /// </summary>
        public string Name { get; set; }
    }
}
