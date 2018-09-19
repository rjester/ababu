namespace Ababu
{
    partial class FrmProblemEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProblemEdit));
            this.StsProblemEdit = new System.Windows.Forms.StatusStrip();
            this.StlRecordInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.GrbProblemStatus = new System.Windows.Forms.GroupBox();
            this.RadInEvidence = new System.Windows.Forms.RadioButton();
            this.PicInEvidence = new System.Windows.Forms.PictureBox();
            this.RadSuspect = new System.Windows.Forms.RadioButton();
            this.PicSuspect = new System.Windows.Forms.PictureBox();
            this.RadClosed = new System.Windows.Forms.RadioButton();
            this.PicClosed = new System.Windows.Forms.PictureBox();
            this.RadActive = new System.Windows.Forms.RadioButton();
            this.PicActive = new System.Windows.Forms.PictureBox();
            this.RadLongTermActive = new System.Windows.Forms.RadioButton();
            this.PicLongTermActive = new System.Windows.Forms.PictureBox();
            this.TxtSubjectiveAnalysis = new System.Windows.Forms.TextBox();
            this.LblSubjectiveAnalysis = new System.Windows.Forms.Label();
            this.TxtObjectiveAnalysis = new System.Windows.Forms.TextBox();
            this.LblObjectiveAnalysis = new System.Windows.Forms.Label();
            this.TxtNotes = new System.Windows.Forms.TextBox();
            this.LblNotes = new System.Windows.Forms.Label();
            this.GrbKeyProblem = new System.Windows.Forms.GroupBox();
            this.ChkKeyProblem = new System.Windows.Forms.CheckBox();
            this.PicKeyProblem = new System.Windows.Forms.PictureBox();
            this.DtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.LblActiveFrom = new System.Windows.Forms.Label();
            this.LblAge = new System.Windows.Forms.Label();
            this.TxtAge = new System.Windows.Forms.TextBox();
            this.ErrProblemEdit = new System.Windows.Forms.ErrorProvider(this.components);
            this.TxtDiagnosisId = new System.Windows.Forms.TextBox();
            this.TxtPid = new System.Windows.Forms.TextBox();
            this.GrbPetDetail = new System.Windows.Forms.GroupBox();
            this.TxtDateOfBirth = new System.Windows.Forms.TextBox();
            this.LblDateOfBirth = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPetMonths = new System.Windows.Forms.TextBox();
            this.LblPetMonths = new System.Windows.Forms.Label();
            this.TxtPetYears = new System.Windows.Forms.TextBox();
            this.TxtPetSpecie = new System.Windows.Forms.TextBox();
            this.TxtPetName = new System.Windows.Forms.TextBox();
            this.LblPetYears = new System.Windows.Forms.Label();
            this.LblPetSpecie = new System.Windows.Forms.Label();
            this.LblPetName = new System.Windows.Forms.Label();
            this.TxtDiagnosis = new System.Windows.Forms.TextBox();
            this.LblDiagnosis = new System.Windows.Forms.Label();
            this.BtnProblemSave = new System.Windows.Forms.Button();
            this.BtnProblemDelete = new System.Windows.Forms.Button();
            this.PicIsModified = new System.Windows.Forms.PictureBox();
            this.StsProblemEdit.SuspendLayout();
            this.GrbProblemStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicInEvidence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSuspect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicClosed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLongTermActive)).BeginInit();
            this.GrbKeyProblem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicKeyProblem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrProblemEdit)).BeginInit();
            this.GrbPetDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicIsModified)).BeginInit();
            this.SuspendLayout();
            // 
            // StsProblemEdit
            // 
            this.StsProblemEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StlRecordInfo});
            this.StsProblemEdit.Location = new System.Drawing.Point(0, 428);
            this.StsProblemEdit.Name = "StsProblemEdit";
            this.StsProblemEdit.Size = new System.Drawing.Size(800, 22);
            this.StsProblemEdit.TabIndex = 50;
            this.StsProblemEdit.Text = "statusStrip1";
            // 
            // StlRecordInfo
            // 
            this.StlRecordInfo.Name = "StlRecordInfo";
            this.StlRecordInfo.Size = new System.Drawing.Size(23, 17);
            this.StlRecordInfo.Text = "Tss";
            // 
            // GrbProblemStatus
            // 
            this.GrbProblemStatus.Controls.Add(this.RadInEvidence);
            this.GrbProblemStatus.Controls.Add(this.PicInEvidence);
            this.GrbProblemStatus.Controls.Add(this.RadSuspect);
            this.GrbProblemStatus.Controls.Add(this.PicSuspect);
            this.GrbProblemStatus.Controls.Add(this.RadClosed);
            this.GrbProblemStatus.Controls.Add(this.PicClosed);
            this.GrbProblemStatus.Controls.Add(this.RadActive);
            this.GrbProblemStatus.Controls.Add(this.PicActive);
            this.GrbProblemStatus.Controls.Add(this.RadLongTermActive);
            this.GrbProblemStatus.Controls.Add(this.PicLongTermActive);
            this.GrbProblemStatus.Location = new System.Drawing.Point(12, 12);
            this.GrbProblemStatus.Name = "GrbProblemStatus";
            this.GrbProblemStatus.Size = new System.Drawing.Size(188, 158);
            this.GrbProblemStatus.TabIndex = 0;
            this.GrbProblemStatus.TabStop = false;
            this.GrbProblemStatus.Text = "Problem Status";
            // 
            // RadInEvidence
            // 
            this.RadInEvidence.AutoSize = true;
            this.RadInEvidence.Location = new System.Drawing.Point(44, 20);
            this.RadInEvidence.Name = "RadInEvidence";
            this.RadInEvidence.Size = new System.Drawing.Size(82, 17);
            this.RadInEvidence.TabIndex = 4;
            this.RadInEvidence.Tag = "3";
            this.RadInEvidence.Text = "In Evidence";
            this.RadInEvidence.UseVisualStyleBackColor = true;
            // 
            // PicInEvidence
            // 
            this.PicInEvidence.ErrorImage = null;
            this.PicInEvidence.Image = global::Ababu.Properties.Resources.star;
            this.PicInEvidence.InitialImage = null;
            this.PicInEvidence.Location = new System.Drawing.Point(21, 20);
            this.PicInEvidence.Name = "PicInEvidence";
            this.PicInEvidence.Size = new System.Drawing.Size(17, 18);
            this.PicInEvidence.TabIndex = 56;
            this.PicInEvidence.TabStop = false;
            // 
            // RadSuspect
            // 
            this.RadSuspect.AutoSize = true;
            this.RadSuspect.Location = new System.Drawing.Point(44, 116);
            this.RadSuspect.Name = "RadSuspect";
            this.RadSuspect.Size = new System.Drawing.Size(64, 17);
            this.RadSuspect.TabIndex = 3;
            this.RadSuspect.Tag = "-1";
            this.RadSuspect.Text = "Suspect";
            this.RadSuspect.UseVisualStyleBackColor = true;
            // 
            // PicSuspect
            // 
            this.PicSuspect.ErrorImage = null;
            this.PicSuspect.Image = global::Ababu.Properties.Resources.brick_edit;
            this.PicSuspect.InitialImage = null;
            this.PicSuspect.Location = new System.Drawing.Point(21, 116);
            this.PicSuspect.Name = "PicSuspect";
            this.PicSuspect.Size = new System.Drawing.Size(17, 18);
            this.PicSuspect.TabIndex = 54;
            this.PicSuspect.TabStop = false;
            // 
            // RadClosed
            // 
            this.RadClosed.AutoSize = true;
            this.RadClosed.Location = new System.Drawing.Point(44, 92);
            this.RadClosed.Name = "RadClosed";
            this.RadClosed.Size = new System.Drawing.Size(57, 17);
            this.RadClosed.TabIndex = 2;
            this.RadClosed.Tag = "0";
            this.RadClosed.Text = "Closed";
            this.RadClosed.UseVisualStyleBackColor = true;
            // 
            // PicClosed
            // 
            this.PicClosed.ErrorImage = null;
            this.PicClosed.Image = global::Ababu.Properties.Resources.lock_closed;
            this.PicClosed.InitialImage = null;
            this.PicClosed.Location = new System.Drawing.Point(21, 92);
            this.PicClosed.Name = "PicClosed";
            this.PicClosed.Size = new System.Drawing.Size(17, 18);
            this.PicClosed.TabIndex = 54;
            this.PicClosed.TabStop = false;
            // 
            // RadActive
            // 
            this.RadActive.AutoSize = true;
            this.RadActive.Checked = true;
            this.RadActive.Location = new System.Drawing.Point(44, 68);
            this.RadActive.Name = "RadActive";
            this.RadActive.Size = new System.Drawing.Size(118, 17);
            this.RadActive.TabIndex = 1;
            this.RadActive.TabStop = true;
            this.RadActive.Tag = "1";
            this.RadActive.Text = "Active / In progress";
            this.RadActive.UseVisualStyleBackColor = true;
            // 
            // PicActive
            // 
            this.PicActive.ErrorImage = null;
            this.PicActive.Image = global::Ababu.Properties.Resources.bullet_arrow_up;
            this.PicActive.InitialImage = null;
            this.PicActive.Location = new System.Drawing.Point(21, 68);
            this.PicActive.Name = "PicActive";
            this.PicActive.Size = new System.Drawing.Size(17, 18);
            this.PicActive.TabIndex = 54;
            this.PicActive.TabStop = false;
            // 
            // RadLongTermActive
            // 
            this.RadLongTermActive.AutoSize = true;
            this.RadLongTermActive.Location = new System.Drawing.Point(44, 44);
            this.RadLongTermActive.Name = "RadLongTermActive";
            this.RadLongTermActive.Size = new System.Drawing.Size(109, 17);
            this.RadLongTermActive.TabIndex = 5;
            this.RadLongTermActive.Tag = "2";
            this.RadLongTermActive.Text = "Long Term Active";
            this.RadLongTermActive.UseVisualStyleBackColor = true;
            // 
            // PicLongTermActive
            // 
            this.PicLongTermActive.ErrorImage = null;
            this.PicLongTermActive.Image = global::Ababu.Properties.Resources.hourglass;
            this.PicLongTermActive.InitialImage = null;
            this.PicLongTermActive.Location = new System.Drawing.Point(21, 44);
            this.PicLongTermActive.Name = "PicLongTermActive";
            this.PicLongTermActive.Size = new System.Drawing.Size(17, 18);
            this.PicLongTermActive.TabIndex = 52;
            this.PicLongTermActive.TabStop = false;
            // 
            // TxtSubjectiveAnalysis
            // 
            this.TxtSubjectiveAnalysis.Location = new System.Drawing.Point(209, 79);
            this.TxtSubjectiveAnalysis.Multiline = true;
            this.TxtSubjectiveAnalysis.Name = "TxtSubjectiveAnalysis";
            this.TxtSubjectiveAnalysis.Size = new System.Drawing.Size(464, 86);
            this.TxtSubjectiveAnalysis.TabIndex = 8;
            // 
            // LblSubjectiveAnalysis
            // 
            this.LblSubjectiveAnalysis.AutoSize = true;
            this.LblSubjectiveAnalysis.Location = new System.Drawing.Point(206, 60);
            this.LblSubjectiveAnalysis.Name = "LblSubjectiveAnalysis";
            this.LblSubjectiveAnalysis.Size = new System.Drawing.Size(98, 13);
            this.LblSubjectiveAnalysis.TabIndex = 53;
            this.LblSubjectiveAnalysis.Text = "Subjective Analysis";
            // 
            // TxtObjectiveAnalysis
            // 
            this.TxtObjectiveAnalysis.Location = new System.Drawing.Point(209, 194);
            this.TxtObjectiveAnalysis.Multiline = true;
            this.TxtObjectiveAnalysis.Name = "TxtObjectiveAnalysis";
            this.TxtObjectiveAnalysis.Size = new System.Drawing.Size(464, 86);
            this.TxtObjectiveAnalysis.TabIndex = 9;
            // 
            // LblObjectiveAnalysis
            // 
            this.LblObjectiveAnalysis.AutoSize = true;
            this.LblObjectiveAnalysis.Location = new System.Drawing.Point(206, 176);
            this.LblObjectiveAnalysis.Name = "LblObjectiveAnalysis";
            this.LblObjectiveAnalysis.Size = new System.Drawing.Size(93, 13);
            this.LblObjectiveAnalysis.TabIndex = 53;
            this.LblObjectiveAnalysis.Text = "Objective Analysis";
            // 
            // TxtNotes
            // 
            this.TxtNotes.Location = new System.Drawing.Point(209, 303);
            this.TxtNotes.Multiline = true;
            this.TxtNotes.Name = "TxtNotes";
            this.TxtNotes.Size = new System.Drawing.Size(464, 86);
            this.TxtNotes.TabIndex = 10;
            // 
            // LblNotes
            // 
            this.LblNotes.AutoSize = true;
            this.LblNotes.Location = new System.Drawing.Point(206, 287);
            this.LblNotes.Name = "LblNotes";
            this.LblNotes.Size = new System.Drawing.Size(35, 13);
            this.LblNotes.TabIndex = 53;
            this.LblNotes.Text = "Notes";
            // 
            // GrbKeyProblem
            // 
            this.GrbKeyProblem.Controls.Add(this.ChkKeyProblem);
            this.GrbKeyProblem.Controls.Add(this.PicKeyProblem);
            this.GrbKeyProblem.Location = new System.Drawing.Point(12, 176);
            this.GrbKeyProblem.Name = "GrbKeyProblem";
            this.GrbKeyProblem.Size = new System.Drawing.Size(188, 52);
            this.GrbKeyProblem.TabIndex = 2;
            this.GrbKeyProblem.TabStop = false;
            this.GrbKeyProblem.Text = "Key Problem";
            // 
            // ChkKeyProblem
            // 
            this.ChkKeyProblem.AutoSize = true;
            this.ChkKeyProblem.Location = new System.Drawing.Point(44, 20);
            this.ChkKeyProblem.Name = "ChkKeyProblem";
            this.ChkKeyProblem.Size = new System.Drawing.Size(85, 17);
            this.ChkKeyProblem.TabIndex = 1;
            this.ChkKeyProblem.Text = "Key Problem";
            this.ChkKeyProblem.UseVisualStyleBackColor = true;
            // 
            // PicKeyProblem
            // 
            this.PicKeyProblem.ErrorImage = null;
            this.PicKeyProblem.Image = global::Ababu.Properties.Resources.key;
            this.PicKeyProblem.InitialImage = null;
            this.PicKeyProblem.Location = new System.Drawing.Point(21, 19);
            this.PicKeyProblem.Name = "PicKeyProblem";
            this.PicKeyProblem.Size = new System.Drawing.Size(17, 18);
            this.PicKeyProblem.TabIndex = 56;
            this.PicKeyProblem.TabStop = false;
            // 
            // DtpDateFrom
            // 
            this.DtpDateFrom.CustomFormat = "dd/MM/yyyy";
            this.DtpDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDateFrom.Location = new System.Drawing.Point(209, 28);
            this.DtpDateFrom.Name = "DtpDateFrom";
            this.DtpDateFrom.Size = new System.Drawing.Size(116, 22);
            this.DtpDateFrom.TabIndex = 7;
            this.DtpDateFrom.Value = new System.DateTime(2018, 4, 21, 0, 0, 0, 0);
            this.DtpDateFrom.ValueChanged += new System.EventHandler(this.DtpDateFrom_ValueChanged);
            // 
            // LblActiveFrom
            // 
            this.LblActiveFrom.AutoSize = true;
            this.LblActiveFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblActiveFrom.Location = new System.Drawing.Point(206, 9);
            this.LblActiveFrom.Name = "LblActiveFrom";
            this.LblActiveFrom.Size = new System.Drawing.Size(79, 16);
            this.LblActiveFrom.TabIndex = 56;
            this.LblActiveFrom.Text = "Active From";
            // 
            // LblAge
            // 
            this.LblAge.AutoSize = true;
            this.LblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAge.Location = new System.Drawing.Point(351, 9);
            this.LblAge.Name = "LblAge";
            this.LblAge.Size = new System.Drawing.Size(47, 16);
            this.LblAge.TabIndex = 57;
            this.LblAge.Text = "At age";
            // 
            // TxtAge
            // 
            this.TxtAge.Location = new System.Drawing.Point(351, 29);
            this.TxtAge.Name = "TxtAge";
            this.TxtAge.ReadOnly = true;
            this.TxtAge.Size = new System.Drawing.Size(47, 20);
            this.TxtAge.TabIndex = 56;
            this.TxtAge.TabStop = false;
            // 
            // ErrProblemEdit
            // 
            this.ErrProblemEdit.ContainerControl = this;
            // 
            // TxtDiagnosisId
            // 
            this.TxtDiagnosisId.Location = new System.Drawing.Point(427, 29);
            this.TxtDiagnosisId.Name = "TxtDiagnosisId";
            this.TxtDiagnosisId.ReadOnly = true;
            this.TxtDiagnosisId.Size = new System.Drawing.Size(41, 20);
            this.TxtDiagnosisId.TabIndex = 58;
            this.TxtDiagnosisId.TabStop = false;
            // 
            // TxtPid
            // 
            this.TxtPid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPid.Location = new System.Drawing.Point(47, 28);
            this.TxtPid.Name = "TxtPid";
            this.TxtPid.ReadOnly = true;
            this.TxtPid.Size = new System.Drawing.Size(80, 13);
            this.TxtPid.TabIndex = 59;
            this.TxtPid.TabStop = false;
            // 
            // GrbPetDetail
            // 
            this.GrbPetDetail.Controls.Add(this.TxtDateOfBirth);
            this.GrbPetDetail.Controls.Add(this.LblDateOfBirth);
            this.GrbPetDetail.Controls.Add(this.label1);
            this.GrbPetDetail.Controls.Add(this.TxtPetMonths);
            this.GrbPetDetail.Controls.Add(this.LblPetMonths);
            this.GrbPetDetail.Controls.Add(this.TxtPetYears);
            this.GrbPetDetail.Controls.Add(this.TxtPid);
            this.GrbPetDetail.Controls.Add(this.TxtPetSpecie);
            this.GrbPetDetail.Controls.Add(this.TxtPetName);
            this.GrbPetDetail.Controls.Add(this.LblPetYears);
            this.GrbPetDetail.Controls.Add(this.LblPetSpecie);
            this.GrbPetDetail.Controls.Add(this.LblPetName);
            this.GrbPetDetail.Location = new System.Drawing.Point(12, 234);
            this.GrbPetDetail.Name = "GrbPetDetail";
            this.GrbPetDetail.Size = new System.Drawing.Size(188, 158);
            this.GrbPetDetail.TabIndex = 57;
            this.GrbPetDetail.TabStop = false;
            this.GrbPetDetail.Text = "Pet detail";
            // 
            // TxtDateOfBirth
            // 
            this.TxtDateOfBirth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDateOfBirth.Location = new System.Drawing.Point(78, 91);
            this.TxtDateOfBirth.Name = "TxtDateOfBirth";
            this.TxtDateOfBirth.ReadOnly = true;
            this.TxtDateOfBirth.Size = new System.Drawing.Size(103, 13);
            this.TxtDateOfBirth.TabIndex = 62;
            // 
            // LblDateOfBirth
            // 
            this.LblDateOfBirth.AutoSize = true;
            this.LblDateOfBirth.Location = new System.Drawing.Point(7, 91);
            this.LblDateOfBirth.Name = "LblDateOfBirth";
            this.LblDateOfBirth.Size = new System.Drawing.Size(68, 13);
            this.LblDateOfBirth.TabIndex = 61;
            this.LblDateOfBirth.Text = "Date of birth:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "Pet Id: ";
            // 
            // TxtPetMonths
            // 
            this.TxtPetMonths.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPetMonths.Location = new System.Drawing.Point(124, 113);
            this.TxtPetMonths.Name = "TxtPetMonths";
            this.TxtPetMonths.ReadOnly = true;
            this.TxtPetMonths.Size = new System.Drawing.Size(23, 13);
            this.TxtPetMonths.TabIndex = 7;
            // 
            // LblPetMonths
            // 
            this.LblPetMonths.AutoSize = true;
            this.LblPetMonths.Location = new System.Drawing.Point(73, 113);
            this.LblPetMonths.Name = "LblPetMonths";
            this.LblPetMonths.Size = new System.Drawing.Size(45, 13);
            this.LblPetMonths.TabIndex = 6;
            this.LblPetMonths.Text = "Months:";
            // 
            // TxtPetYears
            // 
            this.TxtPetYears.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPetYears.Location = new System.Drawing.Point(47, 113);
            this.TxtPetYears.Name = "TxtPetYears";
            this.TxtPetYears.ReadOnly = true;
            this.TxtPetYears.Size = new System.Drawing.Size(23, 13);
            this.TxtPetYears.TabIndex = 5;
            // 
            // TxtPetSpecie
            // 
            this.TxtPetSpecie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPetSpecie.Location = new System.Drawing.Point(47, 68);
            this.TxtPetSpecie.Name = "TxtPetSpecie";
            this.TxtPetSpecie.ReadOnly = true;
            this.TxtPetSpecie.Size = new System.Drawing.Size(140, 13);
            this.TxtPetSpecie.TabIndex = 4;
            // 
            // TxtPetName
            // 
            this.TxtPetName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPetName.Location = new System.Drawing.Point(47, 48);
            this.TxtPetName.Name = "TxtPetName";
            this.TxtPetName.ReadOnly = true;
            this.TxtPetName.Size = new System.Drawing.Size(134, 13);
            this.TxtPetName.TabIndex = 3;
            // 
            // LblPetYears
            // 
            this.LblPetYears.AutoSize = true;
            this.LblPetYears.Location = new System.Drawing.Point(7, 113);
            this.LblPetYears.Name = "LblPetYears";
            this.LblPetYears.Size = new System.Drawing.Size(37, 13);
            this.LblPetYears.TabIndex = 2;
            this.LblPetYears.Text = "Years:";
            // 
            // LblPetSpecie
            // 
            this.LblPetSpecie.AutoSize = true;
            this.LblPetSpecie.Location = new System.Drawing.Point(7, 68);
            this.LblPetSpecie.Name = "LblPetSpecie";
            this.LblPetSpecie.Size = new System.Drawing.Size(40, 13);
            this.LblPetSpecie.TabIndex = 1;
            this.LblPetSpecie.Text = "Specie";
            // 
            // LblPetName
            // 
            this.LblPetName.AutoSize = true;
            this.LblPetName.Location = new System.Drawing.Point(7, 48);
            this.LblPetName.Name = "LblPetName";
            this.LblPetName.Size = new System.Drawing.Size(41, 13);
            this.LblPetName.TabIndex = 0;
            this.LblPetName.Text = "Name: ";
            // 
            // TxtDiagnosis
            // 
            this.TxtDiagnosis.Location = new System.Drawing.Point(474, 29);
            this.TxtDiagnosis.Name = "TxtDiagnosis";
            this.TxtDiagnosis.ReadOnly = true;
            this.TxtDiagnosis.Size = new System.Drawing.Size(199, 20);
            this.TxtDiagnosis.TabIndex = 60;
            // 
            // LblDiagnosis
            // 
            this.LblDiagnosis.AutoSize = true;
            this.LblDiagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDiagnosis.Location = new System.Drawing.Point(427, 9);
            this.LblDiagnosis.Name = "LblDiagnosis";
            this.LblDiagnosis.Size = new System.Drawing.Size(59, 16);
            this.LblDiagnosis.TabIndex = 61;
            this.LblDiagnosis.Text = "Problem";
            // 
            // BtnProblemSave
            // 
            this.BtnProblemSave.Image = global::Ababu.Properties.Resources.accept;
            this.BtnProblemSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnProblemSave.Location = new System.Drawing.Point(351, 402);
            this.BtnProblemSave.Name = "BtnProblemSave";
            this.BtnProblemSave.Size = new System.Drawing.Size(75, 23);
            this.BtnProblemSave.TabIndex = 11;
            this.BtnProblemSave.Text = "Save";
            this.BtnProblemSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProblemSave.UseVisualStyleBackColor = true;
            this.BtnProblemSave.Click += new System.EventHandler(this.BtnProblemSave_Click);
            // 
            // BtnProblemDelete
            // 
            this.BtnProblemDelete.Image = global::Ababu.Properties.Resources.delete;
            this.BtnProblemDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnProblemDelete.Location = new System.Drawing.Point(432, 402);
            this.BtnProblemDelete.Name = "BtnProblemDelete";
            this.BtnProblemDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnProblemDelete.TabIndex = 12;
            this.BtnProblemDelete.Text = "Delete";
            this.BtnProblemDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProblemDelete.UseVisualStyleBackColor = true;
            this.BtnProblemDelete.Click += new System.EventHandler(this.BtnProblemDelete_Click);
            // 
            // PicIsModified
            // 
            this.PicIsModified.ErrorImage = null;
            this.PicIsModified.Image = global::Ababu.Properties.Resources.bullet_green;
            this.PicIsModified.InitialImage = null;
            this.PicIsModified.Location = new System.Drawing.Point(741, 12);
            this.PicIsModified.Name = "PicIsModified";
            this.PicIsModified.Size = new System.Drawing.Size(17, 18);
            this.PicIsModified.TabIndex = 2;
            this.PicIsModified.TabStop = false;
            // 
            // FrmProblemEdit
            // 
            this.AcceptButton = this.BtnProblemSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblDiagnosis);
            this.Controls.Add(this.TxtDiagnosis);
            this.Controls.Add(this.GrbPetDetail);
            this.Controls.Add(this.TxtDiagnosisId);
            this.Controls.Add(this.TxtAge);
            this.Controls.Add(this.LblAge);
            this.Controls.Add(this.DtpDateFrom);
            this.Controls.Add(this.LblActiveFrom);
            this.Controls.Add(this.GrbKeyProblem);
            this.Controls.Add(this.LblNotes);
            this.Controls.Add(this.LblObjectiveAnalysis);
            this.Controls.Add(this.LblSubjectiveAnalysis);
            this.Controls.Add(this.TxtNotes);
            this.Controls.Add(this.TxtObjectiveAnalysis);
            this.Controls.Add(this.TxtSubjectiveAnalysis);
            this.Controls.Add(this.GrbProblemStatus);
            this.Controls.Add(this.StsProblemEdit);
            this.Controls.Add(this.BtnProblemDelete);
            this.Controls.Add(this.BtnProblemSave);
            this.Controls.Add(this.PicIsModified);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmProblemEdit";
            this.Text = "Problem Edit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmProblemEdit_FormClosing);
            this.Load += new System.EventHandler(this.FrmProblemEdit_Load);
            this.StsProblemEdit.ResumeLayout(false);
            this.StsProblemEdit.PerformLayout();
            this.GrbProblemStatus.ResumeLayout(false);
            this.GrbProblemStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicInEvidence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSuspect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicClosed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLongTermActive)).EndInit();
            this.GrbKeyProblem.ResumeLayout(false);
            this.GrbKeyProblem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicKeyProblem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrProblemEdit)).EndInit();
            this.GrbPetDetail.ResumeLayout(false);
            this.GrbPetDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicIsModified)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicIsModified;
        private System.Windows.Forms.Button BtnProblemDelete;
        private System.Windows.Forms.Button BtnProblemSave;
        private System.Windows.Forms.StatusStrip StsProblemEdit;
        private System.Windows.Forms.ToolStripStatusLabel StlRecordInfo;
        private System.Windows.Forms.GroupBox GrbProblemStatus;
        private System.Windows.Forms.RadioButton RadActive;
        private System.Windows.Forms.PictureBox PicActive;
        private System.Windows.Forms.RadioButton RadLongTermActive;
        private System.Windows.Forms.PictureBox PicLongTermActive;
        private System.Windows.Forms.RadioButton RadSuspect;
        private System.Windows.Forms.PictureBox PicSuspect;
        private System.Windows.Forms.RadioButton RadClosed;
        private System.Windows.Forms.PictureBox PicClosed;
        private System.Windows.Forms.RadioButton RadInEvidence;
        private System.Windows.Forms.PictureBox PicInEvidence;
        private System.Windows.Forms.TextBox TxtSubjectiveAnalysis;
        private System.Windows.Forms.Label LblSubjectiveAnalysis;
        private System.Windows.Forms.TextBox TxtObjectiveAnalysis;
        private System.Windows.Forms.Label LblObjectiveAnalysis;
        private System.Windows.Forms.TextBox TxtNotes;
        private System.Windows.Forms.Label LblNotes;
        private System.Windows.Forms.GroupBox GrbKeyProblem;
        private System.Windows.Forms.CheckBox ChkKeyProblem;
        private System.Windows.Forms.PictureBox PicKeyProblem;
        private System.Windows.Forms.DateTimePicker DtpDateFrom;
        private System.Windows.Forms.Label LblActiveFrom;
        private System.Windows.Forms.Label LblAge;
        private System.Windows.Forms.TextBox TxtAge;
        private System.Windows.Forms.ErrorProvider ErrProblemEdit;
        private System.Windows.Forms.TextBox TxtDiagnosisId;
        private System.Windows.Forms.TextBox TxtPid;
        private System.Windows.Forms.GroupBox GrbPetDetail;
        private System.Windows.Forms.Label LblPetSpecie;
        private System.Windows.Forms.Label LblPetName;
        private System.Windows.Forms.Label LblPetYears;
        private System.Windows.Forms.TextBox TxtPetName;
        private System.Windows.Forms.TextBox TxtPetSpecie;
        private System.Windows.Forms.TextBox TxtPetYears;
        private System.Windows.Forms.TextBox TxtPetMonths;
        private System.Windows.Forms.Label LblPetMonths;
        private System.Windows.Forms.TextBox TxtDiagnosis;
        private System.Windows.Forms.Label LblDiagnosis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDateOfBirth;
        private System.Windows.Forms.Label LblDateOfBirth;
    }
}