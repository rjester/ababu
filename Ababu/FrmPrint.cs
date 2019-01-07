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

            CmbLayout.DataSource = Layout.GetLayoutsByEntityId(1);
            CmbLayout.DisplayMember = "name";
            CmbLayout.ValueMember = "id";

            // load printer values
            foreach (var item in PrinterSettings.InstalledPrinters)
            {
                CmbPrinter.Items.Add(item.ToString());
            }

            // setup printer settings
            CmbPrinter.SelectedItem = Properties.Settings.Default.default_printer_name;
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            // @delete me. for debug purporse only
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
