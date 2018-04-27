using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPSZI.Model
{
    public class IntruderType
    {
        //Справочник видов нарушителей
        public int IntruderTypeId { get; set; }
        /// <summary>
        /// Вид нарушителя
        /// </summary>
        public string TypeName { get; set; }
        /// <summary>
        /// Коллекция всех угроз, для которых характерен данный вид нарушителя
        /// </summary>
        public virtual ICollection<Threat> Threats { get; set; }
    }
}