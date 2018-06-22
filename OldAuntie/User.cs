using System;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OldAuntie
{
    public class User : IDisposable
    {
        public int Uid = 0;
        public string Username { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public int Rid = 0;
        public string Lid { get; set; }
        public string Phone { get; set; }
        public long? Login { get; set; }
        public long Created { get; set; }
        public long? Updated { get; set; }
        public long? Deleted { get; set; }

        private bool disposed = false;


        public User(int uid = 0)
        {
            if(uid > 0)
            {
                Load(uid);
            }
        }


        public User Load(int uid)
        {
            if(uid > 0)
            {
                DataRow result = Globals.DBCon.SelectOneRow("SELECT * FROM users WHERE uid = " + uid.ToString());

                if (result != null && result.ItemArray.Count() > 0)
                {
                    Uid = uid;
                    Username = result["username"].ToString();
                    Password = result["password"].ToString();
                    Fullname = result["fullname"].ToString();
                    Rid = (int)result["rid"];
                    Lid = result["lid"].ToString();
                    Phone = result["phone"].ToString();
                    Login = Utility.IfDBNull(result["login"], null);
                    Created = (long)result["created"];
                    Updated = Utility.IfDBNull(result["updated"], null);
                    Deleted = Utility.IfDBNull(result["deleted"], null);
                }
            }

            return this;
        }


        public int Save()
        {
            if (Uid > 0)
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
            int affetcedRows = 0;
            string query = "UPDATE users SET " +
                                    "username=@username, " +
                                    "fullname=@fullname, " +
                                    "rid=@rid, " +
                                    "lid=@lid, " +
                                    "phone=@phone, " +
                                    "login=@login, " +
                                    "created=@created, " +
                                    "updated=@updated, " +
                                    "deleted=@deleted " +
                                "WHERE uid=@uid";


            MySqlCommand Cmd = Globals.DBCon.CreateCommand(query);
            Cmd.Parameters.AddWithValue("@uid", Uid);
            Cmd.Parameters.AddWithValue("@username", Username);
            Cmd.Parameters.AddWithValue("@rid", Rid);
            Cmd.Parameters.AddWithValue("@lid", Lid);
            Cmd.Parameters.AddWithValue("@fullname", Fullname);
            Cmd.Parameters.AddWithValue("@phone", Phone);
            Cmd.Parameters.AddWithValue("@login", Login);
            Cmd.Parameters.AddWithValue("@created", Created);
            Cmd.Parameters.AddWithValue("@updated", Utility.Now());
            Cmd.Parameters.AddWithValue("@deleted", Deleted);

            affetcedRows = Cmd.ExecuteNonQuery();

            return affetcedRows;
        }

        public int UpdatePassword()
        {
            int affetcedRows = 0;
            string query = "UPDATE users SET " +
                                    "password=@password " +
                                "WHERE uid=@uid";


            MySqlCommand Cmd = Globals.DBCon.CreateCommand(query);
            Cmd.Parameters.AddWithValue("@uid", Uid);
            Cmd.Parameters.AddWithValue("@password", Utility.MD5(Password));

            affetcedRows = Cmd.ExecuteNonQuery();

            return affetcedRows;
        }


        public int Insert()
        {
            int affetcedRows = 0;

            string query = "INSERT INTO users (username, password, fullname, rid, lid, phone, created) " +
                        "VALUES (@username, @password, @fullname, @rid, @lid, @phone, @created)";

            MySqlCommand Cmd = Globals.DBCon.CreateCommand(query);
            Cmd.Parameters.AddWithValue("@username", Username);
            Cmd.Parameters.AddWithValue("@password", Utility.MD5(Password));
            Cmd.Parameters.AddWithValue("@fullname", Fullname);
            Cmd.Parameters.AddWithValue("@rid", Rid);
            Cmd.Parameters.AddWithValue("@lid", Lid);
            Cmd.Parameters.AddWithValue("@phone", Phone);
            Cmd.Parameters.AddWithValue("@created", Utility.Now());

            affetcedRows = Cmd.ExecuteNonQuery();

            return affetcedRows;
        }

        public int Delete()
        {
            Deleted = Utility.Now();
            return Update();
        }

        public static bool Check(string username, string password)
        {
            string query = "SELECT uid FROM users " +
                "WHERE username = '" + username + "' " +
                "AND UPPER(password) = UPPER('" + Utility.MD5(password) + "') " +
                "AND deleted IS NULL";

            bool result = Globals.DBCon.Exists(query);

            return result;
        }


        public static int GetUidByUsername(string username)
        {
            string query = "SELECT uid FROM users " +
                "WHERE username = '" + username + "'";

            int result = Utility.IfNull(Globals.DBCon.SelectOneValue(query), 0);
            return result;
        } 


        static public DataTable GetUsersList(int uid = 0)
        {
            string query = "SELECT a.uid as uid, a.username, b.name as role, a.fullname, a.deleted " +
                "FROM users a, roles b " +
                "WHERE a.rid = b.rid";
            if(uid > 0)
            {
                query += " AND a.uid=" + uid;
            }
            query += " ORDER BY a.rid DESC";

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
}
