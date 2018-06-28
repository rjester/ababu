using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldAuntie
{
    public class Visit : IDisposable
    {
        public int Vid { get; set; }
        public int Pid { get; set; }
        public int Oid { get; set; }
        public int ReasonId { get; set; }
        public int DiagnosisId { get; set; }
        public string Description { get; set; }

        public int StatusId { get; set; }
        public int TypeId { get; set; }

        public long Created { get; set; }
        public long? Updated { get; set; }
        public long? Deleted { get; set; }


        // properties not mapped in database table Visit 
        public string StatusDescription { get;  set; }
        private bool disposed = false;
        

        public Visit(int vid = 0)
        {
            if (vid > 0)
            {
                Load(vid);
            }
        }


        public Visit Load(int vid)
        {
            if (vid > 0)
            {
                string query = "SELECT * FROM visit a, visit_status b " +
                    "WHERE a.status_id = b.status_id " +
                    "AND a.vid = " + vid.ToString();
                DataRow result = Globals.DBCon.SelectOneRow(query);

                if (result != null && result.ItemArray.Count() > 0)
                {
                    Vid = vid;
                    Pid = (int)result["pid"];
                    Oid = (int)result["oid"];
                    ReasonId = (int)result["reason_id"];
                    DiagnosisId = (int)result["diagnosis_id"];


                    Description = result["description"].ToString();
                    StatusId = (int)result["status_id"];

                    Created = (long)result["created"];
                    Updated = Utility.IfDBNull(result["updated"], null);
                    Deleted = Utility.IfDBNull(result["deleted"], null);

                    StatusDescription = result["status_description"].ToString();
                }
            }

            return this;
        }


        static public DataTable GetVisitsList(int vid = 0)
        {
            string query = "SELECT a.vid as vid, a.description as description, b.name as name " +
                "FROM visit a, pets b " +
                "WHERE a.pid = b.pid";
            if (vid > 0)
            {
                query += " AND a.vid=" + vid;
            }
            query += " ORDER BY a.vid DESC";

            DataTable result = Globals.DBCon.Execute(query);

            return result;
        }


        static public DataTable GetVisitListByPid(int pid)
        {
            string query = "SELECT a.vid as vid, a.description as description, b.name as name " +
                "FROM visit a, pets b " +
                "WHERE a.pid = b.pid " +
                "AND a.pid=" + pid + " " + 
                "ORDER BY a.vid DESC";

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
