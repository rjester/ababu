using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldAuntie
{
    public class Examination
    {
        public int ExaminationId { get; set; }
        public int DiagnosisId { get; set; }
        public int DiagnosticTestId { get; set; }
        public int Pid { get; set; }
        public string Result { get; set; }
        public string MedicalReport { get; set; }
        public bool IsPathologic { get; set; }
        public bool InEvidence { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }


        public Examination(int examination_id)
        {
            Load(examination_id);
        }


        public Examination Load(int examination_id)
        {
            string query = "SELECT * FROM examinations a " +
                    "WHERE a.examination_id = " + examination_id;


            DataRow result = Globals.DBCon.SelectOneRow(query);

            if (result != null && result.ItemArray.Count() > 0)
            {
                ExaminationId = examination_id;
                DiagnosisId = (int)result["diagnosis_id"];
                DiagnosticTestId = (int)result["diagnostic_test_id"];
                Pid = (int)result["pid"];
                Result = result["result"].ToString();
                MedicalReport = result["medical_report"].ToString();
                IsPathologic = (bool)result["is_pathologic"];
                InEvidence = (bool)result["in_evidence"];
                Created = (DateTime)result["created"];
                Updated = Utility.IfDBNull(result["updated"], null);
            }

            return this;
        }


        public int Save()
        {
            if (ExaminationId > 0)
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

            string query = "UPDATE examinations  SET " +
                                    "diagnosis_id=@diagnosis_id, " +
                                    "diagnostic_test_id=@diagnostic_test_id, " +
                                    "pid=@pid, " +
                                    "result=@result, " +
                                    "medical_report=@medical_report, " +
                                    "is_pathologic=@is_pathologic, " +
                                    "in_evidence=@in_evidence, " +
                                    "created=@created, " +
                                    "updated=@updated " +
                                "WHERE examination_id=@examination_id";


            MySqlCommand Cmd = Globals.DBCon.CreateCommand(query);
            Cmd.Parameters.AddWithValue("@examination_id", ExaminationId);
            Cmd.Parameters.AddWithValue("@diagnosis_id", DiagnosisId);
            Cmd.Parameters.AddWithValue("@diagnostic_test_id", DiagnosticTestId);
            Cmd.Parameters.AddWithValue("@pid", Pid);
            Cmd.Parameters.AddWithValue("@result", Result);
            Cmd.Parameters.AddWithValue("@medical_report", MedicalReport);
            Cmd.Parameters.AddWithValue("@is_pathologic", IsPathologic);
            Cmd.Parameters.AddWithValue("@in_evidence", InEvidence);
            Cmd.Parameters.AddWithValue("@created", Created);
            Cmd.Parameters.AddWithValue("@updated", DateTime.Now);

            affetcedRows = Cmd.ExecuteNonQuery();

            return affetcedRows;
        }


        public int Insert()
        {
            int affetcedRows = 0;

            string query = "INSERT into examinations (diagnosis_id, diagnostic_test_id, pid, result, medical_report, is_pathologic, in_evidence, created) " +
                        "VALUES (@diagnosis_id, @diagnostic_test_id, @pid, @result, @medical_report, @is_pathologic, @in_evidence, @created)";

            MySqlCommand Cmd = Globals.DBCon.CreateCommand(query);
            Cmd.Parameters.AddWithValue("@diagnosis_id", DiagnosisId);
            Cmd.Parameters.AddWithValue("@diagnostic_test_id", DiagnosticTestId);
            Cmd.Parameters.AddWithValue("@pid", Pid);
            Cmd.Parameters.AddWithValue("@result", Result);
            Cmd.Parameters.AddWithValue("@medical_report", MedicalReport);
            Cmd.Parameters.AddWithValue("@is_pathologic", IsPathologic);
            Cmd.Parameters.AddWithValue("@in_evidence", InEvidence);
            Cmd.Parameters.AddWithValue("@created", DateTime.Now);

            affetcedRows = Cmd.ExecuteNonQuery();

            return affetcedRows;
        }


        public int Delete()
        {
            int affetcedRows = 0;
            string query = "DELETE FROM examinations WHERE examination_id=@examination_id";

            MySqlCommand Cmd = Globals.DBCon.CreateCommand(query);
            Cmd.Parameters.AddWithValue("@examination_id", ExaminationId);

            affetcedRows = Cmd.ExecuteNonQuery();

            return affetcedRows;
        }


        public bool Exists()
        {
            bool result = true;

            string query = "SELECT count(*) FROM examinations " +
                    "WHERE created = @created " +
                    "AND pid = @pid " +
                    "AND diagnostic_test_id = @diagnostic_test_id";

            MySqlCommand Cmd = Globals.DBCon.CreateCommand(query);
            Cmd.Parameters.AddWithValue("@created", Created);
            Cmd.Parameters.AddWithValue("@diagnostic_test_id", DiagnosticTestId);
            Cmd.Parameters.AddWithValue("@pid", Pid);

            object r = Cmd.ExecuteScalar();
            if (r != null)
            {
                result = Convert.ToBoolean(r);
            }

            return result;
        }



        static public DataTable GetExaminationsByPid(int pid, int diagnosis_id = 0)
        {
            string query = "SELECT a.examination_id, a.diagnosis_id, a.diagnostic_test_id, a.result, a.is_pathologic, a.in_evidence, a.created, b.term_name " +
                "FROM examinations a, venom_codes b " +
                "WHERE a.diagnostic_test_id = b.id " +
                "AND a.pid = " + pid;

            if (diagnosis_id > 0)
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
            string query = "UPDATE examinations SET diagnosis_id = 0 WHERE diagnosis_id=@diagnosis_id";
            MySqlCommand Cmd = Globals.DBCon.CreateCommand(query);
            Cmd.Parameters.AddWithValue("@diagnosis_id", diagnosis_id);
            affetcedRows = Cmd.ExecuteNonQuery();

            return affetcedRows;
        }


    }
}
