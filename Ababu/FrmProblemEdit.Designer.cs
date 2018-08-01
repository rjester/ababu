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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProblemEdit));
            this.PicIsModified = new System.Windows.Forms.PictureBox();
            this.BtnProblemDelete = new System.Windows.Forms.Button();
            this.BtnProblemSave = new System.Windows.Forms.Button();
            this.StsProblemEdit = new System.Windows.Forms.StatusStrip();
            this.StlRecordInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.GrbProblemStatus = new System.Windows.Forms.GroupBox();
            this.PicLongTermActive = new System.Windows.Forms.PictureBox();
            this.RadLongTermActive = new System.Windows.Forms.RadioButton();
            this.RadActive = new System.Windows.Forms.RadioButton();
            this.PicActive = new System.Windows.Forms.PictureBox();
            this.PicClosed = new System.Windows.Forms.PictureBox();
            this.RadClosed = new System.Windows.Forms.RadioButton();
            this.PicSuspect = new System.Windows.Forms.PictureBox();
            this.RadSuspect = new System.Windows.Forms.RadioButton();
            this.RadInEvidence = new System.Windows.Forms.RadioButton();
            this.PicInEvidence = new System.Windows.Forms.PictureBox();
            this.TxtSubjectiveAnalysis = new System.Windows.Forms.TextBox();
            this.LblSubjectiveAnalysis = new System.Windows.Forms.Label();
            this.TxtObjectiveAnalysis = new System.Windows.Forms.TextBox();
            this.LblObjectiveAnalysis = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GrbEssential = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ChkEssential = new System.Windows.Forms.CheckBox();
            this.DtpActiveFrom = new System.Windows.Forms.DateTimePicker();
            this.LblActiveFrom = new System.Windows.Forms.Label();
            this.LblAge = new System.Windows.Forms.Label();
            this.TxtAge = new System.Windows.Forms.TextBox();
            this.CmbProblem = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicIsModified)).BeginInit();
            this.StsProblemEdit.SuspendLayout();
            this.GrbProblemStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLongTermActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicClosed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSuspect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicInEvidence)).BeginInit();
            this.GrbEssential.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // RadLongTermActive
            // 
            this.RadLongTermActive.AutoSize = true;
            this.RadLongTermActive.Location = new System.Drawing.Point(44, 44);
            this.RadLongTermActive.Name = "RadLongTermActive";
            this.RadLongTermActive.Size = new System.Drawing.Size(109, 17);
            this.RadLongTermActive.TabIndex = 5;
            this.RadLongTermActive.TabStop = true;
            this.RadLongTermActive.Text = "Long Term Active";
            this.RadLongTermActive.UseVisualStyleBackColor = true;
            // 
            // RadActive
            // 
            this.RadActive.AutoSize = true;
            this.RadActive.Location = new System.Drawing.Point(44, 68);
            this.RadActive.Name = "RadActive";
            this.RadActive.Size = new System.Drawing.Size(118, 17);
            this.RadActive.TabIndex = 1;
            this.RadActive.TabStop = true;
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
            // RadClosed
            // 
            this.RadClosed.AutoSize = true;
            this.RadClosed.Location = new System.Drawing.Point(44, 92);
            this.RadClosed.Name = "RadClosed";
            this.RadClosed.Size = new System.Drawing.Size(57, 17);
            this.RadClosed.TabIndex = 2;
            this.RadClosed.TabStop = true;
            this.RadClosed.Text = "Closed";
            this.RadClosed.UseVisualStyleBackColor = true;
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
            // RadSuspect
            // 
            this.RadSuspect.AutoSize = true;
            this.RadSuspect.Location = new System.Drawing.Point(44, 116);
            this.RadSuspect.Name = "RadSuspect";
            this.RadSuspect.Size = new System.Drawing.Size(64, 17);
            this.RadSuspect.TabIndex = 3;
            this.RadSuspect.TabStop = true;
            this.RadSuspect.Text = "Suspect";
            this.RadSuspect.UseVisualStyleBackColor = true;
            // 
            // RadInEvidence
            // 
            this.RadInEvidence.AutoSize = true;
            this.RadInEvidence.Location = new System.Drawing.Point(44, 20);
            this.RadInEvidence.Name = "RadInEvidence";
            this.RadInEvidence.Size = new System.Drawing.Size(82, 17);
            this.RadInEvidence.TabIndex = 4;
            this.RadInEvidence.TabStop = true;
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
            this.TxtObjectiveAnalysis.Location = new System.Drawing.Point(209, 192);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(209, 303);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(464, 86);
            this.textBox1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Objective Analysis";
            // 
            // GrbEssential
            // 
            this.GrbEssential.Controls.Add(this.ChkEssential);
            this.GrbEssential.Controls.Add(this.pictureBox1);
            this.GrbEssential.Location = new System.Drawing.Point(12, 176);
            this.GrbEssential.Name = "GrbEssential";
            this.GrbEssential.Size = new System.Drawing.Size(188, 62);
            this.GrbEssential.TabIndex = 2;
            this.GrbEssential.TabStop = false;
            this.GrbEssential.Text = "Essential";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::Ababu.Properties.Resources.lightbulb;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(21, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(17, 18);
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // ChkEssential
            // 
            this.ChkEssential.AutoSize = true;
            this.ChkEssential.Location = new System.Drawing.Point(44, 20);
            this.ChkEssential.Name = "ChkEssential";
            this.ChkEssential.Size = new System.Drawing.Size(78, 17);
            this.ChkEssential.TabIndex = 1;
            this.ChkEssential.Text = "Is essential";
            this.ChkEssential.UseVisualStyleBackColor = true;
            // 
            // DtpActiveFrom
            // 
            this.DtpActiveFrom.CustomFormat = "dd/MM/yyyy";
            this.DtpActiveFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpActiveFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpActiveFrom.Location = new System.Drawing.Point(209, 28);
            this.DtpActiveFrom.Name = "DtpActiveFrom";
            this.DtpActiveFrom.Size = new System.Drawing.Size(116, 22);
            this.DtpActiveFrom.TabIndex = 7;
            this.DtpActiveFrom.Value = new System.DateTime(2018, 4, 21, 0, 0, 0, 0);
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
            this.LblAge.Location = new System.Drawing.Point(343, 9);
            this.LblAge.Name = "LblAge";
            this.LblAge.Size = new System.Drawing.Size(33, 16);
            this.LblAge.TabIndex = 57;
            this.LblAge.Text = "Age";
            // 
            // TxtAge
            // 
            this.TxtAge.Location = new System.Drawing.Point(343, 29);
            this.TxtAge.Name = "TxtAge";
            this.TxtAge.ReadOnly = true;
            this.TxtAge.Size = new System.Drawing.Size(47, 20);
            this.TxtAge.TabIndex = 56;
            this.TxtAge.TabStop = false;
            // 
            // CmbProblem
            // 
            this.CmbProblem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbProblem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbProblem.FormattingEnabled = true;
            this.CmbProblem.Location = new System.Drawing.Point(427, 28);
            this.CmbProblem.Name = "CmbProblem";
            this.CmbProblem.Size = new System.Drawing.Size(246, 21);
            this.CmbProblem.TabIndex = 13;
            // 
            // FrmProblemEdit
            // 
            this.AcceptButton = this.BtnProblemSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CmbProblem);
            this.Controls.Add(this.TxtAge);
            this.Controls.Add(this.LblAge);
            this.Controls.Add(this.DtpActiveFrom);
            this.Controls.Add(this.LblActiveFrom);
            this.Controls.Add(this.GrbEssential);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblObjectiveAnalysis);
            this.Controls.Add(this.LblSubjectiveAnalysis);
            this.Controls.Add(this.textBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.PicIsModified)).EndInit();
            this.StsProblemEdit.ResumeLayout(false);
            this.StsProblemEdit.PerformLayout();
            this.GrbProblemStatus.ResumeLayout(false);
            this.GrbProblemStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLongTermActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicClosed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSuspect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicInEvidence)).EndInit();
            this.GrbEssential.ResumeLayout(false);
            this.GrbEssential.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GrbEssential;
        private System.Windows.Forms.CheckBox ChkEssential;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker DtpActiveFrom;
        private System.Windows.Forms.Label LblActiveFrom;
        private System.Windows.Forms.Label LblAge;
        private System.Windows.Forms.TextBox TxtAge;
        private System.Windows.Forms.ComboBox CmbProblem;
    }
}