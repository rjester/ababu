using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldAuntie
{
    public class Layout : IDisposable
    {
        private bool disposed = false;

        public int Id { get; set; }
        public Scope Scope { get; set; }
        public string Name { get; set; }
        public string Xml { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }

        private const string ENTITY_GLUE = "=>";
        private Dictionary<string, object> PrintableItems = new Dictionary<string, object>();



        public Layout(Scope scope = null)
        {
            if(scope != null)
            {
                SetScope(scope);
            }
        }

        public void SetScope(Scope scope)
        {
            Scope = scope;
        }


        public Layout Load(int id)
        {
            DataRow result = Globals.DBCon.SelectOneRow("SELECT * FROM layouts WHERE id = " + id.ToString());

            if (result.ItemArray.Count() > 0)
            {
                Id = (int)result["id"];
                Scope = new Scope ((int)result["scope_id"]);
                Name = result["name"].ToString();
                Xml = result["xml"].ToString();
                Created = (DateTime)result["created"];
                Updated = Utility.IfDBNull(result["updated"], null);
            }

            return this;
        }

        

        public void AddPrintables(string entity, DataRow printables)
        {
            // transform the datarow into a dictionary
            Dictionary<string, object> items = printables.Table.Columns
                .Cast<DataColumn>()
                .ToDictionary(col => col.ColumnName, col => printables[col.ColumnName]);

            AddPrintables(entity, items);
        }


        public void AddPrintables(string entity, Dictionary<string, object> printables)
        {
            PrintableItems.Add(entity, printables);
        }


        public string Render()
        {
            // get the layout to trasform
            string output = Xml;
            foreach (KeyValuePair<string, object> entity in PrintableItems)
            {
                string entity_name = entity.Key.ToString();

                Dictionary<string, object> printables = (Dictionary<string, object>)entity.Value;

                foreach(KeyValuePair<string, object> printable_item in printables)
                {
                    string item_name = printable_item.Key.ToString();

                    if ( printable_item.Value.GetType() == typeof( Dictionary<string, object>) )
                    {
                        // Value is a Dictionary;
                    }
                    else if (printable_item.Value.GetType() == typeof(DateTime))
                    {
                        // Value is a DateTime.
                        string item_value = printable_item.Value.ToString();
                        
                        output = output.Replace("[" + entity_name + ENTITY_GLUE + item_name + "]", item_value);
                    }
                    else
                    {
                        // Value is an int or string.
                        string item_value = printable_item.Value.ToString();

                        output = output.Replace("[" + entity_name + ENTITY_GLUE + item_name + "]", item_value);
                    }
                }                
            }

            return output;
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
            int affetced_rows = 0;
            string sql = "UPDATE layouts SET scope_id=@scope_id, name=@name, xml=@xml, updated=@updated " +
                        "WHERE id=@id";

            MySqlCommand cmd = Globals.DBCon.CreateCommand(sql);
            cmd.Parameters.AddWithValue("@id", (int)Id);
            cmd.Parameters.AddWithValue("@scope_id", Scope.Id);
            cmd.Parameters.AddWithValue("@name", Name);
            cmd.Parameters.AddWithValue("@xml", Xml);
            cmd.Parameters.AddWithValue("@updated", DateTime.Now);

            affetced_rows = cmd.ExecuteNonQuery();

            return affetced_rows;
        }



        public int Insert()
        {
            int affetced_rows = 0;
            string sql = "INSERT INTO layouts (scope_id, name, xml, created) " +
                        "VALUES (@scope_id, @name, @xml, @created)";

            MySqlCommand cmd = Globals.DBCon.CreateCommand(sql);
            cmd.Parameters.AddWithValue("@scope_id", Scope.Id);
            cmd.Parameters.AddWithValue("@name", Name);
            cmd.Parameters.AddWithValue("@xml", Xml);
            cmd.Parameters.AddWithValue("@created", DateTime.Now);

            affetced_rows = cmd.ExecuteNonQuery();

            return affetced_rows;
        }


        public int Delete()
        {
            int affetced_rows = 0;
            string sql = "DELETE FROM layouts WHERE id=@id";

            MySqlCommand cmd = Globals.DBCon.CreateCommand(sql);
            cmd.Parameters.AddWithValue("@id", (int)Id);

            affetced_rows = cmd.ExecuteNonQuery();

            return affetced_rows;
        }


        public DataTable GetAllLayoutsByScope(Scope scope = null)
        {
            return Search(scope);
        }



        public DataTable Search(Scope scope = null, string search = "")
        {
            string query = "SELECT * FROM layouts WHERE 1=1";

            if (scope != null)
            {
                query += " AND scope_id = " + scope.Id;
            }

            if(search != "")
            {
                query += " AND LOWER(name) LIKE LOWER('%" + search + "%')";
            }

            query += " ORDER BY created DESC, id DESC";

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
