using OldAuntie;
using System;




namespace OldAuntie
{
    public static class Globals
    {
        public static bool isUserLogged = false;
        public static User Me = null;
        public static BaseDati DBCon = new BaseDati();
        public static Log log = new Log();
        

        static Globals()
        {
        }
    }
}
