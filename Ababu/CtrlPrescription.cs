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
    public partial class CtrlPrescription : UserControl
    {
        public Pet P { get; set; }
        public Prescription Prescrizione { get; set; }


        public CtrlPrescription(Pet pet)
        {
            P = pet;
            InitializeComponent();
        }

        private void CtrlPrescription_Load(object sender, EventArgs e)
        {
            FillControl();
        }

        public void FillControl()
        {
            CmbMedicines.DataSource = Prescription.MedicineSearch();
            CmbMedicines.ValueMember = "mid";
            CmbMedicines.DisplayMember = "value";
            CmbMedicines.SelectedValue = 0;


        }
    }
}
