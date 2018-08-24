using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldAuntie
{
    public class Prescription
    {
        public string Mid { get; set; }
        public int Pid { get; set; }
        public int Qty { get; set; }
        public DateTime Created { get; set; }

        public Prescription(string mid, int pid)
        {
            Load(mid, pid);    
        }


        public Prescription Load(string mid, int pid)
        {
            string query = "SELECT * FROM prescriptions a, medicines b " +
                    "WHERE a.mdi = b.mid" +
                    "AND a.pid = " + pid.ToString() + " " +
                    "AND a.diagnosis_id = " + mid.ToString();
            DataRow result = Globals.DBCon.SelectOneRow(query);

            if (result != null && result.ItemArray.Count() > 0)
            {
                Mid = result["mid"].ToString();
                Pid = (int)result["pid"];
                Created = (DateTime)result["created"];
            }

            return this;
        }



        public static DataTable MedicineSearch(string search_string = "")
        {
            string query = "SELECT mid, name as value " +
                "FROM medicines " +
                "WHERE 1=1 ";
            

            if (search_string != "")
            {
                query += "AND name like '%{" + search_string + "}%' ";
            }

            query += "ORDER BY name ASC";

            return Globals.DBCon.Execute(query);
        }

    }
}
