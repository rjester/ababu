using System;
using System.Data;
using System.IO;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace OldAuntie
{
    public class BaseDatiMariaDB
    {
        private bool disposed = false;

        private string server = string.Empty;
        private string database = string.Empty;
        private string username = string.Empty;
        private string password = string.Empty;

        public const Int32 RETURN_READER = 0;
        public const Int32 RETURN_DATATABLE = 1;

        private MySqlConnection connection = null;
        private MySqlCommand command = null;

        private static BaseDatiMariaDB _instance = null;

        public MySqlConnection Connection { get => connection; }
        public string Server { get => server; set => server = value; }
        public string Database { get => database; set => database = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }


        public BaseDatiMariaDB()
        {
        }


        public bool Connect(string db_server, string db_name, string db_username, string db_password)
        {
            server = db_server;
            database = db_name;
            username = db_username;
            password = db_password;

            return Connect();
        }


        public bool Connect()
        {
            bool result = false;

            try
            {
                string connstring = string.Format("Server={0}; database={1}; UID={2}; password={3}; Pooling=false; SslMode=none;", server, database, username, password);
                connection = new MySqlConnection(connstring);
                connection.Open();
                result = true;

            }
            catch (MySqlException e)
            {
                Log log = new Log();
                log.Write(e.Message, Log.LOG_TYPE_ERROR);
            }

            return result;
        }


        public static BaseDatiMariaDB Instance()
        {
            if (_instance == null)
            {
                _instance = new BaseDatiMariaDB();
            }
            return _instance;
        }


        public bool IsConnected()
        {
            bool result = false;
            if (connection != null && connection.State == ConnectionState.Open)
            {
                result = true;
            }

            return result;
        }


        public dynamic Execute(string query, Int32 returnType = BaseDati.RETURN_DATATABLE)
        {
            MySqlDataReader reader = null;

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                reader = cmd.ExecuteReader();
                if (returnType == BaseDatiMariaDB.RETURN_DATATABLE)
                {
                    DataTable dtResult = new DataTable();
                    dtResult.Load(reader);

                    return dtResult;
                }
                else
                {
                    return reader;
                }
            }
            catch (Exception e)
            {
                Log log = new Log();
                log.Write(e.Message, Log.LOG_TYPE_ERROR);
            }

            return reader;
        }

        public long InsertID()
        {
            return command.LastInsertedId;
        }



        public MySqlCommand CreateCommand(string query)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = query;
            }
            catch (Exception e)
            {
                Log log = new Log();
                log.Write(e.ToString());
            }
            return command;
        }



        public void Close()
        {
            connection.Close();
            connection.Dispose();
        }



        public DataRow SelectOneRow(string query)
        {
            DataTable DtResult = Execute(query, BaseDati.RETURN_DATATABLE);

            try
            {
                return DtResult.Rows[0];
            }
            catch
            {
                return null;
            }
        }


        public dynamic SelectOneValue(string query)
        {
            DataRow result = SelectOneRow(query);

            if (result != null)
            {
                return result.ItemArray[0];
            }
            else
            {
                return result;
            }
        }



        public bool Exists(string query)
        {
            DataTable dt = Execute(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }



        public void ExecuteScript(string file)
        {
            ExecuteScript(file, String.Empty);
        }

        public void ExecuteScript(string file, string delimiter)
        {
            MySqlScript script = new MySqlScript(connection, File.ReadAllText(file));

            if (delimiter != string.Empty)
            {
                script.Delimiter = delimiter;
            }

            script.Execute();
        }



        public DataTable GetDatabases(string Prefix = "")
        {
            string query = "select SCHEMA_NAME from information_schema.SCHEMATA";

            if (Prefix != "")
            {
                query += " WHERE SCHEMA_NAME LIKE '" + Prefix + "%'";
            }

            return Execute(query); ;
        }




        //Implement IDisposable.
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
