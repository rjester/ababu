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
    public partial class CtrlVisit : UserControl
    {
        
        // @todo: delete me
        // public int Pid { get; set; }
        public Pet P { get; set; }
        public Problem Problem { get; set; }





        public CtrlVisit(Pet pet)
        {
            InitializeComponent();
            P = pet;
            Problem = new Problem(P.Pid, 0);
        }

        private void CtrlVisits_Load(object sender, EventArgs e)
        {
            TslPetName.Text = P.Name + " (" + P.Specie.FamiliarName + ")";

            LoadVisitComponents();
        }

        private void LoadVisitComponents()
        {
            // loading Problem section passing Pet to the user cotrol
            CtrlProblem ctrlProblem = new CtrlProblem(P);
            ctrlProblem.Dock = DockStyle.Fill;
            TlpVisitBodyHead.Controls.Add(ctrlProblem, 0, 0);

            // loading Diary
            CtrlDiary ctrlDiary = new CtrlDiary(P);
            ctrlDiary.Dock = DockStyle.Top;
            // TlpVisitBody.Controls.Add(ctrlDiary, 0, 1);
            TlpVisitBodyHead.Controls.Add(ctrlDiary, 2, 0);

            /*
            CtrlTherapy ctrlTherapy = new CtrlTherapy(P);
            ctrlTherapy.Dock = DockStyle.Fill;
            TlpVisitBodyHead.Controls.Add(ctrlTherapy, 1, 0);
            */

            CtrlPrescription ctrlPrescription = new CtrlPrescription(P);
            ctrlPrescription.Dock = DockStyle.Fill;
            TlpVisitBodyHead.Controls.Add(ctrlPrescription, 1, 0);


            CtrlDiagnosticTest ctrlExamination = new CtrlDiagnosticTest();
            ctrlExamination.Dock = DockStyle.Fill;
            // TlpVisitBody.Controls.Add(ctrlExamination, 1, 1);
            TlpVisitBodyBottom.Controls.Add(ctrlExamination, 0, 0);


            CtrlTherapy ctrlTherapy = new CtrlTherapy(P);
            ctrlTherapy.Dock = DockStyle.Fill;
            TlpVisitBodyBottom.Controls.Add(ctrlTherapy, 1, 0);

            // subriscribe the event handlers
            ctrlProblem.OnProblemSelection += CtrlProblem_OnProblemSelection;
            ctrlProblem.OnProblemSelection += ctrlPrescription.OnProblemSelection;
            ctrlProblem.OnProblemSelection += ctrlDiary.OnProblemSelection;
        }

        private void CtrlProblem_OnProblemSelection(object sender, ProblemEventArgs e)
        {
            this.TstDiagnosisId.Text = e.Problem.DiagnosisId.ToString();
        }
    }
}
