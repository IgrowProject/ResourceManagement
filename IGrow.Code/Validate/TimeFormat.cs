using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGrow.Code
{
    public static  class TimeFormat
    {
        /// <summary>
        /// 转换开始时间，默认加 “00:00:01"
        /// </summary>
        /// <param name="str">yyyy hh dd</param>
        /// <returns></returns>
        public static DateTime StarTime(string str)
        {
            return DateTime.Parse(str+" " + "00:00:01");
        }

        /// <summary>
        /// 转换开始时间，默认加 “23:59:59"
        /// </summary>
        /// <param name="str">yyyy hh dd</param>
        /// <returns></returns>
        public static DateTime EndTime(string str)
        {
            return DateTime.Parse(str + " " + "23:59:59");
        }
    }
}
