using System;
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
        public string ISName;
        /// <summary>
        /// Список видов информации, обрабатываемых в данной ИС
        /// </summary>
        public List<InfoType> listOfInfoTypes;
        /// <summary>
        /// Список СФХ, характерных для данной ИС
        /// </summary>
        public List<SFH> listOfSFHs;
        /// <summary>
        /// Список категорий ПДн, обрабатываемых в данной ИС
        /// </summary>
        public List<string> listOfCategoriesPDN;
        /// <summary>
        /// Список выбранных уязвимостей
        /// </summary>
        public List<Vulnerability> listOfVulnerabilities;
        /// <summary>
        /// АРМы в данной ИС
        /// </summary>
        public List<PC> listOfPCs;
        /// <summary>
        ///  Список способов реализации УБИ, характерных для данной ИС
        /// </summary>
        public List<ImplementWay> listOfImplementWays;
        /// <summary>
        ///  Список источников угроз, характерных для данной ИС
        /// </summary>
        public List<ThreatSource> listOfSources;
        /// <summary>
        /// Уровень проектной защищенности
        /// 0 - низкий, 1 - средний, 2 - высокий
        /// </summary>
        public int ProjectSecutiryLvl;

        public InformationSystem ()
        {
            ISName = "";
            listOfInfoTypes = new List<InfoType>();
            listOfSFHs = new List<SFH>();
            listOfCategoriesPDN = new List<string>();
            listOfVulnerabilities = new List<Vulnerability>();
            listOfPCs = new List<PC>();
            listOfImplementWays = new List<ImplementWay>();
            listOfSources = new List<ThreatSource>();
        }
    }

    /// <summary>
    /// Класс, хранящий информацию об АРМ-ах
    /// </summary>
    public class PC
    {
        /// <summary>
        /// Уникальный номер записи
        /// </summary>
        public string UID { get; set; }
        /// <summary>
        /// Учетный номер
        /// </summary>
        public string number { get; set; }
        /// <summary>
        /// Имя пользователя АРМ
        /// </summary>
        public string userName { get; set; }
        /// <summary>
        /// Наименование установленной ОС
        /// </summary>
        public string OSName { get; set; }
        /// <summary>
        /// Центральный процессор
        /// </summary>
        public string CPU { get; set; }
        /// <summary>
        /// Оперативная память
        /// </summary>
        public string RAM { get; set; }
        /// <summary>
        /// Материнская плата
        /// </summary>
        public string motherBoard { get; set; }
        /// <summary>
        /// Видеокарта
        /// </summary>
        public string videoCard { get; set; }
        /// <summary>
        /// Хранение данных
        /// </summary>
        public string HDD { get; set; }
        /// <summary>
        /// Оптический привод
        /// </summary>
        public string ODD { get; set; }
        /// <summary>
        /// Звуковая карта
        /// </summary>
        public string audioCard { get; set; }
        /// <summary>
        /// Группа, к которой относится данный АРМ 
        /// (0 - АРМ пользователя, 1 - АРМ сисадмина, 2 - АРМ, 3 - администратора БИ, 4 - Сервер)
        /// </summary>
        public int PCGroup { get; set; }

        public PC()
        {
            UID = Guid.NewGuid().ToString();
            
        }
    }
}
