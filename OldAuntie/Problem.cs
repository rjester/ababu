using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldAuntie
{
    public class Problem
    {
        public int DiagnosisId { get; set; }
        public int PetId { get; set; }
        public int UserId { get; set; }
        public DateTime? ActiveFrom { get; set; }
        public int StatusId { get; set; }
        public bool KeyProblem { get; set; }
        public string SubjectiveAnalysis { get; set; }
        public string ObjectiveAnalysis { get; set; }
        public string Notes { get; set; }

        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }

        private bool disposed = false;


        public Problem(int diagnosis_id, int pet_id)
        {
               Load(diagnosis_id, pet_id);
        }


        public Problem Load(int diagnosis_id, int pet_id)
        {
            DiagnosisId = diagnosis_id;
            PetId = pet_id;

            string query = "SELECT * FROM problems a, status b " +
                    "WHERE a.status_id = b.id " +
                    "AND a.pet_id = " + pet_id.ToString() + " " +
                    "AND a.diagnosis_id = " + diagnosis_id.ToString();
            DataRow result = Globals.DBCon.SelectOneRow(query);

            if (result != null && result.ItemArray.Count() > 0)
            {
                UserId = (int)result["user_id"];
                ActiveFrom = Utility.IfDBNull(result["active_from"], null);
                StatusId = (int)result["status_id"];
                KeyProblem = (bool)result["key_problem"];
                SubjectiveAnalysis = result["subjective_analysis"].ToString();
                ObjectiveAnalysis = result["objective_analysis"].ToString();
                Notes = result["notes"].ToString();

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
            int affected_rows = 0;

            string query = "UPDATE problems SET " +
                                    "user_id=@user_id, " +
                                    "active_from=@active_from, " +
                                    "status_id=@status_id, " +
                                    "key_problem=@key_problem, " +
                                    "subjective_analysis=@subjective_analysis, " +
                                    "objective_analysis=@objective_analysis, " +
                                    "notes=@notes, " +
                                    "created=@created, " +
                                    "updated=@updated " +
                                "WHERE diagnosis_id=@diagnosis_id AND pet_id=@pet_id";


            MySqlCommand Cmd = Globals.DBCon.CreateCommand(query);
            // primary keys
            Cmd.Parameters.AddWithValue("@diagnosis_id", DiagnosisId);
            Cmd.Parameters.AddWithValue("@pet_id", PetId);
            // other fields
            Cmd.Parameters.AddWithValue("@user_id", UserId);
            Cmd.Parameters.AddWithValue("@active_from", ActiveFrom);
            Cmd.Parameters.AddWithValue("@status_id", StatusId);
            Cmd.Parameters.AddWithValue("@key_problem", KeyProblem);
            Cmd.Parameters.AddWithValue("@subjective_analysis", SubjectiveAnalysis);
            Cmd.Parameters.AddWithValue("@objective_analysis", ObjectiveAnalysis);
            Cmd.Parameters.AddWithValue("@notes", Notes);
            Cmd.Parameters.AddWithValue("@created", Created);
            Cmd.Parameters.AddWithValue("@updated", DateTime.Now);

            affected_rows = Cmd.ExecuteNonQuery();


            return affected_rows;
        }


        public int Insert()
        {
            int affected_rows = 0;
            
            string query = "INSERT into problems (diagnosis_id, pet_id, user_id, active_from, status_id, key_problem, subjective_analysis, objective_analysis, notes, created) " +
                        "VALUES (@diagnosis_id, @pet_id, @user_id, @active_from, @status_id, @key_problem, @subjective_analysis, @objective_analysis, @notes, @created)";

            MySqlCommand Cmd = Globals.DBCon.CreateCommand(query);
            Cmd.Parameters.AddWithValue("@diagnosis_id", DiagnosisId);
            Cmd.Parameters.AddWithValue("@pet_id", PetId);
            Cmd.Parameters.AddWithValue("@user_id", UserId);
            Cmd.Parameters.AddWithValue("@active_from", ActiveFrom);
            Cmd.Parameters.AddWithValue("@status_id", StatusId);
            Cmd.Parameters.AddWithValue("@key_problem", KeyProblem);
            Cmd.Parameters.AddWithValue("@subjective_analysis", SubjectiveAnalysis);
            Cmd.Parameters.AddWithValue("@objective_analysis", ObjectiveAnalysis);
            Cmd.Parameters.AddWithValue("@notes", Notes);
            Cmd.Parameters.AddWithValue("@created", DateTime.Now);

            affected_rows = Cmd.ExecuteNonQuery();

            return affected_rows;
        }


        public int Delete()
        {
            int affected_rows = 0;
            string query = "DELETE FROM problems WHERE diagnosis_id=@diagnosis_id AND pet_id=@pet_id";

            MySqlCommand Cmd = Globals.DBCon.CreateCommand(query);
            Cmd.Parameters.AddWithValue("@diagnosis_id", DiagnosisId);
            Cmd.Parameters.AddWithValue("@pet_id", PetId);

            affected_rows = Cmd.ExecuteNonQuery();

            return affected_rows;
        }


        public bool Exists()
        {
            string query = "SELECT pet_id FROM problems " +
                "WHERE pet_id = " + PetId + " " +
                "AND diagnosis_id = " + DiagnosisId;

            bool result = Globals.DBCon.Exists(query);

            return result;
        }

 
        static public DataTable GetProblemsByPetId(int pet_id)
        {
            string query = "SELECT a.pet_id, a.diagnosis_id, a.status_id, b.term_name, a.key_problem " +
                "FROM problems a, venom_codes b, status c " +
                "WHERE a.diagnosis_id = b.id " +
                "AND a.status_id = c.id " +
                "AND a.pet_id = " + pet_id +" " +
                "ORDER BY a.status_id DESC";

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



    public class ProblemEventArgs : EventArgs
    {
        public Problem Problem { get; private set; }
        public static string Action { get; private set; }

        public const string ACTION_SELECT = "SELECT";
        public const string ACTION_DELETE = "DELETE";

        public ProblemEventArgs(Problem problem, string action = ACTION_SELECT)
        {
            Problem = problem;
            Action = action;
        }
    }
}
