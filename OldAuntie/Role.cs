using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldAuntie
{
    public class Role
    {
        private Int64 Id  { get; set; }
        private string Name { get; set; }
        private string Description { get; set; }


        public static DataTable GetAllRoles()
        {
            DataTable result = Globals.DBCon.Execute("SELECT id, name FROM roles");
            return result;
        }
    }
}
