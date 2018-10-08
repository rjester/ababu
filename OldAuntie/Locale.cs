using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldAuntie
{
    public class Locale
    {
        private string Code { get; set; }
        private string Country { get; set; }
        public static DataTable GetAllLocales()
        {
            DataTable result = Globals.DBCon.Execute("SELECT id, language FROM locales");
            return result;
        }
    }
}
