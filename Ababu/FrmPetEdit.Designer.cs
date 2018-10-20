namespace Ababu
{
    partial class FrmPetEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPetEdit));
            this.PicIsModified = new System.Windows.Forms.PictureBox();
            this.LblPetId = new System.Windows.Forms.Label();
            this.TxtPetId = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.CmbSpecies = new System.Windows.Forms.ComboBox();
            this.LblSpecies = new System.Windows.Forms.Label();
            this.CmbGender = new System.Windows.Forms.ComboBox();
            this.LblGender = new System.Windows.Forms.Label();
            this.ErrPetEdit = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnPetSave = new System.Windows.Forms.Button();
            this.LblDescription = new System.Windows.Forms.Label();
            this.LblColor = new System.Windows.Forms.Label();
            this.TxtColor = new System.Windows.Forms.TextBox();
            this.DtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.LblDateOfBirth = new System.Windows.Forms.Label();
            this.DtpDateOfDeath = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.GrbMicrochip = new System.Windows.Forms.GroupBox();
            this.TxtMicrochipLocation = new System.Windows.Forms.TextBox();
            this.LblMicrochipLocation = new System.Windows.Forms.Label();
            this.TxtMicrochip = new System.Windows.Forms.TextBox();
            this.LblMicrochip = new System.Windows.Forms.Label();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.GrbTatuatge = new System.Windows.Forms.GroupBox();
            this.TxtTatuatgeLocation = new System.Windows.Forms.TextBox();
            this.LblTatuatgeLocation = new System.Windows.Forms.Label();
            this.TxtTatuatge = new System.Windows.Forms.TextBox();
            this.LblTatuatge = new System.Windows.Forms.Label();
            this.ChkDateOfDeath = new System.Windows.Forms.CheckBox();
            this.StsPetEdit = new System.Windows.Forms.StatusStrip();
            this.StlRecordInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.CmbOwner = new System.Windows.Forms.ComboBox();
            this.LblOwner = new System.Windows.Forms.Label();
            this.GrbAge = new System.Windows.Forms.GroupBox();
            this.LblDays = new System.Windows.Forms.Label();
            this.LblMonths = new System.Windows.Forms.Label();
            this.LblYears = new System.Windows.Forms.Label();
            this.TxtDays = new System.Windows.Forms.TextBox();
            this.TxtMonths = new System.Windows.Forms.TextBox();
            this.TxtYears = new System.Windows.Forms.TextBox();
            this.BtnPetDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicIsModified)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrPetEdit)).BeginInit();
            this.GrbMicrochip.SuspendLayout();
            this.GrbTatuatge.SuspendLayout();
            this.StsPetEdit.SuspendLayout();
            this.GrbAge.SuspendLayout();
            this.SuspendLayout();
            // 
            // PicIsModified
            // 
            this.PicIsModified.ErrorImage = null;
            this.PicIsModified.Image = global::Ababu.Properties.Resources.bullet_green;
            this.PicIsModified.InitialImage = null;
            this.PicIsModified.Location = new System.Drawing.Point(637, 12);
            this.PicIsModified.Name = "PicIsModified";
            this.PicIsModified.Size = new System.Drawing.Size(17, 18);
            this.PicIsModified.TabIndex = 1;
            this.PicIsModified.TabStop = false;
            // 
            // LblPetId
            // 
            this.LblPetId.AutoSize = true;
            this.LblPetId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPetId.Location = new System.Drawing.Point(662, 15);
            this.LblPetId.Name = "LblPetId";
            this.LblPetId.Size = new System.Drawing.Size(44, 16);
            this.LblPetId.TabIndex = 21;
            this.LblPetId.Text = "Pet ID";
            // 
            // TxtPetId
            // 
            this.TxtPetId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPetId.Location = new System.Drawing.Point(712, 12);
            this.TxtPetId.Name = "TxtPetId";
            this.TxtPetId.ReadOnly = true;
            this.TxtPetId.Size = new System.Drawing.Size(50, 22);
            this.TxtPetId.TabIndex = 0;
            this.TxtPetId.TabStop = false;
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(32, 37);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(373, 22);
            this.TxtName.TabIndex = 0;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(29, 18);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(65, 16);
            this.LblName.TabIndex = 23;
            this.LblName.Text = "Pet name";
            // 
            // CmbSpecies
            // 
            this.CmbSpecies.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CmbSpecies.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbSpecies.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbSpecies.FormattingEnabled = true;
            this.CmbSpecies.Location = new System.Drawing.Point(31, 83);
            this.CmbSpecies.Name = "CmbSpecies";
            this.CmbSpecies.Size = new System.Drawing.Size(373, 24);
            this.CmbSpecies.TabIndex = 1;
            // 
            // LblSpecies
            // 
            this.LblSpecies.AutoSize = true;
            this.LblSpecies.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSpecies.Location = new System.Drawing.Point(29, 62);
            this.LblSpecies.Name = "LblSpecies";
            this.LblSpecies.Size = new System.Drawing.Size(105, 16);
            this.LblSpecies.TabIndex = 24;
            this.LblSpecies.Text = "Species / Breed";
            // 
            // CmbGender
            // 
            this.CmbGender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CmbGender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbGender.FormattingEnabled = true;
            this.CmbGender.Items.AddRange(new object[] {
            "M",
            "F",
            "U"});
            this.CmbGender.Location = new System.Drawing.Point(32, 183);
            this.CmbGender.Name = "CmbGender";
            this.CmbGender.Size = new System.Drawing.Size(164, 24);
            this.CmbGender.TabIndex = 3;
            // 
            // LblGender
            // 
            this.LblGender.AutoSize = true;
            this.LblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGender.Location = new System.Drawing.Point(29, 164);
            this.LblGender.Name = "LblGender";
            this.LblGender.Size = new System.Drawing.Size(53, 16);
            this.LblGender.TabIndex = 27;
            this.LblGender.Text = "Gender";
            // 
            // ErrPetEdit
            // 
            this.ErrPetEdit.ContainerControl = this;
            // 
            // BtnPetSave
            // 
            this.BtnPetSave.Image = global::Ababu.Properties.Resources.accept;
            this.BtnPetSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPetSave.Location = new System.Drawing.Point(442, 402);
            this.BtnPetSave.Name = "BtnPetSave";
            this.BtnPetSave.Size = new System.Drawing.Size(75, 23);
            this.BtnPetSave.TabIndex = 16;
            this.BtnPetSave.Text = "Save";
            this.BtnPetSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPetSave.UseVisualStyleBackColor = true;
            this.BtnPetSave.Click += new System.EventHandler(this.BtnPetSave_Click);
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescription.Location = new System.Drawing.Point(29, 219);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(76, 16);
            this.LblDescription.TabIndex = 30;
            this.LblDescription.Text = "Description";
            // 
            // LblColor
            // 
            this.LblColor.AutoSize = true;
            this.LblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblColor.Location = new System.Drawing.Point(213, 164);
            this.LblColor.Name = "LblColor";
            this.LblColor.Size = new System.Drawing.Size(40, 16);
            this.LblColor.TabIndex = 32;
            this.LblColor.Text = "Color";
            // 
            // TxtColor
            // 
            this.TxtColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtColor.Location = new System.Drawing.Point(216, 183);
            this.TxtColor.Name = "TxtColor";
            this.TxtColor.Size = new System.Drawing.Size(164, 22);
            this.TxtColor.TabIndex = 4;
            // 
            // DtpDateOfBirth
            // 
            this.DtpDateOfBirth.CustomFormat = "dd/MM/yyyy";
            this.DtpDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDateOfBirth.Location = new System.Drawing.Point(15, 41);
            this.DtpDateOfBirth.Name = "DtpDateOfBirth";
            this.DtpDateOfBirth.Size = new System.Drawing.Size(116, 22);
            this.DtpDateOfBirth.TabIndex = 7;
            this.DtpDateOfBirth.Value = new System.DateTime(2018, 4, 21, 0, 0, 0, 0);
            // 
            // LblDateOfBirth
            // 
            this.LblDateOfBirth.AutoSize = true;
            this.LblDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDateOfBirth.Location = new System.Drawing.Point(12, 22);
            this.LblDateOfBirth.Name = "LblDateOfBirth";
            this.LblDateOfBirth.Size = new System.Drawing.Size(79, 16);
            this.LblDateOfBirth.TabIndex = 34;
            this.LblDateOfBirth.Text = "Date of birth";
            // 
            // DtpDateOfDeath
            // 
            this.DtpDateOfDeath.CustomFormat = "dd/MM/yyyy";
            this.DtpDateOfDeath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDateOfDeath.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDateOfDeath.Location = new System.Drawing.Point(152, 41);
            this.DtpDateOfDeath.Name = "DtpDateOfDeath";
            this.DtpDateOfDeath.Size = new System.Drawing.Size(110, 22);
            this.DtpDateOfDeath.TabIndex = 9;
            this.DtpDateOfDeath.Value = new System.DateTime(2018, 4, 21, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Date of death";
            // 
            // GrbMicrochip
            // 
            this.GrbMicrochip.Controls.Add(this.TxtMicrochipLocation);
            this.GrbMicrochip.Controls.Add(this.LblMicrochipLocation);
            this.GrbMicrochip.Controls.Add(this.TxtMicrochip);
            this.GrbMicrochip.Controls.Add(this.LblMicrochip);
            this.GrbMicrochip.Location = new System.Drawing.Point(434, 37);
            this.GrbMicrochip.Name = "GrbMicrochip";
            this.GrbMicrochip.Size = new System.Drawing.Size(344, 121);
            this.GrbMicrochip.TabIndex = 10;
            this.GrbMicrochip.TabStop = false;
            this.GrbMicrochip.Text = "Microchip";
            // 
            // TxtMicrochipLocation
            // 
            this.TxtMicrochipLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMicrochipLocation.Location = new System.Drawing.Point(6, 88);
            this.TxtMicrochipLocation.Name = "TxtMicrochipLocation";
            this.TxtMicrochipLocation.Size = new System.Drawing.Size(327, 22);
            this.TxtMicrochipLocation.TabIndex = 12;
            // 
            // LblMicrochipLocation
            // 
            this.LblMicrochipLocation.AutoSize = true;
            this.LblMicrochipLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMicrochipLocation.Location = new System.Drawing.Point(6, 69);
            this.LblMicrochipLocation.Name = "LblMicrochipLocation";
            this.LblMicrochipLocation.Size = new System.Drawing.Size(116, 16);
            this.LblMicrochipLocation.TabIndex = 41;
            this.LblMicrochipLocation.Text = "Microchip location";
            // 
            // TxtMicrochip
            // 
            this.TxtMicrochip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMicrochip.Location = new System.Drawing.Point(6, 35);
            this.TxtMicrochip.Name = "TxtMicrochip";
            this.TxtMicrochip.Size = new System.Drawing.Size(204, 22);
            this.TxtMicrochip.TabIndex = 11;
            // 
            // LblMicrochip
            // 
            this.LblMicrochip.AutoSize = true;
            this.LblMicrochip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMicrochip.Location = new System.Drawing.Point(6, 16);
            this.LblMicrochip.Name = "LblMicrochip";
            this.LblMicrochip.Size = new System.Drawing.Size(66, 16);
            this.LblMicrochip.TabIndex = 39;
            this.LblMicrochip.Text = "Microchip";
            // 
            // TxtDescription
            // 
            this.TxtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescription.Location = new System.Drawing.Point(32, 238);
            this.TxtDescription.Multiline = true;
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(373, 83);
            this.TxtDescription.TabIndex = 5;
            // 
            // GrbTatuatge
            // 
            this.GrbTatuatge.Controls.Add(this.TxtTatuatgeLocation);
            this.GrbTatuatge.Controls.Add(this.LblTatuatgeLocation);
            this.GrbTatuatge.Controls.Add(this.TxtTatuatge);
            this.GrbTatuatge.Controls.Add(this.LblTatuatge);
            this.GrbTatuatge.Location = new System.Drawing.Point(434, 170);
            this.GrbTatuatge.Name = "GrbTatuatge";
            this.GrbTatuatge.Size = new System.Drawing.Size(344, 121);
            this.GrbTatuatge.TabIndex = 13;
            this.GrbTatuatge.TabStop = false;
            this.GrbTatuatge.Text = "Tatuatge";
            // 
            // TxtTatuatgeLocation
            // 
            this.TxtTatuatgeLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTatuatgeLocation.Location = new System.Drawing.Point(6, 88);
            this.TxtTatuatgeLocation.Name = "TxtTatuatgeLocation";
            this.TxtTatuatgeLocation.Size = new System.Drawing.Size(327, 22);
            this.TxtTatuatgeLocation.TabIndex = 15;
            // 
            // LblTatuatgeLocation
            // 
            this.LblTatuatgeLocation.AutoSize = true;
            this.LblTatuatgeLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTatuatgeLocation.Location = new System.Drawing.Point(6, 69);
            this.LblTatuatgeLocation.Name = "LblTatuatgeLocation";
            this.LblTatuatgeLocation.Size = new System.Drawing.Size(112, 16);
            this.LblTatuatgeLocation.TabIndex = 41;
            this.LblTatuatgeLocation.Text = "Tatuatge location";
            // 
            // TxtTatuatge
            // 
            this.TxtTatuatge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTatuatge.Location = new System.Drawing.Point(6, 35);
            this.TxtTatuatge.Name = "TxtTatuatge";
            this.TxtTatuatge.Size = new System.Drawing.Size(204, 22);
            this.TxtTatuatge.TabIndex = 14;
            // 
            // LblTatuatge
            // 
            this.LblTatuatge.AutoSize = true;
            this.LblTatuatge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTatuatge.Location = new System.Drawing.Point(6, 16);
            this.LblTatuatge.Name = "LblTatuatge";
            this.LblTatuatge.Size = new System.Drawing.Size(62, 16);
            this.LblTatuatge.TabIndex = 39;
            this.LblTatuatge.Text = "Tatuatge";
            // 
            // ChkDateOfDeath
            // 
            this.ChkDateOfDeath.AutoSize = true;
            this.ChkDateOfDeath.Location = new System.Drawing.Point(244, 20);
            this.ChkDateOfDeath.Name = "ChkDateOfDeath";
            this.ChkDateOfDeath.Size = new System.Drawing.Size(15, 14);
            this.ChkDateOfDeath.TabIndex = 8;
            this.ChkDateOfDeath.UseVisualStyleBackColor = true;
            this.ChkDateOfDeath.CheckedChanged += new System.EventHandler(this.ChkDateOfDeath_CheckedChanged);
            // 
            // StsPetEdit
            // 
            this.StsPetEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StlRecordInfo});
            this.StsPetEdit.Location = new System.Drawing.Point(0, 428);
            this.StsPetEdit.Name = "StsPetEdit";
            this.StsPetEdit.Size = new System.Drawing.Size(800, 22);
            this.StsPetEdit.TabIndex = 45;
            this.StsPetEdit.Text = "statusStrip1";
            // 
            // StlRecordInfo
            // 
            this.StlRecordInfo.Name = "StlRecordInfo";
            this.StlRecordInfo.Size = new System.Drawing.Size(23, 17);
            this.StlRecordInfo.Text = "Tss";
            // 
            // CmbOwner
            // 
            this.CmbOwner.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CmbOwner.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbOwner.FormattingEnabled = true;
            this.CmbOwner.Location = new System.Drawing.Point(32, 134);
            this.CmbOwner.Name = "CmbOwner";
            this.CmbOwner.Size = new System.Drawing.Size(373, 24);
            this.CmbOwner.TabIndex = 2;
            // 
            // LblOwner
            // 
            this.LblOwner.AutoSize = true;
            this.LblOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOwner.Location = new System.Drawing.Point(30, 113);
            this.LblOwner.Name = "LblOwner";
            this.LblOwner.Size = new System.Drawing.Size(46, 16);
            this.LblOwner.TabIndex = 46;
            this.LblOwner.Text = "Owner";
            // 
            // GrbAge
            // 
            this.GrbAge.Controls.Add(this.LblDays);
            this.GrbAge.Controls.Add(this.LblMonths);
            this.GrbAge.Controls.Add(this.LblYears);
            this.GrbAge.Controls.Add(this.TxtDays);
            this.GrbAge.Controls.Add(this.TxtMonths);
            this.GrbAge.Controls.Add(this.TxtYears);
            this.GrbAge.Controls.Add(this.DtpDateOfDeath);
            this.GrbAge.Controls.Add(this.DtpDateOfBirth);
            this.GrbAge.Controls.Add(this.LblDateOfBirth);
            this.GrbAge.Controls.Add(this.label1);
            this.GrbAge.Controls.Add(this.ChkDateOfDeath);
            this.GrbAge.Location = new System.Drawing.Point(33, 326);
            this.GrbAge.Name = "GrbAge";
            this.GrbAge.Size = new System.Drawing.Size(403, 76);
            this.GrbAge.TabIndex = 6;
            this.GrbAge.TabStop = false;
            this.GrbAge.Text = "Age";
            // 
            // LblDays
            // 
            this.LblDays.AutoSize = true;
            this.LblDays.Location = new System.Drawing.Point(346, 20);
            this.LblDays.Name = "LblDays";
            this.LblDays.Size = new System.Drawing.Size(31, 13);
            this.LblDays.TabIndex = 50;
            this.LblDays.Text = "Days";
            // 
            // LblMonths
            // 
            this.LblMonths.AutoSize = true;
            this.LblMonths.Location = new System.Drawing.Point(315, 21);
            this.LblMonths.Name = "LblMonths";
            this.LblMonths.Size = new System.Drawing.Size(33, 13);
            this.LblMonths.TabIndex = 49;
            this.LblMonths.Text = "Mnts.";
            // 
            // LblYears
            // 
            this.LblYears.AutoSize = true;
            this.LblYears.Location = new System.Drawing.Point(287, 20);
            this.LblYears.Name = "LblYears";
            this.LblYears.Size = new System.Drawing.Size(25, 13);
            this.LblYears.TabIndex = 48;
            this.LblYears.Text = "Yrs.";
            // 
            // TxtDays
            // 
            this.TxtDays.Location = new System.Drawing.Point(349, 41);
            this.TxtDays.Name = "TxtDays";
            this.TxtDays.ReadOnly = true;
            this.TxtDays.Size = new System.Drawing.Size(25, 20);
            this.TxtDays.TabIndex = 0;
            this.TxtDays.TabStop = false;
            // 
            // TxtMonths
            // 
            this.TxtMonths.Location = new System.Drawing.Point(318, 41);
            this.TxtMonths.Name = "TxtMonths";
            this.TxtMonths.ReadOnly = true;
            this.TxtMonths.Size = new System.Drawing.Size(25, 20);
            this.TxtMonths.TabIndex = 0;
            this.TxtMonths.TabStop = false;
            // 
            // TxtYears
            // 
            this.TxtYears.Location = new System.Drawing.Point(287, 41);
            this.TxtYears.Name = "TxtYears";
            this.TxtYears.ReadOnly = true;
            this.TxtYears.Size = new System.Drawing.Size(25, 20);
            this.TxtYears.TabIndex = 0;
            this.TxtYears.TabStop = false;
            // 
            // BtnPetDelete
            // 
            this.BtnPetDelete.Image = global::Ababu.Properties.Resources.delete;
            this.BtnPetDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPetDelete.Location = new System.Drawing.Point(523, 402);
            this.BtnPetDelete.Name = "BtnPetDelete";
            this.BtnPetDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnPetDelete.TabIndex = 47;
            this.BtnPetDelete.Text = "Delete";
            this.BtnPetDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPetDelete.UseVisualStyleBackColor = true;
            this.BtnPetDelete.Click += new System.EventHandler(this.BtnPetDelete_Click);
            // 
            // FrmPetEdit
            // 
            this.AcceptButton = this.BtnPetSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnPetDelete);
            this.Controls.Add(this.GrbAge);
            this.Controls.Add(this.CmbOwner);
            this.Controls.Add(this.LblOwner);
            this.Controls.Add(this.StsPetEdit);
            this.Controls.Add(this.GrbTatuatge);
            this.Controls.Add(this.GrbMicrochip);
            this.Controls.Add(this.LblColor);
            this.Controls.Add(this.TxtColor);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.TxtDescription);
            this.Controls.Add(this.BtnPetSave);
            this.Controls.Add(this.LblGender);
            this.Controls.Add(this.CmbGender);
            this.Controls.Add(this.CmbSpecies);
            this.Controls.Add(this.LblSpecies);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.LblPetId);
            this.Controls.Add(this.TxtPetId);
            this.Controls.Add(this.PicIsModified);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPetEdit";
            this.Text = "FrmPetEdit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPetEdit_FormClosing);
            this.Load += new System.EventHandler(this.FrmPetEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicIsModified)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrPetEdit)).EndInit();
            this.GrbMicrochip.ResumeLayout(false);
            this.GrbMicrochip.PerformLayout();
            this.GrbTatuatge.ResumeLayout(false);
            this.GrbTatuatge.PerformLayout();
            this.StsPetEdit.ResumeLayout(false);
            this.StsPetEdit.PerformLayout();
            this.GrbAge.ResumeLayout(false);
            this.GrbAge.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicIsModified;
        private System.Windows.Forms.Label LblPetId;
        private System.Windows.Forms.TextBox TxtPetId;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.ComboBox CmbSpecies;
        private System.Windows.Forms.Label LblSpecies;
        private System.Windows.Forms.ComboBox CmbGender;
        private System.Windows.Forms.Label LblGender;
        private System.Windows.Forms.ErrorProvider ErrPetEdit;
        private System.Windows.Forms.Button BtnPetSave;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.Label LblDateOfBirth;
        private System.Windows.Forms.DateTimePicker DtpDateOfBirth;
        private System.Windows.Forms.Label LblColor;
        private System.Windows.Forms.TextBox TxtColor;
        private System.Windows.Forms.GroupBox GrbMicrochip;
        private System.Windows.Forms.TextBox TxtMicrochip;
        private System.Windows.Forms.Label LblMicrochip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtpDateOfDeath;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.TextBox TxtMicrochipLocation;
        private System.Windows.Forms.Label LblMicrochipLocation;
        private System.Windows.Forms.GroupBox GrbTatuatge;
        private System.Windows.Forms.TextBox TxtTatuatgeLocation;
        private System.Windows.Forms.Label LblTatuatgeLocation;
        private System.Windows.Forms.TextBox TxtTatuatge;
        private System.Windows.Forms.Label LblTatuatge;
        private System.Windows.Forms.CheckBox ChkDateOfDeath;
        private System.Windows.Forms.StatusStrip StsPetEdit;
        private System.Windows.Forms.ToolStripStatusLabel StlRecordInfo;
        private System.Windows.Forms.ComboBox CmbOwner;
        private System.Windows.Forms.Label LblOwner;
        private System.Windows.Forms.GroupBox GrbAge;
        private System.Windows.Forms.TextBox TxtMonths;
        private System.Windows.Forms.TextBox TxtYears;
        private System.Windows.Forms.TextBox TxtDays;
        private System.Windows.Forms.Label LblDays;
        private System.Windows.Forms.Label LblMonths;
        private System.Windows.Forms.Label LblYears;
        private System.Windows.Forms.Button BtnPetDelete;
    }
}