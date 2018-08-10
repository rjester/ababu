using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OldAuntie
{
    public class Utility
    {
        public const string DATETIME_DEFAULT_FORMAT = "yyyyMMddHHmmss";

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
        

        public static void d(dynamic what)
        {
            Console.WriteLine(what.ToString());
        }

        // DATE AND TIME
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
