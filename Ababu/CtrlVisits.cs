using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OldAuntie;

namespace Ababu
{
    public partial class CtrlVisits : UserControl
    {
        public CtrlVisits()
        {
            InitializeComponent();
        }

        private void CtrlVisits_Load(object sender, EventArgs e)
        {
            LoadVisitList();
        }

        private void LoadVisitList()
        {



            DataTable VisitList = Visit.GetVisitsList();

            GrdVisitsList.DataSource = VisitList;



            foreach(DataRow row in VisitList.Rows)
            {
                Visit v = new Visit((int)row[0]);
                CtrlVisitListItem ctrlVisitListItem = new CtrlVisitListItem(v);
                FlowVisitList.Controls.Add(ctrlVisitListItem);
            }







        }
    }
}
