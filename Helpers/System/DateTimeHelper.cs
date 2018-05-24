using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BitAdminCoreDemo.Helpers
{
    public static class DateTimeHelper
    {
        public static string WeekName(this DateTime datetime)
        {
            string[] Day = new string[] { "星期日", "星期一", "星期二", "星期三", "星期四", "星期五", "星期六" };
            return Day[(int)datetime.DayOfWeek];
        }
    }
}
