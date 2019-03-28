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
using System.Globalization;

namespace Ababu
{
    public partial class CtrlPrescription : UserControl
    {
        public Pet Pet { get; set; }
        public Problem Problem { get; set; }
        // public Prescription Prescrizion { get; set; }


        public CtrlPrescription(Pet pet)
        {
            // set the pet to visit
            Pet = pet;
            // initialize an empty problem for the pet
            Problem = new Problem(0, Pet.Id);
            // initialize the rest of the components
            InitializeComponent();
        }

        private void CtrlPrescription_Load(object sender, EventArgs e)
        {
            FillControl();
        }

        
        public void FillControl()
        {
            FillCombo();
            FillGrid();

            // set tooltips for buttons
            ToolTip tip = new ToolTip();
            tip.SetToolTip(BtnSelect, "Enter ...");
            tip.SetToolTip(BtnPrint, "F12 ...");
        }


        private void FillCombo()
        {
            CmbMedicines.ValueMember = "id";
            CmbMedicines.DisplayMember = "value";
            CmbMedicines.DataSource = Medicine.Search();
            CmbMedicines.SelectedValue = 0;
        }


        private void FillGrid()
        {
            DataTable DtPrescriptions = Prescription.GetPrescriptionsByPetId(Pet.Id, Problem.DiagnosisId);
            DtPrescriptions.Columns.Add("in_evidenve_image", typeof(Image));

            for (int j = 0; j < DtPrescriptions.Rows.Count; j++)
            {
                bool in_evidence = (bool)DtPrescriptions.Rows[j]["in_evidence"];


                // Set column image for "in evidence" field
                if (in_evidence == true)
                {
                    DtPrescriptions.Rows[j]["in_evidenve_image"] = (Image)Properties.Resources.bullet_star;
                }
                else
                {
                    DtPrescriptions.Rows[j]["in_evidenve_image"] = (Image)Properties.Resources.bullet_white;
                }
            }


            GrdPrescriptions.DataSource = DtPrescriptions;

            // formmating the datagridview
            GrdPrescriptions.Columns["created"].DefaultCellStyle.Format = CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
            GrdPrescriptions.Columns["created"].DisplayIndex = 0;

            GrdPrescriptions.Columns["id"].Visible = false;
            GrdPrescriptions.Columns["pet_id"].Visible = false;
            GrdPrescriptions.Columns["id"].Visible = false;
            GrdPrescriptions.Columns["in_evidence"].Visible = false;
            GrdPrescriptions.Columns["date_of_issue"].Visible = false;
            GrdPrescriptions.Columns["date_of_withdrawal"].Visible = false;

            GrdPrescriptions.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // enable / disable print button if grid is empty
            if(GrdPrescriptions.Rows.Count > 0)
            {
                BtnPrint.Enabled = true;
            }
            else
            {
                BtnPrint.Enabled = false;
            }
        }



        private void OpenPrescriptionEdit(string medicine_id, int prescription_id = 0)
        {
            using (FrmPrescriptionEdit frmPrescriptionEdit = new FrmPrescriptionEdit(new Prescription(prescription_id), Pet, new Medicine(medicine_id), Problem))
            {
                frmPrescriptionEdit.FormClosing += new FormClosingEventHandler(PrescriptionEdit_FormClosing);
                frmPrescriptionEdit.ShowDialog();
            }
        }



        private void Print()
        {
            // create a layout for prescriptiom scope
            Layout layout = new Layout();
            layout.SetScope(new Scope(Scope.SCOPE_PRESCRIPTION));

            // add printable object 
            int id = (int)GrdPrescriptions.SelectedRows[0].Cells["id"].Value;
            Prescription prescription = new Prescription(id);
            Venom venom = new Venom(prescription.DiagnosisId);
            Owner owner = new Owner(Pet.OwnerId);
            Medicine medicine = new Medicine(prescription.MedicineId);

            layout.AddPrintables("pet", Pet.Printables);
            layout.AddPrintables("prescription", prescription.Printables);
            layout.AddPrintables("owner", owner.Printables);
            layout.AddPrintables("medicine", medicine.Printables);

            // open print form passing layout to print
            FrmPrint frmPrint = new FrmPrint(layout);
            frmPrint.ShowDialog();
        }



        private void CmbMedicines_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (CmbMedicines.SelectedItem != null && CmbMedicines.SelectedValue != null)
                {
                    OpenPrescriptionEdit(CmbMedicines.SelectedValue.ToString());
                }
            }
        }


        private void PrescriptionEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            FillControl();
        }


        private void GrdPrescriptions_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int prescription_id = (int)GrdPrescriptions.Rows[e.RowIndex].Cells[0].Value;
            string medicine_id = GrdPrescriptions.Rows[e.RowIndex].Cells[1].Value.ToString();
            
            OpenPrescriptionEdit(medicine_id, prescription_id);
        }


        // handle the event raised when created this object in Visit and get the problem object 
        public void OnProblemSelection(object sender, ProblemEventArgs e)
        {
            Problem = e.Problem;
            FillGrid();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            Print();
        }

        private void GrdPrescriptions_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F12)
            {
                Print();
            }

            // ENTER: open edit form
            if (e.KeyCode == Keys.Enter)
            {
                int prescription_id = (int)GrdPrescriptions.Rows[0].Cells[0].Value;
                string medicine_id = GrdPrescriptions.Rows[0].Cells[1].Value.ToString();

                OpenPrescriptionEdit(medicine_id, prescription_id);
            }
        }

        private void BtnMedicineSelect_Click(object sender, EventArgs e)
        {
            if (CmbMedicines.SelectedItem != null && CmbMedicines.SelectedValue != null)
            {
                OpenPrescriptionEdit(CmbMedicines.SelectedValue.ToString());
            }
        }
    }
}
