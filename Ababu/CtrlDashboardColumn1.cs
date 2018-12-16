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
    public partial class CtrlDashboardColumn1 : UserControl
    {
        public CtrlDashboardColumn1()
        {
            InitializeComponent();
        }

        private void CtrlDashboardColumn1_Load(object sender, EventArgs e)
        {
            FillControl();
        }


        private void FillControl()
        {
            FillRecentVisit();
        }


        private void FillRecentVisit()
        {
            GrdRecentVisit.DataSource = RecentActicity.GetRecentVisits();
        }
        
    }
}
