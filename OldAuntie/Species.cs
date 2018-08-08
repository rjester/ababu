using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldAuntie
{
    public class Species
    {

        public int Tsn { get; set; }
        public string CompleteName { get; set; }
        public string FamiliarName { get; set; }

        public Species(int tsn = 0)
        {
            if (tsn > 0)
            {
                Load(tsn);
            }
        }


        public Species Load(int tsn)
        {
            if (tsn > 0)
            {
                DataRow result = Globals.DBCon.SelectOneRow("SELECT * FROM species WHERE tsn = " + tsn.ToString());

                if (result != null && result.ItemArray.Count() > 0)
                {
                    Tsn = (int)result["tsn"];
                    CompleteName = result["complete_name"].ToString();
                    FamiliarName = result["familiar_name"].ToString();
                }
            }

            return this;
        }


        public static DataTable List()
        {
            DataTable result = Globals.DBCon.Execute("SELECT tsn, familiar_name FROM species");
            return result;
        }
    }

    
}
