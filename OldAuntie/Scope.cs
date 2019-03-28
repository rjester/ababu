using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldAuntie
{
    public class Scope
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public const int SCOPE_PRESCRIPTION = 1;
        public const int SCOPE_EXAMINATION = 2;
        public const int SCOPE_TREATMENT = 3;


        public Scope(int id = 0)
        {
            if(id > 0)
            {
                Load(id);
            }
        }


        public Scope Load(int id)
        {
            DataRow result = Globals.DBCon.SelectOneRow("SELECT * FROM scopes WHERE id = " + id.ToString());

            if (result.ItemArray.Count() > 0)
            {
                Id = (int)result["id"];
                Name = result["name"].ToString();
            }

            return this;
        }


        public static DataTable GetAllScopes()
        {
            /*
            DataTable result = null;
            result = Globals.DBCon.Execute("SELECT * FROM scopes");
            return result;
            */
            return Globals.DBCon.EntityLoad("scopes");
        }
    }
}
