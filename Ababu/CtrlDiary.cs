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
        public Pet Pet { get; set; }

        public CtrlDiary(Pet pet)
        {
            Pet = pet;

            InitializeComponent();
        }

        private void CtrlDiary_Load(object sender, EventArgs e)
        {
            CtrlNote.NoteChanged += OnNoteChange;
            FillControl();
        }

        private void  OnNoteChange(object sender, EventArgs e)
        {
            FillControl();
        }

        private void FillControl()
        {
            FlowDiary.Controls.Clear();
            
            // create an object and a control for the new note
            Note NewNote = new Note();
            NewNote.Pid = Pet.Id;
            CtrlNote ctrlNoteNew = new CtrlNote(NewNote);
            FlowDiary.Controls.Add(ctrlNoteNew);

            // load all other notes and show their controls
            DataTable DtNotes = Note.GetNotesByPid(Pet.Id);
            for (int j = 0; j < DtNotes.Rows.Count; j++)
            {
                int nid = (int)DtNotes.Rows[j]["id"];
                CtrlNote ctrlNote = new CtrlNote(new Note(nid));
                FlowDiary.Controls.Add(ctrlNote);
            }
        }

        // @todo: edit this
        public void OnProblemSelection(object sender, ProblemEventArgs e)
        {
        }
    }
}
