using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveKicher.ElectricRail.Core.Utility
{

    /// <summary>
    /// 表示一个Unix时间戳
    /// </summary>
    public struct TimeStamp
    {
        /// <summary>
        /// 此<see cref="TimeStamp"/>的值
        /// </summary>
        public long Value { get; set; }


        private static readonly DateTime startTimeUTC = 
            new DateTime(1970, 1, 1);

        /// <summary>
        /// 表示值为0的<see cref="TimeStamp"/>
        /// </summary>
        public static TimeStamp Zero => new TimeStamp(0);

        public TimeStamp(long value)
        {
            Value = value;
        }

        /// <summary>
        /// 从一个<see cref="DateTime"/>对象创建<see cref="TimeStamp"/> 
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static TimeStamp FromDateTime(DateTime d)
        {
            long ts = (long)(d - TimeZoneInfo.ConvertTimeFromUtc(startTimeUTC, TimeZoneInfo.Local))
                 .TotalSeconds;
            return new TimeStamp(ts);
        }

        public static TimeStamp FromDateTimeUTC(DateTime d)
        {
            long ts = (long)(d - startTimeUTC).TotalSeconds;
            return new TimeStamp(ts);
        }

        /// <summary>
        /// 将<see cref="TimeStamp"/>转换为当前时区的<see cref="DateTime"/> 
        /// </summary>
        /// <returns></returns>
        public DateTime ToLocalTime() => 
            TimeZoneInfo.ConvertTimeFromUtc(startTimeUTC, TimeZoneInfo.Local)
                .AddSeconds(Value);

        public DateTime ToDateTime() => startTimeUTC.AddSeconds(Value);

         

    }
}
