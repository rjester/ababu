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
        private Int64 Rid  { get; set; }
        private string Name { get; set; }
        private string Description { get; set; }
        public static DataTable GetAllRoles()
        {
            DataTable result = Globals.DBCon.Execute("SELECT rid, name FROM roles");
            return result;
        }
    }
}
