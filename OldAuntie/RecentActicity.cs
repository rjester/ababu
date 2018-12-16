using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldAuntie
{
    public class RecentActicity
    {
        public RecentActicity()
        {

        }


        public static DataTable GetRecentVisits(string search = "")
        {
            string query = "SELECT a.id, a.owner_id, a.name, a.gender, b.created, b.updated" +
                " FROM pets a, problems b " +
                " WHERE 1 = 1 " +
                " AND b.pet_id = a.id";

            if (search != "")
            {
                // query += " WHERE (LOWER(a.name) LIKE '%" + search.ToLower() + "%' OR LOWER(lastname) LIKE '%" + search.ToLower() + "%' OR LOWER(email) LIKE '%" + search.ToLower() + "%') ";
            }
            query += " ORDER BY b.updated DESC, b.created DESC" +
                " LIMIT 0, 5";

            DataTable result = Globals.DBCon.Execute(query);
            return result;
        }
    }


}
