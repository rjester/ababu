using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldAuntie
{
    public class Prescription
    {
        public int Id { get; set; }
        public string MedicineId { get; set; }
        public int DiagnosisId { get; set; }
        public int PetId { get; set; }
        public int UserId { get; set; }
        public int Quantity { get; set; }
        public string Dosage { get; set; }
        public bool InEvidence { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }

        public const string PRINTABLE_ENTITY = "prescription";
        public DataRow Printables { get; private set; }

        public Prescription(int id)
        {
            Load(id);
        }

        
        public Prescription Load(int id)
        {
            string query = "SELECT * FROM prescriptions a, medicines b " +
                    "WHERE a.medicine_id = b.id " +
                    "AND a.id = " + id;

            DataRow result = Globals.DBCon.SelectOneRow(query);

            // set the result into property for further use (printing)
            this.Printables = result;

            if (result != null && result.ItemArray.Count() > 0)
            {
                Id = id;
                DiagnosisId = (int)result["diagnosis_id"];
                MedicineId = result["medicine_id"].ToString();
                PetId = (int)result["pet_id"];
                UserId = (int)result["user_id"];
                Quantity = (int)result["quantity"];
                Dosage = result["dosage"].ToString();
                InEvidence = (bool)result["in_evidence"];
                Created = (DateTime)result["created"];
                Updated = Utility.IfDBNull(result["updated"], null);
            }

            return this;
        }


        public int Save()
        {
            if (Exists())
            {
                return Update();
            }
            else
            {
                return Insert();
            }
        }


        public bool Exists()
        {
            if (Id > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public int Update()
        {
            int affected_rows = 0;

            string query = "UPDATE prescriptions SET " +
                                    "medicine_id=@medicine_id, " +
                                    "diagnosis_id=@diagnosis_id, " +
                                    "pet_id=@pet_id, " +
                                    "user_id=@user_id, " +
                                    "quantity=@quantity, " +
                                    "dosage=@dosage, " +
                                    "in_evidence=@in_evidence, " +
                                    "created=@created, " +
                                    "updated=@updated " +
                                "WHERE id=@id";


            MySqlCommand Cmd = Globals.DBCon.CreateCommand(query);
            Cmd.Parameters.AddWithValue("@id", Id);
            Cmd.Parameters.AddWithValue("@medicine_id", MedicineId);
            Cmd.Parameters.AddWithValue("@diagnosis_id", DiagnosisId);
            Cmd.Parameters.AddWithValue("@pet_id", PetId);
            Cmd.Parameters.AddWithValue("@user_id", UserId);
            Cmd.Parameters.AddWithValue("@quantity", Quantity);
            Cmd.Parameters.AddWithValue("@dosage", Dosage);
            Cmd.Parameters.AddWithValue("@in_evidence", InEvidence);
            Cmd.Parameters.AddWithValue("@created", Created);
            Cmd.Parameters.AddWithValue("@updated", DateTime.Now);

            affected_rows = Cmd.ExecuteNonQuery();

            return affected_rows;
        }


        public int Insert()
        {
            int affected_rows = 0;

            string query = "INSERT into prescriptions (medicine_id, diagnosis_id, pet_id, quantity, dosage, in_evidence, created) " +
                        "VALUES (@medicine_id, @diagnosis_id, @pet_id, @quantity, @dosage, @in_evidence, @created)";

            MySqlCommand Cmd = Globals.DBCon.CreateCommand(query);
            Cmd.Parameters.AddWithValue("@medicine_id", MedicineId);
            Cmd.Parameters.AddWithValue("@diagnosis_id", DiagnosisId);
            Cmd.Parameters.AddWithValue("@pet_id", PetId);
            Cmd.Parameters.AddWithValue("@quantity", Quantity);
            Cmd.Parameters.AddWithValue("@dosage", Dosage);
            Cmd.Parameters.AddWithValue("@in_evidence", InEvidence);
            Cmd.Parameters.AddWithValue("@created", DateTime.Now);

            affected_rows = Cmd.ExecuteNonQuery();

            return affected_rows;
        }


        public int Delete()
        {
            int affected_rows = 0;
            string query = "DELETE FROM prescriptions WHERE id=@id";

            MySqlCommand Cmd = Globals.DBCon.CreateCommand(query);
            Cmd.Parameters.AddWithValue("@id", Id);

            affected_rows = Cmd.ExecuteNonQuery();

            return affected_rows;
        }

        
        // @todo delete
        public Prescription Print()
        {
            return this;
        }



        static public DataTable GetPrescriptionsByPetId(int pet_id, int diagnosis_id = 0)
        {
            string query = "SELECT a.id, a.medicine_id, a.pet_id, b.name, b.date_of_issue, b.date_of_withdrawal, a.quantity, a.dosage, a.in_evidence, a.created " +
                "FROM prescriptions a, medicines b " +
                "WHERE a.medicine_id = b.id " +
                "AND a.pet_id = " + pet_id;

            if(diagnosis_id > 0)
            {
                query += " AND a.diagnosis_id = " + diagnosis_id;
            }
            query += " ORDER BY a.in_evidence DESC, a.created DESC";

            DataTable result = Globals.DBCon.Execute(query);

            return result;
        }

        static public int UnlinkPrescription(int diagnosis_id)
        {
            int affected_rows = 0;
            string query = "UPDATE prescriptions SET diagnosis_id = 0 WHERE diagnosis_id=@diagnosis_id";
            MySqlCommand Cmd = Globals.DBCon.CreateCommand(query);
            Cmd.Parameters.AddWithValue("@diagnosis_id", diagnosis_id);
            affected_rows = Cmd.ExecuteNonQuery();

            return affected_rows;
        }

    }
}
