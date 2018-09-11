using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldAuntie
{
    public class Venom
    {

        public const string REASON_FOR_VISIT = "Reason for visit";
        public const string DIAGNOSIS = "Diagnosis";
        public const string DIAGNOSTIC_TEST = "Diagnostic test";


        public int Id { get; set; }
        public string Status { get; set; }
        public string PreviousStatus { get; set; }
        public string Created { get; set; }
        public string DDID { get; set; }
        public string Label { get; set; }
        public string TermName { get; set; }
        public string TopLevelModeling { get; set; }

        public Venom(int id)
        {
            Load(id);
        }


        public Venom Load(int id)
        {
            string query = "SELECT * FROM venom_codes WHERE id = " + id.ToString();
            DataRow result = Globals.DBCon.SelectOneRow(query);
            if (result != null && result.ItemArray.Count() > 0)
            {
                Id = id;
                Status = result["status"].ToString();
                PreviousStatus = result["previous_status"].ToString();
                Created = result["created"].ToString();
                DDID = result["DDID"].ToString();
                Label = result["label"].ToString();
                TermName = result["term_name"].ToString();
                TopLevelModeling = result["top_level_modeling"].ToString();
            }

            return this;

        }


        public static DataTable Search(string label = "", string search_string = "")
        {
            string query = "SELECT id, term_name as value " +
                "FROM venom_codes " +
                "WHERE 1=1 ";

            if (label != "")
            {
                query += "AND label = '" + label + "' ";
            }


            if (search_string != "")
            {
                query += "AND term_name like '%{" + search_string + "}%' ";
            }

            query += "ORDER BY term_name ASC";

            return Globals.DBCon.Execute(query);
        }


        public static string GetTermNameById(int id)
        {
            string query = "SELECT term_name " +
                "FROM venom_codes " +
                "WHERE id = " + id.ToString() + " ORDER BY term_name ASC";

            return Globals.DBCon.SelectOneValue(query);
        }
    }
}
