using System;
using System.Collections.Generic;
using System.Data;
// using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OldAuntie
{
    public class Pet : IDisposable
    {
        public int Id { get; set; }
        public int Tsn { get; set; }
        public int OwnerId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public long DateOfBirth { get; set; }
        public long? DateOfDeath { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public string Microchip { get; set; }
        public string MicrochipLocation { get; set; }
        public string Tatuatge { get; set; }
        public string TatuatgeLocation { get; set; }
        public long Created { get; set; }
        public long? Updated { get; set; }

        // Properties / fields not in Database
        public int Years { get; set; }
        public int Months { get; set; }
        public int Days { get; set; }

        public Species Specie { get; set; }

        private bool disposed = false;


        public Pet(int id = 0)
        {
            if(id > 0)
            {
                Load(id);
            }
        }


        public Pet Load(int id)
        {
            if (id > 0)
            {
                DataRow result = Globals.DBCon.SelectOneRow("SELECT * FROM pets WHERE id = " + id.ToString());

                if (result != null && result.ItemArray.Count() > 0)
                {
                    Id = id;
                    Tsn = (int)result["tsn"];
                    OwnerId = (int)result["owner_id"];
                    Name = result["name"].ToString();
                    Gender = result["gender"].ToString();
                    DateOfBirth = (long)result["date_of_birth"];
                    DateOfDeath = Utility.IfDBNull(result["date_of_death"], null);

                    Description = result["description"].ToString();
                    Color = result["color"].ToString();
                    Microchip = result["microchip"].ToString();
                    MicrochipLocation = result["microchip_location"].ToString();
                    Tatuatge = result["tatuatge"].ToString();
                    TatuatgeLocation = result["tatuatge_location"].ToString();

                    Created = (long)result["created"];
                    Updated = Utility.IfDBNull(result["updated"], null);

                    // calculate age of the patient
                    DateTime DtDateOfBirth = Utility.UnixTimeStampToDateTime((long)DateOfBirth);
                    DateTime DtDateMax = DateTime.Now;

                    if (DateOfDeath != null)
                    {
                        DtDateMax = Utility.UnixTimeStampToDateTime((long)DateOfDeath);
                    }

                    TimeSpan ts = DtDateMax - DtDateOfBirth;
                    DateTime Age = DateTime.MinValue.AddDays(ts.Days);
                    Years = DtDateMax.Year - DtDateOfBirth.Year;
                    Months = DtDateMax.Month - DtDateOfBirth.Month;
                    Days = DtDateMax.Day - DtDateOfBirth.Day;


                    Specie = new Species(Tsn);
                }
            }

            return this;
        }


        public int Save()
        {
            if (Id > 0)
            {
                return Update();
            }
            else
            {
                return Insert();
            }
        }


        public int Update()
        {
            int affected_rows = 0;
            int updated_id = 0;

            string query = "UPDATE pets SET " +
                                    "tsn=@tsn, " +
                                    "owner_id=@owner_id, " +
                                    "name=@name, " +
                                    "gender=@gender, " +
                                    "date_of_birth=@date_of_birth, " +
                                    "date_of_death=@date_of_death, " +
                                    "description=@description, " +
                                    "color=@color, " +
                                    "microchip=@microchip, " +
                                    "microchip_location=@microchip_location, " +
                                    "tatuatge=@tatuatge, " +
                                    "tatuatge_location=@tatuatge_location, " +
                                    "created=@created, " +
                                    "updated=@updated " +
                                "WHERE id=@id";


            MySqlCommand Cmd = Globals.DBCon.CreateCommand(query);
            Cmd.Parameters.AddWithValue("@id", Id);
            Cmd.Parameters.AddWithValue("@tsn", Tsn);
            Cmd.Parameters.AddWithValue("@owner_id", OwnerId);
            Cmd.Parameters.AddWithValue("@name", Name);
            Cmd.Parameters.AddWithValue("@gender", Gender);
            Cmd.Parameters.AddWithValue("@date_of_birth", DateOfBirth);
            Cmd.Parameters.AddWithValue("@date_of_death", DateOfDeath);
            Cmd.Parameters.AddWithValue("@description", Description);
            Cmd.Parameters.AddWithValue("@color", Color);
            Cmd.Parameters.AddWithValue("@microchip", Microchip);
            Cmd.Parameters.AddWithValue("@microchip_location", MicrochipLocation);
            Cmd.Parameters.AddWithValue("@tatuatge", Tatuatge);
            Cmd.Parameters.AddWithValue("@tatuatge_location", TatuatgeLocation);
            Cmd.Parameters.AddWithValue("@created", Created);
            Cmd.Parameters.AddWithValue("@updated", Utility.Now());

            affected_rows = Cmd.ExecuteNonQuery();
            if(affected_rows > 0)
            {
                updated_id = Id;
            }

            return updated_id;
        }

        
        public int Insert()
        {
            int affected_rows = 0;
            int insert_id = 0;

            string query = "INSERT into pets (tsn, owner_id, name, gender, date_of_birth, date_of_death, description, color, microchip, microchip_location, tatuatge, tatuatge_location, created) " +
                        "VALUES (@tsn, @owner_id, @name, @gender, @date_of_birth, @date_of_death, @description, @color, @microchip, @microchip_location, @tatuatge, @tatuatge_location, @created)";

            MySqlCommand Cmd = Globals.DBCon.CreateCommand(query);
            Cmd.Parameters.AddWithValue("@tsn", Tsn);
            Cmd.Parameters.AddWithValue("@owner_id", OwnerId);
            Cmd.Parameters.AddWithValue("@name", Name);
            Cmd.Parameters.AddWithValue("@gender", Gender);
            Cmd.Parameters.AddWithValue("@date_of_birth", DateOfBirth);
            Cmd.Parameters.AddWithValue("@date_of_death", DateOfDeath);
            Cmd.Parameters.AddWithValue("@description", Description);
            Cmd.Parameters.AddWithValue("@color", Color);
            Cmd.Parameters.AddWithValue("@microchip", Microchip);
            Cmd.Parameters.AddWithValue("@microchip_location", MicrochipLocation);
            Cmd.Parameters.AddWithValue("@tatuatge", Tatuatge);
            Cmd.Parameters.AddWithValue("@tatuatge_location", TatuatgeLocation);
            Cmd.Parameters.AddWithValue("@created", Utility.Now());

            affected_rows = Cmd.ExecuteNonQuery();

            if(affected_rows > 0)
            {
                insert_id = Convert.ToInt32(Globals.DBCon.InsertID());
            }

            return insert_id;
        }


        public long Delete()
        {
            int affected_rows = 0;
            string query = "DELETE FROM pets WHERE id = @id";

            MySqlCommand Cmd = Globals.DBCon.CreateCommand(query);
            Cmd.Parameters.AddWithValue("@id", Id);
            affected_rows = Cmd.ExecuteNonQuery();

            return affected_rows;
        }


        static public DataTable Search(string what = "")
        {
            string query = "SELECT a.id as id, a.name, b.familiar_name as species, a.microchip, a.description, a.color " +
                "FROM pets a, species b " +
                "WHERE a.tsn = b.tsn " +
                "AND (LOWER(a.name) LIKE '%" + what.ToLower() + "%' OR LOWER(b.familiar_name) LIKE '%" + what.ToLower() + "%' OR LOWER(microchip) LIKE '%" + what.ToLower() + "%' OR LOWER(description) LIKE '%" + what + "%' OR LOWER(color) LIKE '%" + what.ToLower() + "%') " +
                "ORDER BY a.id DESC";

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

    // define a custom eventargs class to pass Pet ID
    public class PetEventArgs : EventArgs
    {
        public PetEventArgs(int pet_id)
        {
            this.PetId = pet_id;
        }

        public int PetId { get; private set; }
    }
}
