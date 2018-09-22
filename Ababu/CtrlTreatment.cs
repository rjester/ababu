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
    public partial class CtrlTreatment : UserControl
    {
        public Pet Pet { get; set; }

        public CtrlTreatment()
        {
            InitializeComponent();
        }

        private void CtrlTreatment_Load(object sender, EventArgs e)
        {
            FillControl();
        }


        public void FillControl()
        {
            FillCombo();
            FillGrid();
        }


        private void FillCombo()
        {
            CmbProcedures.DataSource = Venom.Search(Venom.PROCEDURE);
            CmbProcedures.ValueMember = "id";
            CmbProcedures.DisplayMember = "value";
            CmbProcedures.SelectedValue = 0;
        }


        private void FillGrid()
        {

        }
    }
}
