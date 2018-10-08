using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OldAuntie
{
    public class User : IDisposable
    {
        public int Id = 0;
        public int RoleId = 0;
        public string Username { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public string Phone { get; set; }
        public long? Login { get; set; }
        public long Created { get; set; }
        public long? Updated { get; set; }
        public long? Deleted { get; set; }

        private bool disposed = false;


        public User(int id = 0)
        {
            if(id > 0)
            {
                Load(id);
            }
        }


        public User Load(int id)
        {
            if(id > 0)
            {
                DataRow result = Globals.DBCon.SelectOneRow("SELECT * FROM users WHERE id = " + id.ToString());

                if (result != null && result.ItemArray.Count() > 0)
                {
                    Id = id;
                    RoleId = (int)result["role_id"];
                    Username = result["username"].ToString();
                    Password = result["password"].ToString();
                    Fullname = result["fullname"].ToString();
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
            string query = "UPDATE users SET " +
                                    "role_id=@role_id, " +
                                    "username=@username, " +
                                    "fullname=@fullname, " +
                                    "phone=@phone, " +
                                    "login=@login, " +
                                    "created=@created, " +
                                    "updated=@updated, " +
                                    "deleted=@deleted " +
                                "WHERE id=@id";


            MySqlCommand Cmd = Globals.DBCon.CreateCommand(query);
            Cmd.Parameters.AddWithValue("@id", Id);
            Cmd.Parameters.AddWithValue("@role_id", RoleId);
            Cmd.Parameters.AddWithValue("@username", Username);
            Cmd.Parameters.AddWithValue("@fullname", Fullname);
            Cmd.Parameters.AddWithValue("@phone", Phone);
            Cmd.Parameters.AddWithValue("@login", Login);
            Cmd.Parameters.AddWithValue("@created", Created);
            Cmd.Parameters.AddWithValue("@updated", Utility.Now());
            Cmd.Parameters.AddWithValue("@deleted", Deleted);

            affected_rows = Cmd.ExecuteNonQuery();

            return affected_rows;
        }

        public int UpdatePassword()
        {
            int affected_rows = 0;
            string query = "UPDATE users SET " +
                                    "password=@password " +
                                "WHERE id=@id";


            MySqlCommand Cmd = Globals.DBCon.CreateCommand(query);
            Cmd.Parameters.AddWithValue("@Id", Id);
            Cmd.Parameters.AddWithValue("@password", Utility.MD5(Password));

            affected_rows = Cmd.ExecuteNonQuery();

            return affected_rows;
        }


        public int Insert()
        {
            int affected_rows = 0;

            string query = "INSERT INTO users (role_id, username, password, fullname, phone, created) " +
                        "VALUES (@role_id, @username, @password, @fullname, @phone, @created)";

            MySqlCommand Cmd = Globals.DBCon.CreateCommand(query);
            Cmd.Parameters.AddWithValue("@role_id", RoleId);
            Cmd.Parameters.AddWithValue("@username", Username);
            Cmd.Parameters.AddWithValue("@password", Utility.MD5(Password));
            Cmd.Parameters.AddWithValue("@fullname", Fullname);
            Cmd.Parameters.AddWithValue("@phone", Phone);
            Cmd.Parameters.AddWithValue("@created", Utility.Now());

            affected_rows = Cmd.ExecuteNonQuery();

            return affected_rows;
        }

        public int Delete()
        {
            Deleted = Utility.Now();
            return Update();
        }

        public static bool Check(string username, string password)
        {
            string query = "SELECT id FROM users " +
                "WHERE username = '" + username + "' " +
                "AND UPPER(password) = UPPER('" + Utility.MD5(password) + "') " +
                "AND deleted IS NULL";

            bool result = Globals.DBCon.Exists(query);

            return result;
        }


        public static int GetUidByUsername(string username)
        {
            string query = "SELECT id FROM users " +
                "WHERE username = '" + username + "'";

            int result = Utility.IfNull(Globals.DBCon.SelectOneValue(query), 0);
            return result;
        } 


        static public DataTable GetUsersList(int id = 0)
        {
            string query = "SELECT a.id as id, a.username, b.name as role, a.fullname, a.deleted " +
                "FROM users a, roles b " +
                "WHERE a.role_id = b.id";
            if(id > 0)
            {
                query += " AND a.id=" + id;
            }
            query += " ORDER BY a.role_id DESC";

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
