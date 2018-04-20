using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KPSZI.Model
{

    /// <summary>
    ///  Класс самих СФ характеристик (Локальная, Распределенная, грид-системы, гетерогенная среда, etc.)
    /// </summary>
    public class SFH
    {
        /// <summary>
        /// Первичный ключ - Id СФХ
        /// </summary>
        public int SFHId { get; set; }

        /// <summary>
        /// Номер СФХ
        /// </summary>
        public int SFHNumber { get; set; }
        
        /// <summary>
        /// Навигационное поле - внешний ключ на тип СФХ
        /// </summary>
        public virtual SFHType SFHType { get; set; }

        /// <summary>
        ///  Наименование СФХ
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Уровень проектной защищенности: 2 - высокий, 1 - средний, 0 - низкий.
        /// </summary>
        public int ProjectSecurity { get; set; }

        public virtual ICollection<Threat> Threats { get; set; }

        public SFH()
        {
            Threats = new List<Threat>();
        }
    }
}
