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
    public partial class CtrlRecentActivity : UserControl
    {
        public CtrlRecentActivity()
        {
            InitializeComponent();
        }

        private void CtrlRecentActivity_Load(object sender, EventArgs e)
        {
            FillControl();
        }

        private void FillControl()
        {
            GrdRecentVisit.DataSource = RecentActicity.GetRecentVisits();
        }
    }
}
