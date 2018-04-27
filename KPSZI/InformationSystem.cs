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
        ///  Список уязвимостей, характерных для данной ИС
        /// </summary>
        public List<Vulnerability> listOfVulnerabilities;
        /// <summary>
        ///  Список способов реализации УБИ, характерных для данной ИС
        /// </summary>
        public List<ImplementWay> listOfImplementWays;
        /// <summary>
        ///  Список источников угроз, характерных для данной ИС
        /// </summary>
        public List<ThreatSource> listOfSources;
        
        public List<string> listOfCategoriesPDN;        

        public InformationSystem ()
        {
            ISName = "";
            listOfInfoTypes = new List<InfoType>();
            listOfSFHs = new List<SFH>();
            listOfCategoriesPDN = new List<string>();
            listOfVulnerabilities = new List<Vulnerability>();
            listOfImplementWays = new List<ImplementWay>();
            listOfSources = new List<ThreatSource>();
        }
    }
}
