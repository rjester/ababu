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

        public Venom(long id)
        {
            string query = "SELECT * FROM venom_codes WHERE id = " + id.ToString();
            DataRow DrResult = Globals.DBCon.SelectOneRow(query);
        }


        /*
        public static string GetReasonForVisit(long reason_id)
        {
            string result = String.Empty;
            DataTable DtResult = Search(REASON_FOR_VISIT, reason_id.ToString());

            if(DtResult != null)
            {
                result = DtResult.Rows[0].ItemArray[0].ToString();
            }

            return result;
        }
        */

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


        public static string GetTermNameById(int id, string country_id = "gb")
        {
            string query = "SELECT term_name " +
                "FROM venom_codes " +
                "WHERE country_id = '" + country_id + "' " +
                "AND id = " + id.ToString() + " ORDER BY term_name ASC";

            return Globals.DBCon.SelectOneValue(query);
        }





    }
}
