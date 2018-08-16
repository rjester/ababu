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
    public partial class CtrlNote : UserControl
    {
        public Note N;

        public CtrlNote(Note note)
        {
            N = note;

            InitializeComponent();
        }

        private void TxtNote_TextChanged(object sender, EventArgs e)
        {
            // @todo: delete me
            /*
            Size size = TextRenderer.MeasureText(this.TxtNote.Text, this.TxtNote.Font);
            this.TxtNote.Width = size.Width;
            this.TxtNote.Height = size.Height;
            this.Height = this.TxtNote.Height + 9;
            */
            int textLength = ((TextBox)(sender)).Text.Length;
            int textLines = ((TextBox)(sender)).GetLineFromCharIndex(textLength) + 1;
            int Margin = ((TextBox)(sender)).Bounds.Height - ((TextBox)(sender)).ClientSize.Height;
            ((TextBox)(sender)).Height = (TextRenderer.MeasureText(this.TxtNote.Text, this.TxtNote.Font).Height * textLines) + Margin + 2;


            this.Height = this.TxtNote.Height + 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.TxtNote.Height.ToString());
        }

        private void TxtNote_Enter(object sender, EventArgs e)
        {
            // this.TxtNote.ReadOnly = false;
        }

        private void TxtNote_Leave(object sender, EventArgs e)
        {
            this.TxtNote.ReadOnly = true;
        }

        private void TxtNote_DoubleClick(object sender, EventArgs e)
        {
            this.TxtNote.ReadOnly = false;
        }

        private void CtrlNote_Load(object sender, EventArgs e)
        {
            FillControl();
        }


        private void FillControl()
        {
            if (N.Nid > 0)
            {
                TxtDate.Text = Utility.UnixTimeStampToDateTime(N.Created).ToString("dd/MM/yyyy");
                TxtNote.Text = N.NoteText;
            }
            else
            {
                TxtDate.Text = Utility.UnixTimeStampToDateTime(Utility.Now()).ToString("dd/MM/yyyy");
                TxtNote.ReadOnly = false;
            }
        }

        private void TxtNote_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("premuto Enter");
            }
        }
    }
}
