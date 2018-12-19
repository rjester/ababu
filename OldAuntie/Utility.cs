using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OldAuntie
{
    public class Utility
    {
        // @todo: delete both ?
        // public const string DATETIME_DEFAULT_FORMAT = "yyyyMMddHHmmss";
        // public const string DATETIME_DEFAULT_FORMAT = "yyyy-MM-dd HH:mm:ss";

        public static string MD5(string input)
        {
            // step 1, calculate MD5 hash from input
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }

            return sb.ToString();
        }



        public static bool PingHost(string nameOrAddress, int timeout = 1000)
        {
            bool pingable = false;
            Ping pinger = new Ping();
            try
            {
                PingReply reply = pinger.Send(nameOrAddress, timeout);
                pingable = reply.Status == IPStatus.Success;
            }
            catch (PingException)
            {
                // Discard PingExceptions and return false;
                pingable = false;
            }
            return pingable;
        }



        public static void d(dynamic what)
        {
            Console.WriteLine(what.ToString());
        }

        // DATE AND TIME
        // @todo: change database structure to date time
        public static long Now()
        {
            long unixTimestamp = (long)(DateTime.Now.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            return unixTimestamp;
        }

        public static DateTime UnixTimeStampToDateTime(long UnixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            return epoch.AddSeconds(UnixTimeStamp).ToLocalTime();
        }


        public static long DateTimeToUnixTimestamp(DateTime Date)
        {
            DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, Date.Kind);
            return System.Convert.ToInt64((Date - epoch).TotalSeconds);
        }

        
        // @todo: delete me ?
        /*
        public static string DateTimeToString(DateTime? Date, String Format = DATETIME_DEFAULT_FORMAT)
        {
            return Date.ToString(Format);
        }
        */




        // DATA CONVERSION
        public static dynamic IfNullOrEmpty(dynamic what, dynamic return_value = null)
        {
            if (String.IsNullOrEmpty(what))
            {
                return return_value;
            }
            else
            {
                return what;
            }
        }

        public static dynamic IfNull(dynamic what, dynamic return_value = null)
        {
            if (what == null)
            {
                return return_value;
            }
            else
            {
                return what;
            }
        }


        public static dynamic IfMinValue(DateTime date_time, dynamic return_value = null)
        {
            if (date_time == DateTime.MinValue)
            {
                return return_value;
            }
            else
            {
                return date_time;
            }
        }




        public static dynamic IfDBNull(dynamic what, dynamic return_value = null)
        {
            if (Convert.IsDBNull(what))
            {
                return return_value;
            }
            else
            {
                return what;
            }

        }
    }
}
