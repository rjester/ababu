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
        public static Log Log = new Log();

        // public const string FEED_URL = "http://www.oldauntie.org/feed";
        public const string FEED_URL = "http://www.oldauntie.org/category/ababu-free-veterinary-software/feed/";

        static Globals()
        {
        }
    }
}
