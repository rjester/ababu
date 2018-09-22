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
        public int Nid { get; set; }
        public int Pid { get; set; }
        public int Uid { get; set; }
        public string NoteText { get; set; }
        public long Created { get; set; }
        public long? Updated { get; set; }

        public Note(int nid = 0)
        {
            if (nid > 0)
            {
                Load(nid);
            }
        }


        public Note Load(int nid)
        {
            if (nid > 0)
            {
                DataRow result = Globals.DBCon.SelectOneRow("SELECT * FROM notes WHERE nid = " + nid.ToString());

                if (result != null && result.ItemArray.Count() > 0)
                {
                    Nid = nid;
                    Pid = (int)result["pid"];
                    Uid = (int)result["uid"];
                    NoteText = result["note_text"].ToString();

                    Created = (long)result["created"];
                    Updated = Utility.IfDBNull(result["updated"], null);
                }
            }

            return this;
        }


        public int Save()
        {
            if (Nid > 0)
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
                                    "pid=@pid, " +
                                    "uid=@uid, " +
                                    "note_text=@note_text, " +
                                    "created=@created, " +
                                    "updated=@updated " +
                                "WHERE nid=@nid";


            MySqlCommand Cmd = Globals.DBCon.CreateCommand(query);
            Cmd.Parameters.AddWithValue("@nid", Nid);
            Cmd.Parameters.AddWithValue("@pid", Pid);
            Cmd.Parameters.AddWithValue("@uid", Uid);
            Cmd.Parameters.AddWithValue("@note_text", NoteText);
            Cmd.Parameters.AddWithValue("@created", Created);
            Cmd.Parameters.AddWithValue("@updated", Utility.Now());

            affected_rows = Cmd.ExecuteNonQuery();
            if (affected_rows > 0)
            {
                updated_id = Nid;
            }

            return updated_id;
        }


        public int Insert()
        {
            int affected_rows = 0;
            int insert_id = 0;

            string query = "INSERT into notes (pid, uid, note_text, created) " +
                        "VALUES (@pid, @uid, @note_text, @created)";

            MySqlCommand Cmd = Globals.DBCon.CreateCommand(query);
            Cmd.Parameters.AddWithValue("@pid", Pid);
            Cmd.Parameters.AddWithValue("@uid", Uid);
            Cmd.Parameters.AddWithValue("@note_text", NoteText);
            Cmd.Parameters.AddWithValue("@created", Utility.Now());

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

            string query = "DELETE FROM notes WHERE nid=@nid";

            MySqlCommand Cmd = Globals.DBCon.CreateCommand(query);
            Cmd.Parameters.AddWithValue("@nid", Nid);

            affected_rows = Cmd.ExecuteNonQuery();

            return affected_rows;
        }


        static public DataTable GetNotesByPid(int pid)
        {
            string query = "SELECT * " +
                "FROM notes a " +
                "WHERE a.pid = " + pid + " " +
                "ORDER BY a.nid DESC";

            DataTable result = Globals.DBCon.Execute(query);

            return result;
        }

    }
}
