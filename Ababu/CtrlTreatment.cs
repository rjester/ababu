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
    public partial class CtrlTreatment : UserControl
    {
        public Pet Pet { get; set; }

        public CtrlTreatment(Pet pet)
        {
            // set the pet to visit
            Pet = pet; 

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
            CmbProcedures.ValueMember = "id";
            CmbProcedures.DisplayMember = "value";
            CmbProcedures.DataSource = Venom.Search(Venom.PROCEDURE);
            CmbProcedures.SelectedValue = 0;
        }


        private void FillGrid()
        {
            DataTable DtTreatments = Treatment.GetTreatmentsByPetId(Pet.Id);

            GrdTreatments.DataSource = DtTreatments;

            // formatting the result DataGridView
            GrdTreatments.Columns["created"].DisplayIndex = 1;
            GrdTreatments.Columns["created"].DefaultCellStyle.Format = CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;

            GrdTreatments.Columns["id"].Visible = false;
            GrdTreatments.Columns["notes"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GrdTreatments.Columns["recall"].DefaultCellStyle.Format = CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;


        }

        private void Print()
        {
            // create a layout for prescriptiom scope
            Layout layout = new Layout();
            layout.SetScope(new Scope(Scope.SCOPE_TREATMENT));

            // add printable object 
            int id = (int)GrdTreatments.SelectedRows[0].Cells["id"].Value;
            Treatment treatment = new Treatment(id);
            Venom venom = new Venom(treatment.ProcedureId);
            Owner owner = new Owner(Pet.OwnerId);

            layout.AddPrintables("pet", Pet.Printables);
            layout.AddPrintables("treatment", treatment.Printables);
            layout.AddPrintables("venom", venom.Printables);
            layout.AddPrintables("owner", owner.Printables);

            // open print form passing layout to print
            FrmPrint frmPrint = new FrmPrint(layout);
            frmPrint.ShowDialog();
        }


        private void CmbProcedures_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(CmbProcedures.SelectedItem != null && CmbProcedures.SelectedValue != null)
                {
                    int procedure_id = (int)CmbProcedures.SelectedValue;
                    OpenTreatmentEdit(procedure_id);
                }
            }
        }

        private void GrdTreatments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)GrdTreatments.Rows[e.RowIndex].Cells[0].Value;
            int procedure_id = (int)GrdTreatments.Rows[e.RowIndex].Cells[1].Value;

            OpenTreatmentEdit(procedure_id, id);
        }

        private void FrmTreatmentEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            FillGrid();
        }

        private void OpenTreatmentEdit(int procedure_id, int id = 0)
        {
            Treatment treatment = new Treatment(id);
            treatment.PetId = Pet.Id;
            treatment.ProcedureId = procedure_id;

            using (FrmTreatmentEdit frmTreatmentEdit = new FrmTreatmentEdit(treatment))
            {
                frmTreatmentEdit.FormClosed += FrmTreatmentEdit_FormClosed;
                frmTreatmentEdit.ShowDialog();
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            Print();
        }

        private void GrdTreatments_KeyDown(object sender, KeyEventArgs e)
        {
            // F12: print selected row
            if (e.KeyCode == Keys.F12)
            {
                Print();
            }

            // ENTER: open edit form
            if (e.KeyCode == Keys.Enter)
            {
                int id = (int)GrdTreatments.Rows[0].Cells[0].Value;
                int procedure_id = (int)GrdTreatments.Rows[0].Cells[1].Value;

                OpenTreatmentEdit(procedure_id, id);

                // prevent next row
                e.SuppressKeyPress = true;
            }
        }
    }
}
