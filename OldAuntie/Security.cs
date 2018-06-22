using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldAuntie
{
    public class Security
    {
        public const int ROLE_ADMIN    = 1;
        public const int ROLE_USER     = 2;
        public const int ROLE_VIEWER   = 3;


        public static bool CheckByUid(int required_access_rid, int uid)
        {
            bool result = false;

            string query = "SELECT uid FROM users WHERE rid <= " + required_access_rid + " AND uid = " + uid;
            
            long rv_uid = Globals.DBCon.SelectOneValue(query);

            if(rv_uid > 0)
            {
                result = true;
            }

            return result;
        }
    }
}
