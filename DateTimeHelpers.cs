using System;
using System.Collections.Generic;
using System.Text;

namespace wppSeventh.Util.Helpers
{
    /// <summary>
    /// Quick and easy utility for DateTime and Unix time.
    /// </summary>
    class DateTimeHelpers
    {

        /// <summary>
        /// Get current Unix time.
        /// </summary>
        /// <returns>
        /// Current Unix time in long.
        /// </returns>
        public static long GetCurrentUnixTime()
        {
            var unixTimestamp = (long)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds * 1000;

            return unixTimestamp;
        }

        /// <summary>
        /// Get Unix time of specified date time.
        /// </summary>
        /// <param name="timeStamp"></param>
        /// <returns>
        /// Unix time in long.
        /// </returns>
        public static long GetUnixTime(DateTime timeStamp)
        {
            var unixTimestamp = (long)(timeStamp.Subtract(new DateTime(1970, 1, 1))).TotalSeconds * 1000;

            return unixTimestamp;
        }

        /// <summary>
        /// Get DateTime object from Unix time.
        /// </summary>
        /// <param name="unixTimeStamp"></param>
        /// <returns>
        /// DateTime object.
        /// </returns>
        public static DateTime GetDateTimeFromUnixTime(long unixTimeStamp)
        {
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;

        }
    }
}
