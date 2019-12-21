using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGrow.Code
{
    /// <summary>
    /// 数值转换
    /// </summary>
    public class DataConvert
    {
        /// <summary>
        /// 空时间值转换
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public static DateTime? DateTimeConvert(string time)
        {
            if (string.IsNullOrEmpty(time))
            {
                return null;
            }
            return Convert.ToDateTime(time);
        }
    }
}
