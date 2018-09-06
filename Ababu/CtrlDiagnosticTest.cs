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
    public partial class CtrlDiagnosticTest : UserControl
    {
        public Pet Pet { get; set; }

        public CtrlDiagnosticTest()
        {
            InitializeComponent();
        }

        private void CtrlDiagnosticTest_Load(object sender, EventArgs e)
        {
            FillCombo();
        }

        private void FillCombo()
        {
            CmbDiagnosticTest.DataSource = Venom.Search(Venom.DIAGNOSTIC_TEST);
            CmbDiagnosticTest.ValueMember = "id";
            CmbDiagnosticTest.DisplayMember = "value";
            CmbDiagnosticTest.SelectedValue = 0;
        }


        private void FillGrid()
        {
            
        }
    }
}
