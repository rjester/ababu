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
        public int EntityId { get; set; }
        public string Name { get; set; }
        public string Xml { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        
        // public string LayoutXml { get; set; }

        // public List<string> ENTITIES = ["Prescription", "Examination", "Note"];
        
        private const string ENTITY_GLUE = "=>";

        private Dictionary<string, object> PrintableItems = new Dictionary<string, object>();



        public Layout(int id = 0)
        {
            Id = id;

            if (id > 0)
            {
                Load(id);
            }
        }


        public void AddPrintables(string entity_name, DataRow printables)
        {
            // transform the datarow into a dictionary
            Dictionary<string, object> items = printables.Table.Columns
                .Cast<DataColumn>()
                .ToDictionary(col => col.ColumnName, col => printables[col.ColumnName]);

            AddPrintables(entity_name, items);
        }


        public void AddPrintables(string entity_name, Dictionary<string, object> printables)
        {
            PrintableItems.Add(entity_name, printables);
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

        public DataRow Load(int id)
        {
            DataRow result = Globals.DBCon.SelectOneRow("SELECT * FROM layouts WHERE id = " + id.ToString());

            if (result.ItemArray.Count() > 0)
            {
                Id = (int)result["id"];
                EntityId = (int)result["entity_id"];
                Name = result["name"].ToString();
                Xml = result["xml"].ToString();
                Created = (DateTime)result["created"];
                Updated = Utility.IfDBNull(result["updated"], null);
            }

            return result;
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
            using (BaseDati db = new BaseDati())
            {
                int affetcedRows = 0;
                string sql = "UPDATE layouts SET entity_id=@entity_id, name=@name, xml=@xml, update=@update " +
                            "WHERE id=@id";

                MySqlCommand cmd = db.CreateCommand(sql);
                cmd.Parameters.AddWithValue("@id", (int)Id);
                cmd.Parameters.AddWithValue("@entity_id", (int)EntityId);
                cmd.Parameters.AddWithValue("@name", Name);
                cmd.Parameters.AddWithValue("@xml", Xml);
                cmd.Parameters.AddWithValue("@updated", DateTime.Now);

                affetcedRows = cmd.ExecuteNonQuery();

                return affetcedRows;
            }

        }



        public int Insert()
        {
            using (BaseDati db = new BaseDati())
            {
                int affetcedRows = 0;
                string sql = "INSERT INTO layouts (entity_id, name, xml, created) " +
                            "VALUES (@entity_id, @name, @xml, @created)";

                MySqlCommand cmd = db.CreateCommand(sql);
                cmd.Parameters.AddWithValue("@entity_id", EntityId);
                cmd.Parameters.AddWithValue("@name", Name);
                cmd.Parameters.AddWithValue("@xml", Xml);
                cmd.Parameters.AddWithValue("@created", DateTime.Now);

                affetcedRows = cmd.ExecuteNonQuery();

                return affetcedRows;
            }
        }


        public int Delete()
        {
            using (BaseDati db = new BaseDati())
            {
                int affetcedRows = 0;
                string sql = "DELETE FROM layouts WHERE id=@id";

                MySqlCommand cmd = db.CreateCommand(sql);
                cmd.Parameters.AddWithValue("@id", (int)Id);

                affetcedRows = cmd.ExecuteNonQuery();

                return affetcedRows;
            }
        }


        public DataTable GetLayoutsByEntity()
        {
            string query = "SELECT a.* " +
                "FROM layouts a, entities b " +
                "WHERE a.entity_id = b.id " +
                "AND a.entity_id = " + EntityId +
                " ORDER BY a.created DESC, a.id DESC";

            DataTable result = Globals.DBCon.Execute(query);

            return result;
        }


        static public DataTable GetLayoutsByEntityId(int entity_id)
        {
            string query = "SELECT a.* " +
                "FROM layouts a, entities b " +
                "WHERE a.entity_id = b.id " +
                "AND a.entity_id = " + entity_id +
                " ORDER BY a.created DESC, a.id DESC";

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
