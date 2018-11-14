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
    public partial class CtrlSpecie : UserControl
    {
        public CtrlSpecie()
        {
            InitializeComponent();
        }


        private void CtrlSpecie_Load(object sender, EventArgs e)
        {
            FillControl();
        }


        private void FillControl()
        {
            TxtSpecieFilter.Text = "";
            FillSpecieSelected();
        }



        private void FillSpecieSelected()
        {
            GrdSpecieSelected.DataSource = Specie.List();
            GrdSpecieSelected.Columns["familiar_name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void TxtSpecieFilter_TextChanged(object sender, EventArgs e)
        {
            if(TxtSpecieFilter.Text.Length >= NumStartFronChar.Value)
            {
                GrdSpecieList.DataSource = Specie.GetAllSpecies(TxtSpecieFilter.Text);
            }
            else
            {
                GrdSpecieList.DataSource = null;
            }
        }

        private void NumStartFronChar_ValueChanged(object sender, EventArgs e)
        {
            TxtSpecieFilter.Text = "";
        }


        private void TsbSpecieAdd_Click(object sender, EventArgs e)
        {
            if(GrdSpecieList.SelectedRows.Count > 0)
            {
                try
                {
                    int tsn = (int)GrdSpecieList.SelectedRows[0].Cells["tsn"].Value;
                    Specie specie = new Specie(tsn);
                    specie.CompleteName = GrdSpecieList.SelectedRows[0].Cells["completename"].Value.ToString();

                    FrmSpecieEdit frmSpecieEdit = new FrmSpecieEdit(specie);
                    frmSpecieEdit.FormClosed += FrmSpecieEdit_FormClosed;
                    frmSpecieEdit.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot add selected Specie. View Log file for details on exception.");
                    Globals.Log.Write(ex.ToString());
                }
            }
        }


        private void TsbSpecieRemove_Click(object sender, EventArgs e)
        {
            if (GrdSpecieSelected.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Do you want to delete selected specie ?", "Warning", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        int tsn = (int)GrdSpecieSelected.SelectedRows[0].Cells["tsn"].Value;
                        Specie specie = new Specie(tsn);
                        int affected_rows = specie.Delete();
                        if (affected_rows > 0)
                        {
                            FillSpecieSelected();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Cannot delete selected Specie. Unlink associated Pets first.");
                        Globals.Log.Write(ex.ToString());
                    }
                }
            }
        }

        private void TsbSpecieEdit_Click(object sender, EventArgs e)
        {
            if (GrdSpecieSelected.SelectedRows.Count > 0)
            {
                try
                {
                    int tsn = (int)GrdSpecieSelected.SelectedRows[0].Cells["tsn"].Value;
                    Specie specie = new Specie(tsn);

                    FrmSpecieEdit frmSpecieEdit = new FrmSpecieEdit(specie);
                    frmSpecieEdit.FormClosed += FrmSpecieEdit_FormClosed;
                    frmSpecieEdit.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot edit selected Specie. View Log file for details on exception.");
                    Globals.Log.Write(ex.ToString());
                }
            }
        }

        private void FrmSpecieEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            FillControl();
        }
    }
}
