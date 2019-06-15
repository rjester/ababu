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

        public const string APP_NAME = "Ababu (beta)";

        public const string FEED_URL_NEWS = "http://www.oldauntie.org/category/ababu-free-veterinary-software/feed/";
        public const string FEED_URL_GET_STARTED = "http://www.oldauntie.org/category/get-started/feed/";

        public const string VERSION_CHECK_URL = "http://www.oldauntie.org/ababu_latest_version.json";
        public const string VERSION_NUMBER = "0.3.3";
        public const string VERSION_BUILD = "007";

        static Globals()
        {
        }
    }
}
