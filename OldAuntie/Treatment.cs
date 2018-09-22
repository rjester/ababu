using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldAuntie
{
    class Treatment
    {
        public int TreatmentId { get; set; }
        public int ProcedureId { get; set; }
        public int Pid { get; set; }
        public string Notes { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Recall { get; set; }
        public DateTime? Updated { get; set; }

        public Treatment(int treatment_id)
        {
            Load(treatment_id);
        }


        public Treatment Load(int treatment_id)
        {
            string query = "";

            DataRow result = Globals.DBCon.SelectOneRow(query);
            if( result != null && result.ItemArray.Count() > 0)
            {
                ProcedureId = (int)result["procedure_id"];
                Pid = (int)result["pid"];
                Notes = result["notes"].ToString();
                Created = (DateTime)result["created"];
                Recall = Utility.IfDBNull(result["recall"], null);
                Updated = Utility.IfDBNull(result["updated"], null);
            }
            return this;
        }


        public int Save()
        {
            if(TreatmentId > 0)
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
            string query = "";


            return affected_rows;
        }


        public int Insert()
        {
            int affected_rows = 0;


            return affected_rows;
        }
    }
}
