using OldAuntie;
using System;
using System.Data;

namespace OldAuntie
{
    public static class Globals
    {
        public static bool isUserLogged = false;
        public static User Me = null;
        public static BaseDati DBCon = new BaseDati();
        public static Log Log = Log.Instance;



        public const string FEED_URL_NEWS = "http://www.oldauntie.org/category/ababu-free-veterinary-software/feed/";
        public const string FEED_URL_GET_STARTED = "http://www.oldauntie.org/category/get-started/feed/";

        static Globals()
        {
        }
    }
}
