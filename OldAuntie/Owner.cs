using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldAuntie
{
    public class Owner
    {
        public static DataTable List()
        {
            DataTable result = Globals.DBCon.Execute("SELECT oid, CONCAT(firstname, ' ', lastname) as owner FROM owners");
            return result;
        }
    }
}
