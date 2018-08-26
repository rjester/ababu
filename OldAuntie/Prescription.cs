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
        public string Mid { get; set; }
        public int Pid { get; set; }
        public int Quantity { get; set; }
        public string Dosage { get; set; }
        public bool InEvidence { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }

        public Prescription(string mid, int pid)
        {
            Load(mid, pid);    
        }


        public Prescription Load(string mid, int pid)
        {
            string query = "SELECT * FROM prescriptions a, medicines b " +
                    "WHERE a.mid = b.mid" +
                    "AND a.pid = " + pid.ToString() + " " +
                    "AND a.diagnosis_id = " + mid.ToString();
            DataRow result = Globals.DBCon.SelectOneRow(query);

            if (result != null && result.ItemArray.Count() > 0)
            {
                Mid = result["mid"].ToString();
                Pid = (int)result["pid"];
                Quantity = (int)result["quantity"];
                Dosage = result["dosage"].ToString();
                InEvidence = (bool)result["in_evidence"];
                Created = (DateTime)result["created"];
                Updated = (DateTime)result["updated"];
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
            // int updated_id = 0;

            string query = "UPDATE prescriptions  SET " +
                                    "quantity=@quantity, " +
                                    "dosage=@dosage, " +
                                    "in_evidence=@in_evidence, " +
                                    "created=@created, " +
                                    "updated=@updated " +
                                "WHERE mid=@mid AND pid=@pid";


            MySqlCommand Cmd = Globals.DBCon.CreateCommand(query);
            Cmd.Parameters.AddWithValue("@mid", Mid);
            Cmd.Parameters.AddWithValue("@pid", Pid);
            Cmd.Parameters.AddWithValue("@quantity", Quantity);
            Cmd.Parameters.AddWithValue("@dosage", Dosage);
            Cmd.Parameters.AddWithValue("@in_evidence", InEvidence);
            Cmd.Parameters.AddWithValue("@created", Created);
            Cmd.Parameters.AddWithValue("@updated", DateTime.Now);

            affetcedRows = Cmd.ExecuteNonQuery();
            /*
            if (affetcedRows > 0)
            {
                updated_id = Pid;
            }
            */
            return affetcedRows;
        }


        public int Insert()
        {
            int affetcedRows = 0;

            string query = "INSERT into prescriptions (mid, pid, quantity, dosage, in_evidence, created) " +
                        "VALUES (@mid, @pid, @quantity, @dosage, @in_evidence, @created)";

            MySqlCommand Cmd = Globals.DBCon.CreateCommand(query);
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
            string query = "DELETE FROM prescriptions WHERE mid=@mid AND pid=@pid";

            MySqlCommand Cmd = Globals.DBCon.CreateCommand(query);
            Cmd.Parameters.AddWithValue("@mid", Mid);
            Cmd.Parameters.AddWithValue("@pid", Pid);

            affetcedRows = Cmd.ExecuteNonQuery();

            return affetcedRows;
        }


        public bool Exists()
        {
            string query = "SELECT mid FROM prescriptions " +
                "WHERE mid = " + Mid + " " +
                "AND pid = " + Pid;

            bool result = Globals.DBCon.Exists(query);

            return result;
        }



        static public DataTable GetPrescriptionByPid(int pid)
        {
            string query = "SELECT a.created, a.mid, a.pid, b.name, b.date_of_issue, b.date_of_withdrawal, a.quantity, a.dosage, a.in_evidence " +
                "FROM prescriptions a, medicines b " +
                "WHERE a.mid = b.mid " +
                "AND a.pid = " + pid + " " +
                "ORDER BY a.created DESC";

            DataTable result = Globals.DBCon.Execute(query);

            return result;
        }


    }
}
