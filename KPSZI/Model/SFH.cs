﻿using System;
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
        /// Внешний ключ на тип СФХ
        /// </summary>
        public int SFH_TypeID { get; set; }

        /// <summary>
        ///  Наименование СФХ
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Уровень проектной защищенности: 3 - высокий, 2 - средний, 1 - низкий.
        /// </summary>
        public int ProjectSecurity { get; set; }
    }
}
