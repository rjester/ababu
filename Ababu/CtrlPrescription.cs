﻿using System;
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


        private void OpenPrescriptionEdit(string id, int prescription_id = 0)
        {
            using (FrmPrescriptionEdit frmPrescriptionEdit = new FrmPrescriptionEdit(new Prescription(prescription_id), Pet, new Medicine(id), Problem))
            {
                frmPrescriptionEdit.FormClosing += new FormClosingEventHandler(PrescriptionEdit_FormClosing);
                frmPrescriptionEdit.ShowDialog();
            }
        }


        private void PrescriptionEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            FillControl();
        }


        private void GrdPrescriptions_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // DateTime created = (DateTime)GrdPrescriptions.Rows[e.RowIndex].Cells[0].Value;
            int prescription_id = (int)GrdPrescriptions.Rows[e.RowIndex].Cells[0].Value;
            string id = GrdPrescriptions.Rows[e.RowIndex].Cells[1].Value.ToString();
            
            OpenPrescriptionEdit(id, prescription_id);
        }


        // handle the event raised when created this object in Visit and get the problem object 
        public void OnProblemSelection(object sender, ProblemEventArgs e)
        {
            Problem = e.Problem;
            FillGrid();
        }
    }
}
