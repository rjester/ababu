using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldAuntie
{
    public class Species
    {


        public static DataTable List()
        {
            DataTable result = Globals.DBCon.Execute("SELECT tsn, familiar_name FROM species");
            return result;
        }
    }

    
}
