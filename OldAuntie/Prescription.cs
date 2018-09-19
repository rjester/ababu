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
        public int PrescriptionId { get; set; }
        public int DiagnosisId { get; set; }
        public string Mid { get; set; }
        public int Pid { get; set; }
        public int Quantity { get; set; }
        public string Dosage { get; set; }
        public bool InEvidence { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }

        public Prescription(int prescription_id)
        {
            Load(prescription_id);
        }

        
        public Prescription Load(int prescription_id)
        {
            string query = "SELECT * FROM prescriptions a, medicines b " +
                    "WHERE a.mid = b.mid " +
                    "AND a.prescription_id = " + prescription_id;


            DataRow result = Globals.DBCon.SelectOneRow(query);

            if (result != null && result.ItemArray.Count() > 0)
            {
                    PrescriptionId = prescription_id;
                    DiagnosisId = (int)result["diagnosis_id"];
                    Mid = result["mid"].ToString();
                    Pid = (int)result["pid"];
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


        public int Update()
        {
            int affetcedRows = 0;

            string query = "UPDATE prescriptions  SET " +
                                    "diagnosis_id=@diagnosis_id, " +
                                    "mid=@mid, " +
                                    "pid=@pid, " +
                                    "quantity=@quantity, " +
                                    "dosage=@dosage, " +
                                    "in_evidence=@in_evidence, " +
                                    "created=@created, " +
                                    "updated=@updated " +
                                "WHERE prescription_id=@prescription_id";


            MySqlCommand Cmd = Globals.DBCon.CreateCommand(query);
            Cmd.Parameters.AddWithValue("@prescription_id", PrescriptionId);
            Cmd.Parameters.AddWithValue("@diagnosis_id", DiagnosisId);
            Cmd.Parameters.AddWithValue("@mid", Mid);
            Cmd.Parameters.AddWithValue("@pid", Pid);
            Cmd.Parameters.AddWithValue("@quantity", Quantity);
            Cmd.Parameters.AddWithValue("@dosage", Dosage);
            Cmd.Parameters.AddWithValue("@in_evidence", InEvidence);
            Cmd.Parameters.AddWithValue("@created", Created);
            Cmd.Parameters.AddWithValue("@updated", DateTime.Now);

            affetcedRows = Cmd.ExecuteNonQuery();

            return affetcedRows;
        }


        public int Insert()
        {
            int affetcedRows = 0;

            string query = "INSERT into prescriptions (diagnosis_id, mid, pid, quantity, dosage, in_evidence, created) " +
                        "VALUES (@diagnosis_id, @mid, @pid, @quantity, @dosage, @in_evidence, @created)";

            MySqlCommand Cmd = Globals.DBCon.CreateCommand(query);
            Cmd.Parameters.AddWithValue("@diagnosis_id", DiagnosisId);
            Cmd.Parameters.AddWithValue("@mid", Mid);
            Cmd.Parameters.AddWithValue("@pid", Pid);
            Cmd.Parameters.AddWithValue("@quantity", Quantity);
            Cmd.Parameters.AddWithValue("@dosage", Dosage);
            Cmd.Parameters.AddWithValue("@in_evidence", InEvidence);
            Cmd.Parameters.AddWithValue("@created", DateTime.Now);

            affetcedRows = Cmd.ExecuteNonQuery();

            return affetcedRows;
        }


        public int Delete()
        {
            int affetcedRows = 0;
            string query = "DELETE FROM prescriptions WHERE prescription_id=@prescription_id";

            MySqlCommand Cmd = Globals.DBCon.CreateCommand(query);
            Cmd.Parameters.AddWithValue("@prescription_id", PrescriptionId);
            
            affetcedRows = Cmd.ExecuteNonQuery();

            return affetcedRows;
        }


        // @todo: delete me
        /*
        public bool Exists_OLD()
        {
            bool result = true;

            string query = "SELECT count(*) FROM prescriptions " +
                    "WHERE created = @created " +
                    "AND pid = @pid " +
                    "AND mid = @mid";

            MySqlCommand Cmd = Globals.DBCon.CreateCommand(query);
            Cmd.Parameters.AddWithValue("@created", Created);
            Cmd.Parameters.AddWithValue("@mid", Mid);
            Cmd.Parameters.AddWithValue("@pid", Pid);

            object r = Cmd.ExecuteScalar();
            if (r != null)
            {
                result = Convert.ToBoolean(r);
            }

            return result;
        }
        */


        public bool Exists()
        {
            if(PrescriptionId > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

            // @todo: delete me when you think this not useful anymore
            /*
            string query = "SELECT prescription_id FROM prescriptions " +
                    "WHERE created = '" + Created.ToString(BaseDati.DATETIME_FORMAT) + "' " +
                    "AND pid = " + Pid + " " +
                    "AND mid = '" + Mid + "'";

            return Globals.DBCon.Exists(query);
            */
        }





        static public DataTable GetPrescriptionsByPid(int pid, int diagnosis_id = 0)
        {
            string query = "SELECT a.prescription_id, a.mid, a.pid, b.name, b.date_of_issue, b.date_of_withdrawal, a.quantity, a.dosage, a.in_evidence, a.created " +
                "FROM prescriptions a, medicines b " +
                "WHERE a.mid = b.mid " +
                "AND a.pid = " + pid;

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
            int affetcedRows = 0;
            string query = "UPDATE prescriptions SET diagnosis_id = 0 WHERE diagnosis_id=@diagnosis_id";
            MySqlCommand Cmd = Globals.DBCon.CreateCommand(query);
            Cmd.Parameters.AddWithValue("@diagnosis_id", diagnosis_id);
            affetcedRows = Cmd.ExecuteNonQuery();

            return affetcedRows;
        }

    }
}
