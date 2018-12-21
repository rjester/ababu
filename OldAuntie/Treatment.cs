using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldAuntie
{
    public class Treatment
    {
        public int Id { get; set; }
        public int ProcedureId { get; set; }
        public int PetId { get; set; }
        public string Notes { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Recall { get; set; }
        public DateTime? Updated { get; set; }

        public Treatment(int id)
        {
            Load(id);
        }


        public Treatment Load(int id)
        {
            Id = id;
            string query = "SELECT * FROM treatments WHERE id = " + id;

            DataRow result = Globals.DBCon.SelectOneRow(query);
            if( result != null && result.ItemArray.Count() > 0)
            {
                ProcedureId = (int)result["procedure_id"];
                PetId = (int)result["pet_id"];
                Notes = result["notes"].ToString();
                Created = (DateTime)result["created"];
                Recall = Utility.IfDBNull(result["recall"], null);
                Updated = Utility.IfDBNull(result["updated"], null);
            }
            return this;
        }


        public int Save()
        {
            if(Id > 0)
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
            string query = "UPDATE treatments SET " +
                "procedure_id=@procedure_id, " +
                "pet_id=@pet_id, " +
                "notes=@notes, " +
                "created=@created, " +
                "recall=@recall, " +
                "updated=@updated " +
                "WHERE id=@id";

            MySqlCommand Cmd = Globals.DBCon.CreateCommand(query);
            Cmd.Parameters.AddWithValue("@id", Id);
            Cmd.Parameters.AddWithValue("@procedure_id", ProcedureId);
            Cmd.Parameters.AddWithValue("@pet_id", PetId);
            Cmd.Parameters.AddWithValue("@notes", Notes);
            Cmd.Parameters.AddWithValue("@created", Created);
            Cmd.Parameters.AddWithValue("@recall", Recall);
            Cmd.Parameters.AddWithValue("@updated", DateTime.Now);

            affected_rows = Cmd.ExecuteNonQuery();

            return affected_rows;
        }


        public int Insert()
        {
            int affected_rows = 0;
            string query = "INSERT INTO treatments (procedure_id, pet_id, notes, created, recall, updated) " +
                "VALUES (@procedure_id, @pet_id, @notes, @created, @recall, @updated)";

            MySqlCommand Cmd = Globals.DBCon.CreateCommand(query);
            Cmd.Parameters.AddWithValue("@procedure_id", ProcedureId);
            Cmd.Parameters.AddWithValue("@pet_id", PetId);
            Cmd.Parameters.AddWithValue("@notes", Notes);
            Cmd.Parameters.AddWithValue("@created", DateTime.Now);
            Cmd.Parameters.AddWithValue("@recall", Recall);
            Cmd.Parameters.AddWithValue("@updated", DateTime.Now);

            affected_rows = Cmd.ExecuteNonQuery();

            return affected_rows;
        }


        public int Delete()
        {
            int affected_rows = 0;
            string query = "DELETE FROM treatments WHERE id = @id";
            MySqlCommand Cmd = Globals.DBCon.CreateCommand(query);
            Cmd.Parameters.AddWithValue("@id", Id);

            affected_rows = Cmd.ExecuteNonQuery();

            return affected_rows;
        }

        static public DataTable GetTreatmentsByPetId(int pet_id)
        {
            string query = "SELECT a.id, a.procedure_id, b.term_name, a.notes, a.created, a.recall " +
                "FROM treatments a, venom_codes b " +
                "WHERE a.procedure_id = b.id " +
                "AND a.pet_id = " + pet_id + 
                " ORDER BY a.created DESC, a.id DESC";

            DataTable result = Globals.DBCon.Execute(query);

            return result;
        }
    }
}
