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
    public partial class FrmLightbox : Form
    {
        private string Label { get; set; }

        public FrmLightbox(string label)
        {
            Label = label;
            InitializeComponent();
        }

        private void FrmLightbox_Load(object sender, EventArgs e)
        {
            TxtLabel.Text = Label;
        }

        private void TxtLabel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void FrmLightbox_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void FrmLightbox_Deactivate(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
