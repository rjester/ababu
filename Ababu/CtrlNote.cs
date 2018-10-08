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
        public static event EventHandler NoteChanged;

        public CtrlNote(Note note)
        {
            N = note;
            InitializeComponent();
        }


        private void CtrlNote_Load(object sender, EventArgs e)
        {
            FillControl();
        }


        private void TxtNote_TextChanged(object sender, EventArgs e)
        {
            int textLength = ((TextBox)(sender)).Text.Length;
            int textLines = ((TextBox)(sender)).GetLineFromCharIndex(textLength) + 1;
            int Margin = ((TextBox)(sender)).Bounds.Height - ((TextBox)(sender)).ClientSize.Height;

            ((TextBox)(sender)).Height = (TextRenderer.MeasureText(this.TxtNote.Text, this.TxtNote.Font).Height * textLines) + Margin + 24;
            
            this.Height = this.TxtNote.Height;
        }
        

        private void TxtNote_Enter(object sender, EventArgs e)
        {
            // this.TxtNote.ReadOnly = false;
        }


        private void TxtNote_Leave(object sender, EventArgs e)
        {
            if(N.Nid > 0){
                TxtNote.ReadOnly = true;
                TxtNote.BackColor = Color.Cornsilk;
            }
        }


        private void TxtNote_DoubleClick(object sender, EventArgs e)
        {
            this.TxtNote.ReadOnly = false;
            TxtNote.BackColor = Color.White;
        }


        private void FillControl()
        {
            if (N.Nid > 0)
            {
                DtpDate.Value = Utility.UnixTimeStampToDateTime(N.Created);
                TxtNote.Text = N.NoteText;
                BtnNoteDelete.Enabled = true;

                TxtNote.BackColor = Color.Cornsilk;

            }
            else
            {
                DtpDate.Value = Utility.UnixTimeStampToDateTime(Utility.Now());
                TxtNote.ReadOnly = false;
            }

        }

        private void TxtNote_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                // Utility.d("nanna !!!");
                NoteSave();
                e.SuppressKeyPress = true;
                // TxtNote.Text = TxtNote.Text.Substring(0, TxtNote.Text.Length - 1);
                // BtnNoteSave_Click(this, new EventArgs());
            }
        }

        private void BtnNoteSave_Click(object sender, EventArgs e)
        {
            NoteSave();
        }


        private void NoteSave()
        {
            N.NoteText = TxtNote.Text;
            N.Uid = Globals.Me.Id;
            if (IsValidForm())
            {
                try
                {
                    int affected_id = N.Save();
                    if (affected_id > 0)
                    {
                        OnNoteChanged(EventArgs.Empty);

                        this.TxtNote.ReadOnly = true;
                    }
                }
                catch (Exception ex)
                {
                    Globals.log.Write(ex.ToString());
                }
            }
        }



        private bool IsValidForm()
        {
            bool result = true;
            ErrNoteEdit.Clear();

            if (TxtNote.Text == "")
            {
                result = result & false;
                ErrNoteEdit.SetError(TxtNote, "Note text cannot be empty");
            }
            
            return result;
        }


        protected virtual void OnNoteChanged(EventArgs e)
        {
            EventHandler handler = NoteChanged;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void BtnNoteDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete this note ?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int affected_rows = N.Delete();
                if(affected_rows > 0)
                {
                    OnNoteChanged(EventArgs.Empty);
                    FillControl();
                }
            }
        }
    }
}
