using OldAuntie;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ababu
{
    public partial class FrmPrint : Form
    {
        public Layout Layout { get; set; }
        public Printer Printer { get; set; }

        public FrmPrint(Layout layout = null)
        {
            Layout = layout;
            InitializeComponent();
        }

        private void FrmPrint_Load(object sender, EventArgs e)
        {
            FillForm();
        }

        private void FillForm()
        {
            CmbLayout.DisplayMember = "name";
            CmbLayout.ValueMember = "id";
            CmbLayout.DataSource = Layout.GetAllLayoutsByScope();

            // load printer values
            foreach (var item in PrinterSettings.InstalledPrinters)
            {
                CmbPrinter.Items.Add(item.ToString());
            }

            try
            {
                CmbPrinter.SelectedItem = Properties.Settings.Default.default_printer_name;
                ChkPrinterSetDefault.Checked = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool IsValidForm()
        {
            bool result = true;
            ErrPrint.Clear();

            if (CmbLayout.SelectedItem == null)
            {
                result = result & false;
                ErrPrint.SetError(CmbLayout, "Select a Layout to print");
            }

            if (CmbPrinter.SelectedItem == null)
            {
                result = result & false;
                ErrPrint.SetError(ChkPrinterSetDefault, "Select a Printer to print");
            }

            return result;
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            if (IsValidForm())
            {
                Printer = new Printer(CmbPrinter.SelectedItem.ToString());
                Printer.Print(Layout);

                if (ChkPrinterSetDefault.Checked)
                {
                    Properties.Settings.Default.default_printer_name = CmbPrinter.SelectedItem.ToString();
                    Properties.Settings.Default.Save();
                }

                Close();
            }
            
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CmbLayout_SelectedIndexChanged(object sender, EventArgs e)
        {
            Layout.Load((int)CmbLayout.SelectedValue);
        }

        private void CmbPrinter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChkPrinterSetDefault.Checked = false;
        }
    }
}
