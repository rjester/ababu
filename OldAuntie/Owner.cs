using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldAuntie
{
    public class Owner
    {
        public int Id { get; private set; }
        public string CountryId { get; set; }
        public string Firtname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public string Postcode { get; set; }
        public string City { get; set; }
        public string Ssn { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }


        public Owner(int id = 0)
        {
            Load(id);
        }


        public Owner Load(int id)
        {
            Id = id;

            string query = "SELECT * FROM owners a WHERE a.id = " + id;
            DataRow result = Globals.DBCon.SelectOneRow(query);

            if (result != null && result.ItemArray.Count() > 0)
            {
                CountryId = result["country_id"].ToString();
                Firtname = result["firstname"].ToString();
                Lastname = result["lastname"].ToString();
                Address = result["address"].ToString();
                Postcode = result["postcode"].ToString();
                City = result["city"].ToString();
                Ssn = result["ssn"].ToString();
                Phone = result["phone"].ToString();
                Mobile = result["mobile"].ToString();
                Email = result["email"].ToString();
                Created = (DateTime)result["created"];
                Updated = Utility.IfDBNull(result["updated"], null);
            }

            return this;
        }








        public static DataTable List()
        {
            DataTable result = Globals.DBCon.Execute("SELECT id, CONCAT(firstname, ' ', lastname) as owner FROM owners");
            return result;
        }


        public int Save()
        {
            if (Exists())
            {
                return Update();
            }
            else
            {
                return Insert();
            }
        }


        public bool Exists()
        {
            if (Id > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public int Update()
        {
            int affected_rows = 0;
            string query = "UPDATE owners SET " +
                "country_id=@country_id, " +
                "firstname=@firstname, " +
                "lastname=@lastname, " +
                "address=@address, " +
                "postcode=@postcode, " +
                "city=@city, " +
                "ssn=@ssn, " +
                "phone=@phone, " +
                "mobile=@mobile, " +
                "email=@email, " +
                "created=@created, " +
                "updated=@updated " +
                "WHERE id=@id";

            MySqlCommand Cmd = Globals.DBCon.CreateCommand(query);
            Cmd.Parameters.AddWithValue("@id", Id);
            Cmd.Parameters.AddWithValue("@country_id", CountryId);
            Cmd.Parameters.AddWithValue("@firstname", Firtname);
            Cmd.Parameters.AddWithValue("@lastname", Lastname);
            Cmd.Parameters.AddWithValue("@address", Address);
            Cmd.Parameters.AddWithValue("@postcode", Postcode);
            Cmd.Parameters.AddWithValue("@city", City);
            Cmd.Parameters.AddWithValue("@ssn", Ssn);
            Cmd.Parameters.AddWithValue("@phone", Phone);
            Cmd.Parameters.AddWithValue("@mobile", Mobile);
            Cmd.Parameters.AddWithValue("@email", Email);

            Cmd.Parameters.AddWithValue("@created", Created);
            Cmd.Parameters.AddWithValue("@updated", DateTime.Now);

            affected_rows = Cmd.ExecuteNonQuery();

            return affected_rows;
        }



        public int Insert()
        {
            int affected_rows = 0;
            string query = "INSERT INTO owners (country_id, firstname, lastname, address, postcode, city, ssn, phone, mobile, email, created, updated) " +
                "VALUES (@country_id, @firstname, @lastname, @address, @postcode, @city, @ssn, @phone, @mobile, @email, @created, @updated)";

            MySqlCommand Cmd = Globals.DBCon.CreateCommand(query);
            Cmd.Parameters.AddWithValue("@country_id", CountryId);
            Cmd.Parameters.AddWithValue("@firstname", Firtname);
            Cmd.Parameters.AddWithValue("@lastname", Lastname);
            Cmd.Parameters.AddWithValue("@address", Address);
            Cmd.Parameters.AddWithValue("@postcode", Postcode);
            Cmd.Parameters.AddWithValue("@city", City);
            Cmd.Parameters.AddWithValue("@ssn", Ssn);
            Cmd.Parameters.AddWithValue("@phone", Phone);
            Cmd.Parameters.AddWithValue("@mobile", Mobile);
            Cmd.Parameters.AddWithValue("@email", Email);

            Cmd.Parameters.AddWithValue("@created", DateTime.Now);
            Cmd.Parameters.AddWithValue("@updated", Updated);

            affected_rows = Cmd.ExecuteNonQuery();

            return affected_rows;
        }


        public int Delete()
        {
            int affected_rows = 0;
            string query = "DELETE FROM owners WHERE id = @id";

            MySqlCommand Cmd = Globals.DBCon.CreateCommand(query);
            Cmd.Parameters.AddWithValue("@id", Id);
            affected_rows = Cmd.ExecuteNonQuery();
            
            return affected_rows;
        }
    }
}
