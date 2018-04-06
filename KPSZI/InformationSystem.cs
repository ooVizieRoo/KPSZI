﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KPSZI.Model;

namespace KPSZI
{
    /// <summary>
    /// Класс, хранящий информацию об ИС
    /// </summary>
    public class InformationSystem
    {
        /// <summary>
        /// Наименование информационной системы
        /// </summary>
        string ISName;
        /// <summary>
        /// Список видов информации, обрабатываемых в данной ИС
        /// </summary>
        List<InfoType> listOfInfoTypes;
        /// <summary>
        /// Список СФХ, характерных для данной ИС
        /// </summary>
        List<SFH> listOfSFHs;

        public InformationSystem ()
        {
            ISName = "";
            listOfInfoTypes = new List<InfoType>();
            listOfSFHs = new List<SFH>();
        }
    }
}
