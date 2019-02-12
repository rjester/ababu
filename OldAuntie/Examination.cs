﻿using MySql.Data.MySqlClient;
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
        public int Id { get; set; }
        public int DiagnosisId { get; set; }
        public int DiagnosticTestId { get; set; }
        public int PetId { get; set; }
        public string Result { get; set; }
        public string MedicalReport { get; set; }
        public bool IsPathologic { get; set; }
        public bool InEvidence { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }


        public const string PRINTABLE_ENTITY = "examination";
        public DataRow Printables { get; private set; }

        public Examination(int id)
        {
            Load(id);
        }


        public Examination Load(int id)
        {
            string query = "SELECT * FROM examinations a " +
                    "WHERE a.id = " + id;


            DataRow result = Globals.DBCon.SelectOneRow(query);
            
            // set the result into property for further use (printing)
            this.Printables = result;

            if (result != null && result.ItemArray.Count() > 0)
            {
                Id = id;
                DiagnosisId = (int)result["diagnosis_id"];
                DiagnosticTestId = (int)result["diagnostic_test_id"];
                PetId = (int)result["pet_id"];
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

            string query = "UPDATE examinations  SET " +
                                    "diagnosis_id=@diagnosis_id, " +
                                    "diagnostic_test_id=@diagnostic_test_id, " +
                                    "pet_id=@pet_id, " +
                                    "result=@result, " +
                                    "medical_report=@medical_report, " +
                                    "is_pathologic=@is_pathologic, " +
                                    "in_evidence=@in_evidence, " +
                                    "created=@created, " +
                                    "updated=@updated " +
                                "WHERE id=@id";


            MySqlCommand Cmd = Globals.DBCon.CreateCommand(query);
            Cmd.Parameters.AddWithValue("@id", Id);
            Cmd.Parameters.AddWithValue("@diagnosis_id", DiagnosisId);
            Cmd.Parameters.AddWithValue("@diagnostic_test_id", DiagnosticTestId);
            Cmd.Parameters.AddWithValue("@pet_id", PetId);
            Cmd.Parameters.AddWithValue("@result", Result);
            Cmd.Parameters.AddWithValue("@medical_report", MedicalReport);
            Cmd.Parameters.AddWithValue("@is_pathologic", IsPathologic);
            Cmd.Parameters.AddWithValue("@in_evidence", InEvidence);
            Cmd.Parameters.AddWithValue("@created", Created);
            Cmd.Parameters.AddWithValue("@updated", DateTime.Now);

            affected_rows = Cmd.ExecuteNonQuery();

            return affected_rows;
        }


        public int Insert()
        {
            int affected_rows = 0;

            string query = "INSERT INTO examinations (diagnosis_id, diagnostic_test_id, pet_id, result, medical_report, is_pathologic, in_evidence, created) " +
                        "VALUES (@diagnosis_id, @diagnostic_test_id, @pet_id, @result, @medical_report, @is_pathologic, @in_evidence, @created)";

            MySqlCommand Cmd = Globals.DBCon.CreateCommand(query);
            Cmd.Parameters.AddWithValue("@diagnosis_id", DiagnosisId);
            Cmd.Parameters.AddWithValue("@diagnostic_test_id", DiagnosticTestId);
            Cmd.Parameters.AddWithValue("@pet_id", PetId);
            Cmd.Parameters.AddWithValue("@result", Result);
            Cmd.Parameters.AddWithValue("@medical_report", MedicalReport);
            Cmd.Parameters.AddWithValue("@is_pathologic", IsPathologic);
            Cmd.Parameters.AddWithValue("@in_evidence", InEvidence);
            Cmd.Parameters.AddWithValue("@created", DateTime.Now);

            affected_rows = Cmd.ExecuteNonQuery();

            return affected_rows;
        }


        public int Delete()
        {
            int affected_rows = 0;
            string query = "DELETE FROM examinations WHERE id=@id";

            MySqlCommand Cmd = Globals.DBCon.CreateCommand(query);
            Cmd.Parameters.AddWithValue("@id", Id);

            affected_rows = Cmd.ExecuteNonQuery();

            return affected_rows;
        }

        // @todo: to be deleted
        public bool Exists()
        {
            bool result = true;

            string query = "SELECT count(*) FROM examinations " +
                    "WHERE created = @created " +
                    "AND pet_id = @pet_id " +
                    "AND diagnostic_test_id = @diagnostic_test_id";

            MySqlCommand Cmd = Globals.DBCon.CreateCommand(query);
            Cmd.Parameters.AddWithValue("@created", Created);
            Cmd.Parameters.AddWithValue("@diagnostic_test_id", DiagnosticTestId);
            Cmd.Parameters.AddWithValue("@pet_id", PetId);

            object r = Cmd.ExecuteScalar();
            if (r != null)
            {
                result = Convert.ToBoolean(r);
            }

            return result;
        }



        static public DataTable GetExaminationsByPetId(int pet_id, int diagnosis_id = 0)
        {
            string query = "SELECT a.id, a.diagnosis_id, a.diagnostic_test_id, b.term_name, a.result, a.medical_report, a.is_pathologic, a.in_evidence, a.created " +
                "FROM examinations a, venom_codes b " +
                "WHERE a.diagnostic_test_id = b.id " +
                "AND a.pet_id = " + pet_id;

            if (diagnosis_id > 0)
            {
                query += " AND a.diagnosis_id = " + diagnosis_id;
            }
            query += " ORDER BY a.in_evidence DESC, a.created DESC";

            DataTable result = Globals.DBCon.Execute(query);

            return result;
        }



        static public int UnlinkExaminations(int diagnosis_id)
        {
            int affected_rows = 0;
            string query = "UPDATE examinations SET diagnosis_id = 0 WHERE diagnosis_id=@diagnosis_id";
            MySqlCommand Cmd = Globals.DBCon.CreateCommand(query);
            Cmd.Parameters.AddWithValue("@diagnosis_id", diagnosis_id);
            affected_rows = Cmd.ExecuteNonQuery();

            return affected_rows;
        }
    }
}
