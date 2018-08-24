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
        public static Log log = new Log();


        public static DataTable problems;
        public static DataTable medicines;

        static Globals()
        {
        }
    }
}
