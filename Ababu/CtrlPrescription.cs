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
            CmbMedicines.DataSource = Medicine.Search();
            
            CmbMedicines.ValueMember = "mid";
            CmbMedicines.DisplayMember = "value";
            CmbMedicines.SelectedValue = 0;


        }

        private void CmbMedicines_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (CmbMedicines.SelectedItem != null && CmbMedicines.SelectedValue != null)
                {
                    OpenPrescriptionEdit(CmbMedicines.SelectedValue.ToString(), P.Pid);
                }
            }
        }


        private void OpenPrescriptionEdit(string mid, int pid)
        {
            FrmPrescriptionEdit frmPrescriptionEdit = new FrmPrescriptionEdit(mid, pid);
            frmPrescriptionEdit.FormClosing += new FormClosingEventHandler(PrescriptionEdit_FormClosing);
            frmPrescriptionEdit.ShowDialog();
        }


        private void PrescriptionEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            FillControl();
        }
    }
}
