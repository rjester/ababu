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
        public DateTime? Deleted { get; set; }


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
                Deleted = Utility.IfDBNull(result["deleted"], null);
            }

            return this;
        }








        public static DataTable List()
        {
            DataTable result = Globals.DBCon.Execute("SELECT id, CONCAT(firstname, ' ', lastname) as owner FROM owners");
            return result;
        }
    }
}
