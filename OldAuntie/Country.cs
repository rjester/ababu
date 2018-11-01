using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldAuntie
{
    class Country
    {
        public static DataTable GetAllCountries()
        {
            string query = "SELECT * FROM countries";
            DataTable result = Globals.DBCon.Execute(query);

            return result;
        }
    }
}
