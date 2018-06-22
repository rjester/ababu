using System;
using System.Data;
using System.Data.SQLite;

namespace OldAuntie
{
    public class BaseDatiLite
    {
        private bool disposed = false;

        private string database = string.Empty;

        public const Int32 RETURN_READER = 0;
        public const Int32 RETURN_DATATABLE = 1;

        private SQLiteConnection connection = null;
        private SQLiteCommand command = null;

        private static BaseDatiLite _instance = null;

        public SQLiteConnection Connection { get => connection; }
        public string Database { get => database; set => database = value; }


        public BaseDatiLite()
        {
        }

        public bool Connect(string db_path)
        {
            database = db_path;
            return Connect();
        }


        public bool Connect()
        {
            bool result = false;

            try
            {
                string connection_string = string.Format("Data Source={0};Version=3;", Database);
                connection = new SQLiteConnection(connection_string);
                connection.Open();
                result = true;
            }
            catch (SQLiteException e)
            {
                Log log = new Log();
                log.Write(e.Message, Log.LOG_TYPE_ERROR);
            }

            return result;
        }


        public static BaseDatiLite Instance()
        {
            if (_instance == null)
            {
                _instance = new BaseDatiLite();
            }
            return _instance;
        }


        public bool IsConnected()
        {
            bool result = false;
            if (connection != null)
            {
                result = true;
            }

            return result;
        }


        public dynamic Execute(string query, Int32 returnType = BaseDatiLite.RETURN_DATATABLE)
        {
            SQLiteDataReader reader = null;

            try
            {
                SQLiteCommand cmd = new SQLiteCommand(query, connection);
                reader = cmd.ExecuteReader();
                if (returnType == BaseDatiLite.RETURN_DATATABLE)
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
            /*
            @todo @deleteme
            string query = @"select last_insert_rowid()";

            SQLiteCommand cmd = new SQLiteCommand(query, connection);

            long lastId = (long)cmd.ExecuteScalar(); // Need to type-cast since `ExecuteScalar` returns an object.

            return lastId;
            */
            return connection.LastInsertRowId;
        }

        
        public SQLiteCommand CreateCommand(string query)
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
            DataTable DtResult = Execute(query, BaseDatiLite.RETURN_DATATABLE);

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
            if (dt != null && dt.Rows.Count > 0 )
            {
                return true;
            }
            else
            {
                return false;
            }

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
