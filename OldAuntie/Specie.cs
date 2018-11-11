using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldAuntie
{
    public class Specie
    {

        public int Tsn { get; set; }
        public string CompleteName { get; set; }
        public string FamiliarName { get; set; }

        public Specie(int tsn = 0)
        {
            Tsn = tsn;
            Load(tsn);
        }


        public Specie Load(int tsn)
        {
            if (tsn > 0)
            {
                DataRow result = Globals.DBCon.SelectOneRow("SELECT * FROM species WHERE tsn = " + tsn.ToString());

                if (result != null && result.ItemArray.Count() > 0)
                {
                    CompleteName = result["complete_name"].ToString();
                    FamiliarName = result["familiar_name"].ToString();
                }
            }

            return this;
        }



        public int Insert()
        {
            int affected_rows = 0;
            string query = "INSERT INTO species (tsn, complete_name, familiar_name, created) " +
                "VALUES (@tsn, @complete_name, @familiar_name, @created)";

            MySqlCommand Cmd = Globals.DBCon.CreateCommand(query);
            Cmd.Parameters.AddWithValue("@tsn", Tsn);
            Cmd.Parameters.AddWithValue("@complete_name", CompleteName);
            Cmd.Parameters.AddWithValue("@familiar_name", FamiliarName);
            
            Cmd.Parameters.AddWithValue("@created", DateTime.Now);

            affected_rows = Cmd.ExecuteNonQuery();

            return affected_rows;
        }



        public int Delete()
        {
            int affected_rows = 0;
            string query = "DELETE FROM species WHERE tsn = @tsn";

            MySqlCommand Cmd = Globals.DBCon.CreateCommand(query);
            Cmd.Parameters.AddWithValue("@tsn", Tsn);
            affected_rows = Cmd.ExecuteNonQuery();

            return affected_rows;
        }



        public static DataTable List()
        {
            DataTable result = Globals.DBCon.Execute("SELECT * FROM species");
            return result;
        }


        public static DataTable GetAllSpecies(string search = "", bool exclude_already_selected = true)
        {
            string query = "SELECT * FROM itis_longnames WHERE 1=1";
            if(search != "")
            {
                query += " AND LOWER(completename) LIKE LOWER('%" + search + "%')";
            }

            if(exclude_already_selected == true)
            {
                query += " AND tsn NOT IN (SELECT tsn FROM species)";
            }

            return Globals.DBCon.Execute(query);
        }
    }

    
}
