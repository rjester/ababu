using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ababu
{
    public partial class CtrlDashboardColumn2 : UserControl
    {
        public event EventHandler<EventArgs> ActionEvent;

        public CtrlDashboardColumn2()
        {
            InitializeComponent();
        }

        private void CtrlDashboardColumn2_Load(object sender, EventArgs e)
        {
            FillControl();

        }

        private void FillControl()
        {
            CtrlSystemStatus ctrlSystemStatus = new CtrlSystemStatus();
            ctrlSystemStatus.Dock = DockStyle.Fill;
            SpcDashboardColumn2.Panel2.Controls.Add(ctrlSystemStatus);
        }

        private void LblPets_Click(object sender, EventArgs e)
        {
            ActionEvent?.Invoke(sender, e);
        }

        private void LblOwners_Click(object sender, EventArgs e)
        {
            ActionEvent?.Invoke(sender, e);
        }

        private void LblCalendar_Click(object sender, EventArgs e)
        {
            ActionEvent?.Invoke(sender, e);
        }

        private void LblSpecies_Click(object sender, EventArgs e)
        {
            ActionEvent?.Invoke(sender, e);
        }

        private void LblPrecerences_Click(object sender, EventArgs e)
        {
            ActionEvent?.Invoke(sender, e);
        }
    }
}
