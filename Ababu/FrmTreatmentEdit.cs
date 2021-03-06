﻿using OldAuntie;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ababu
{
    public partial class FrmTreatmentEdit : Form
    {
        public Treatment Treatment { get; set; }
        public Venom Venom { get; set; }


        public FrmTreatmentEdit(Treatment treatment)
        {
            Treatment = treatment;
            Venom = new Venom(treatment.ProcedureId);

            InitializeComponent();
        }

        private void FrmTreatmentEdit_Load(object sender, EventArgs e)
        {
            FillForm();
        }

        private void FillForm()
        {
            TxtProcedureId.Text = Treatment.ProcedureId.ToString();
            TxtProcedureName.Text = Venom.TermName;
            TxtNotes.Text = Treatment.Notes;

            if(Treatment.Recall != null)
            {
                ChkRecall.Checked = true;
                DtpRecall.Value = (DateTime)Treatment.Recall;
            }

        }

        private void Print()
        {
            // create a layout for prescriptiom scope
            Layout layout = new Layout();
            layout.SetScope(new Scope(Scope.SCOPE_TREATMENT));

            // add printable objects 
            Pet pet = new Pet(Treatment.PetId);
            Owner owner = new Owner(pet.OwnerId);

            layout.AddPrintables("pet", pet.Printables);
            layout.AddPrintables("treatment", Treatment.Printables);
            layout.AddPrintables("venom", Venom.Printables);
            layout.AddPrintables("owner", owner.Printables);

            // open print form passing layout to print
            FrmPrint frmPrint = new FrmPrint(layout);
            frmPrint.ShowDialog();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Treatment.Notes = TxtNotes.Text;

            Treatment.Recall = null;
            if (ChkRecall.Checked)
            {
                Treatment.Recall = DtpRecall.Value;
            }

            int affected_rows = Treatment.Save();

            if(affected_rows > 0)
            {
                this.Dispose();
            }
        }

        private void ChkRecall_CheckedChanged(object sender, EventArgs e)
        {
            DtpRecall.Enabled = ChkRecall.Checked;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete selected treatment / procedure (operation cannot be undone) ?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int affected_rows = Treatment.Delete();

                if (affected_rows > 0)
                {
                    this.Close();
                    this.Dispose();
                }
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            Print();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
