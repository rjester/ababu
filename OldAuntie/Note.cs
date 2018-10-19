using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldAuntie
{
    public class Note
    {
        public int Id { get; set; }
        public int PetId { get; set; }
        public int UserId { get; set; }
        public string NoteText { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }

        public Note(int id = 0)
        {
            Id = id;
            Created = DateTime.Now;

            Load(id);
        }


        public Note Load(int id)
        {
            DataRow result = Globals.DBCon.SelectOneRow("SELECT * FROM notes WHERE id = " + id.ToString());

            if (result != null && result.ItemArray.Count() > 0)
            {
                Id = id;
                PetId = (int)result["pet_id"];
                UserId = (int)result["user_id"];
                NoteText = result["note_text"].ToString();

                Created = (DateTime)result["created"];
                Updated = Utility.IfDBNull(result["updated"], null);
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

            string query = "UPDATE notes SET " +
                                    "pet_id=@pet_id, " +
                                    "user_id=@user_id, " +
                                    "note_text=@note_text, " +
                                    "created=@created, " +
                                    "updated=@updated " +
                                "WHERE nid=@nid";


            MySqlCommand Cmd = Globals.DBCon.CreateCommand(query);
            Cmd.Parameters.AddWithValue("@id", Id);
            Cmd.Parameters.AddWithValue("@pet_id", PetId);
            Cmd.Parameters.AddWithValue("@user_id", UserId);
            Cmd.Parameters.AddWithValue("@note_text", NoteText);
            Cmd.Parameters.AddWithValue("@created", Created);
            Cmd.Parameters.AddWithValue("@updated", DateTime.Now);

            affected_rows = Cmd.ExecuteNonQuery();
            if (affected_rows > 0)
            {
                updated_id = Id;
            }

            return updated_id;
        }


        public int Insert()
        {
            int affected_rows = 0;
            int insert_id = 0;

            string query = "INSERT into notes (pet_id, user_id, note_text, created) " +
                        "VALUES (@pet_id, @user_id, @note_text, @created)";

            MySqlCommand Cmd = Globals.DBCon.CreateCommand(query);
            Cmd.Parameters.AddWithValue("@pet_id", PetId);
            Cmd.Parameters.AddWithValue("@user_id", UserId);
            Cmd.Parameters.AddWithValue("@note_text", NoteText);
            Cmd.Parameters.AddWithValue("@created", DateTime.Now);

            affected_rows = Cmd.ExecuteNonQuery();

            if (affected_rows > 0)
            {
                insert_id = Convert.ToInt32(Globals.DBCon.InsertID());
            }

            return insert_id;
        }


        public int Delete()
        {
            int affected_rows = 0;

            string query = "DELETE FROM notes WHERE id=@id";

            MySqlCommand Cmd = Globals.DBCon.CreateCommand(query);
            Cmd.Parameters.AddWithValue("@id", Id);

            affected_rows = Cmd.ExecuteNonQuery();

            return affected_rows;
        }


        static public DataTable GetNotesByPetId(int pet_id)
        {
            string query = "SELECT * " +
                "FROM notes a " +
                "WHERE a.pet_id = " + pet_id + " " +
                "ORDER BY a.id DESC";

            DataTable result = Globals.DBCon.Execute(query);

            return result;
        }

    }
}
