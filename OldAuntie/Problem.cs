using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldAuntie
{
    public class Problem
    {
        public int Id { get; set; }
        public int Pid { get; set; }

        private bool disposed = false;


        public Problem(int id = 0)
        {
            if (id > 0)
            {
                Load(id);
            }
        }


        public Problem Load(int id)
        {
            if (id > 0)
            {
                string query = "SELECT * FROM problems a, visit_status b " +
                    "WHERE a.status_id = b.status_id " +
                    "AND a.id = " + id.ToString();
                DataRow result = Globals.DBCon.SelectOneRow(query);

                if (result != null && result.ItemArray.Count() > 0)
                {
                    Id = id;
                    Pid = (int)result["pid"];
                    
                }
            }

            return this;
        }


        static public DataTable Search(string what = "", bool IncludeDeleted = false)
        {
            string query = "SELECT a.pid as pid, a.name, b.familiar_name as species, a.microchip, a.description, a.color, a.deleted " +
                "FROM pets a, species b " +
                "WHERE a.tsn = b.tsn " +
                "AND (LOWER(a.name) LIKE '%" + what.ToLower() + "%' OR LOWER(b.familiar_name) LIKE '%" + what.ToLower() + "%' OR LOWER(microchip) LIKE '%" + what.ToLower() + "%' OR LOWER(description) LIKE '%" + what + "%' OR LOWER(color) LIKE '%" + what.ToLower() + "%') ";

            if (IncludeDeleted == false)
            {
                query += "AND a.deleted IS NULL ";
            }

            query += "ORDER BY a.pid DESC";

            DataTable result = Globals.DBCon.Execute(query);
            return result;
        }



        static public DataTable GetProblemsByPid(int pid)
        {
            string query = "SELECT a.id, a.status_id, b.id, b.term_name, a.essential " +
                "FROM problems a, venom_codes b, visit_status c " +
                "WHERE a.diagnosis_id = b.id " +
                "AND a.status_id = c.status_id " +
                "ORDER BY a.status_id DESC";

            DataTable result = Globals.DBCon.Execute(query);

            return result;
        }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Free other state (managed objects).
                }
                // Free your own state (unmanaged objects).
                // Set large fields to null.
                disposed = true;
            }
        }

    }
}
