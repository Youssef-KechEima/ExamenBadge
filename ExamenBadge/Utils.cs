using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenBadge
{
    class Utils
    {
        /* to use this function write this in your code nihahahaha 
         * string years = Utils.getYears();
         * string semeaine = Utils.getDaysOfWeek();
         * */

        public static string getDaysOfWeek()
        {
            DateTime date = DateTime.Today;

            while (date.DayOfWeek != DayOfWeek.Monday)
            {
                date = date.AddDays(-1);
            }
            return "Semaine du ..."+date.ToString("d")+"...au.."+date.AddDays(5).ToString("d");
        }
        public static string getYears()
        {
            DateTime date = DateTime.Today;
            return date.ToString("yyyy") + "-" + date.AddYears(1).ToString("yyyy");
        }
    }
}
