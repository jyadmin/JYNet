/*
 *  copyright (c) by potatoproject
 * 
 *  author : potato (nq.wangxiaobo@gmail.com)
 * 
 *  created date : 7/11/2009 5:05:55 PM
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DMS.Common
{
    public class DateTimeHelper
    {
        public static bool ISDateTimeNULL(DateTime datetime)
        {
            if (datetime.Year == 1)
            {
                return true;
            }

            if (datetime.Equals(DateTime.MinValue))
            {
                return true;
            }

            return false;
        }

        public static DateTime GetFirstDayDatetime(DateTime dt)
        {
            return new DateTime(dt.Year, dt.Month, dt.Day, 0, 0, 1);
        }

        public static DateTime GetLastDayDatetime(DateTime dt)
        {
            return new DateTime(dt.Year, dt.Month, dt.Day, 23, 59, 59);
        }

        public static long ConvertDataTimeToLong(DateTime dt)
        {
            DateTime dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            TimeSpan toNow = dt.Subtract(dtStart);
            long timeStamp = toNow.Ticks;
            timeStamp = long.Parse(timeStamp.ToString().Substring(0, timeStamp.ToString().Length - 4));
            return timeStamp;
        }

        public static DateTime ConvertLongToDateTime(long d)
        {
            DateTime dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            long lTime = long.Parse(d + "0000");
            TimeSpan toNow = new TimeSpan(lTime);
            DateTime dtResult = dtStart.Add(toNow);
            return dtResult;
        }  
    }
}
