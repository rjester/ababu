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
    public partial class CtrlDiary : UserControl
    {
        public Pet P { get; set; }

        public CtrlDiary(Pet pet)
        {
            P = pet;

            InitializeComponent();
        }

        private void CtrlDiary_Load(object sender, EventArgs e)
        {

            CtrlNote ctrlNoteNew = new CtrlNote(new Note());
            FlowDiary.Controls.Add(ctrlNoteNew);

            DataTable DtNotes = Note.GetNotesByPid(P.Pid);

            for (int j = 0; j < DtNotes.Rows.Count; j++)
            {
                int nid = (int)DtNotes.Rows[j]["nid"];
                CtrlNote ctrlNote = new CtrlNote(new Note(nid));

                FlowDiary.Controls.Add(ctrlNote);

            }

        }
    }
}
