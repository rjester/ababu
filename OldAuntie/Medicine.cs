using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldAuntie
{
    public class Medicine
    {
        public string Mid { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public DateTime DateOfIssue { get; set; }
        public DateTime? DateOfWithDrawal { get; set; }
        public string PharmaceuticalForm { get; set; }
        public string TargetSpecied { get; set; }
        public string AdditionalInfo{ get; set; }

        public Medicine(string mid)
        {
            Load(mid);
        }


        public Medicine Load(string mid)
        {
            string query = "SELECT * FROM medicines a " +
                    "WHERE a.mid = '" + mid.ToString() + "'";
            DataRow result = Globals.DBCon.SelectOneRow(query);

            if (result != null && result.ItemArray.Count() > 0)
            {
                Mid = result["mid"].ToString();
                Name = result["name"].ToString();
                Company = result["company"].ToString();
               
                DateOfIssue = (DateTime)result["date_of_issue"];
                DateOfWithDrawal = Utility.IfDBNull(result["date_of_withdrawal"], null);
                PharmaceuticalForm = result["pharmaceutical_form"].ToString();
                AdditionalInfo = result["additional_info"].ToString();
            }

            return this;
        }

        public static DataTable Search(string search_string = "")
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
