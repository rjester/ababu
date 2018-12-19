namespace Ababu
{
    partial class CtrlSystemStatus
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TlpSystemStatus = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PicRefresh = new System.Windows.Forms.PictureBox();
            this.LblSystemStatus = new System.Windows.Forms.Label();
            this.PanSystemStatus = new System.Windows.Forms.Panel();
            this.LblUserInformation = new System.Windows.Forms.Label();
            this.LblUserUptime = new System.Windows.Forms.Label();
            this.LblUserInfo = new System.Windows.Forms.Label();
            this.PicServerConnection = new System.Windows.Forms.PictureBox();
            this.PicDatabaseConnection = new System.Windows.Forms.PictureBox();
            this.LblDatabaseConnectionDescription = new System.Windows.Forms.Label();
            this.LblDatabaseConnection = new System.Windows.Forms.Label();
            this.LblServerConnectionDescription = new System.Windows.Forms.Label();
            this.LblServerConnection = new System.Windows.Forms.Label();
            this.LblServerConnectionInfo = new System.Windows.Forms.Label();
            this.LblDatabaseConnectionInfo = new System.Windows.Forms.Label();
            this.TlpSystemStatus.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicRefresh)).BeginInit();
            this.PanSystemStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicServerConnection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDatabaseConnection)).BeginInit();
            this.SuspendLayout();
            // 
            // TlpSystemStatus
            // 
            this.TlpSystemStatus.ColumnCount = 1;
            this.TlpSystemStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpSystemStatus.Controls.Add(this.panel1, 0, 0);
            this.TlpSystemStatus.Controls.Add(this.PanSystemStatus, 0, 1);
            this.TlpSystemStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpSystemStatus.Location = new System.Drawing.Point(0, 0);
            this.TlpSystemStatus.Name = "TlpSystemStatus";
            this.TlpSystemStatus.RowCount = 2;
            this.TlpSystemStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.TlpSystemStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpSystemStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpSystemStatus.Size = new System.Drawing.Size(404, 325);
            this.TlpSystemStatus.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PicRefresh);
            this.panel1.Controls.Add(this.LblSystemStatus);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 31);
            this.panel1.TabIndex = 2;
            // 
            // PicRefresh
            // 
            this.PicRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicRefresh.Image = global::Ababu.Properties.Resources.refresh;
            this.PicRefresh.Location = new System.Drawing.Point(159, 7);
            this.PicRefresh.Name = "PicRefresh";
            this.PicRefresh.Size = new System.Drawing.Size(20, 20);
            this.PicRefresh.TabIndex = 7;
            this.PicRefresh.TabStop = false;
            this.PicRefresh.Click += new System.EventHandler(this.PicRefresh_Click);
            // 
            // LblSystemStatus
            // 
            this.LblSystemStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblSystemStatus.AutoSize = true;
            this.LblSystemStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSystemStatus.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblSystemStatus.Location = new System.Drawing.Point(5, 1);
            this.LblSystemStatus.Name = "LblSystemStatus";
            this.LblSystemStatus.Size = new System.Drawing.Size(150, 25);
            this.LblSystemStatus.TabIndex = 6;
            this.LblSystemStatus.Text = "System Status";
            // 
            // PanSystemStatus
            // 
            this.PanSystemStatus.Controls.Add(this.LblDatabaseConnectionInfo);
            this.PanSystemStatus.Controls.Add(this.LblServerConnectionInfo);
            this.PanSystemStatus.Controls.Add(this.LblUserInformation);
            this.PanSystemStatus.Controls.Add(this.LblUserUptime);
            this.PanSystemStatus.Controls.Add(this.LblUserInfo);
            this.PanSystemStatus.Controls.Add(this.PicServerConnection);
            this.PanSystemStatus.Controls.Add(this.PicDatabaseConnection);
            this.PanSystemStatus.Controls.Add(this.LblDatabaseConnectionDescription);
            this.PanSystemStatus.Controls.Add(this.LblDatabaseConnection);
            this.PanSystemStatus.Controls.Add(this.LblServerConnectionDescription);
            this.PanSystemStatus.Controls.Add(this.LblServerConnection);
            this.PanSystemStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanSystemStatus.Location = new System.Drawing.Point(3, 40);
            this.PanSystemStatus.Name = "PanSystemStatus";
            this.PanSystemStatus.Size = new System.Drawing.Size(398, 282);
            this.PanSystemStatus.TabIndex = 3;
            // 
            // LblUserInformation
            // 
            this.LblUserInformation.AutoSize = true;
            this.LblUserInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserInformation.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblUserInformation.Location = new System.Drawing.Point(29, 154);
            this.LblUserInformation.Name = "LblUserInformation";
            this.LblUserInformation.Size = new System.Drawing.Size(100, 13);
            this.LblUserInformation.TabIndex = 7;
            this.LblUserInformation.Text = "User Information";
            // 
            // LblUserUptime
            // 
            this.LblUserUptime.AutoSize = true;
            this.LblUserUptime.Location = new System.Drawing.Point(29, 193);
            this.LblUserUptime.Name = "LblUserUptime";
            this.LblUserUptime.Size = new System.Drawing.Size(76, 13);
            this.LblUserUptime.TabIndex = 1;
            this.LblUserUptime.Text = "LblUserUptime";
            // 
            // LblUserInfo
            // 
            this.LblUserInfo.AutoSize = true;
            this.LblUserInfo.Location = new System.Drawing.Point(29, 174);
            this.LblUserInfo.Name = "LblUserInfo";
            this.LblUserInfo.Size = new System.Drawing.Size(61, 13);
            this.LblUserInfo.TabIndex = 0;
            this.LblUserInfo.Text = "LblUserInfo";
            // 
            // PicServerConnection
            // 
            this.PicServerConnection.Image = global::Ababu.Properties.Resources.bullet_black;
            this.PicServerConnection.Location = new System.Drawing.Point(3, 77);
            this.PicServerConnection.Name = "PicServerConnection";
            this.PicServerConnection.Size = new System.Drawing.Size(18, 18);
            this.PicServerConnection.TabIndex = 6;
            this.PicServerConnection.TabStop = false;
            // 
            // PicDatabaseConnection
            // 
            this.PicDatabaseConnection.Image = global::Ababu.Properties.Resources.bullet_black;
            this.PicDatabaseConnection.Location = new System.Drawing.Point(3, 7);
            this.PicDatabaseConnection.Name = "PicDatabaseConnection";
            this.PicDatabaseConnection.Size = new System.Drawing.Size(18, 18);
            this.PicDatabaseConnection.TabIndex = 5;
            this.PicDatabaseConnection.TabStop = false;
            // 
            // LblDatabaseConnectionDescription
            // 
            this.LblDatabaseConnectionDescription.AutoSize = true;
            this.LblDatabaseConnectionDescription.Location = new System.Drawing.Point(29, 25);
            this.LblDatabaseConnectionDescription.Name = "LblDatabaseConnectionDescription";
            this.LblDatabaseConnectionDescription.Size = new System.Drawing.Size(266, 26);
            this.LblDatabaseConnectionDescription.TabIndex = 3;
            this.LblDatabaseConnectionDescription.Text = "Show if user is connected to Ababu database \r\nwhich contains all clinical data sa" +
    "ved by the veterinary.";
            // 
            // LblDatabaseConnection
            // 
            this.LblDatabaseConnection.AutoSize = true;
            this.LblDatabaseConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDatabaseConnection.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblDatabaseConnection.Location = new System.Drawing.Point(29, 9);
            this.LblDatabaseConnection.Name = "LblDatabaseConnection";
            this.LblDatabaseConnection.Size = new System.Drawing.Size(129, 13);
            this.LblDatabaseConnection.TabIndex = 2;
            this.LblDatabaseConnection.Text = "Database Connection";
            // 
            // LblServerConnectionDescription
            // 
            this.LblServerConnectionDescription.AutoSize = true;
            this.LblServerConnectionDescription.Location = new System.Drawing.Point(29, 95);
            this.LblServerConnectionDescription.Name = "LblServerConnectionDescription";
            this.LblServerConnectionDescription.Size = new System.Drawing.Size(223, 26);
            this.LblServerConnectionDescription.TabIndex = 1;
            this.LblServerConnectionDescription.Text = "Determine if the server that run the datatbase \r\ncan be reached by this client.";
            // 
            // LblServerConnection
            // 
            this.LblServerConnection.AutoSize = true;
            this.LblServerConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblServerConnection.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblServerConnection.Location = new System.Drawing.Point(29, 79);
            this.LblServerConnection.Name = "LblServerConnection";
            this.LblServerConnection.Size = new System.Drawing.Size(112, 13);
            this.LblServerConnection.TabIndex = 0;
            this.LblServerConnection.Text = "Server Connection";
            // 
            // LblServerConnectionInfo
            // 
            this.LblServerConnectionInfo.AutoSize = true;
            this.LblServerConnectionInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblServerConnectionInfo.Location = new System.Drawing.Point(29, 127);
            this.LblServerConnectionInfo.Name = "LblServerConnectionInfo";
            this.LblServerConnectionInfo.Size = new System.Drawing.Size(147, 13);
            this.LblServerConnectionInfo.TabIndex = 8;
            this.LblServerConnectionInfo.Text = "LblServerConnectionInfo";
            // 
            // LblDatabaseConnectionInfo
            // 
            this.LblDatabaseConnectionInfo.AutoSize = true;
            this.LblDatabaseConnectionInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDatabaseConnectionInfo.Location = new System.Drawing.Point(29, 56);
            this.LblDatabaseConnectionInfo.Name = "LblDatabaseConnectionInfo";
            this.LblDatabaseConnectionInfo.Size = new System.Drawing.Size(164, 13);
            this.LblDatabaseConnectionInfo.TabIndex = 9;
            this.LblDatabaseConnectionInfo.Text = "LblDatabaseConnectionInfo";
            // 
            // CtrlSystemStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TlpSystemStatus);
            this.Name = "CtrlSystemStatus";
            this.Size = new System.Drawing.Size(404, 325);
            this.Load += new System.EventHandler(this.CtrlSystemStatus_Load);
            this.TlpSystemStatus.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicRefresh)).EndInit();
            this.PanSystemStatus.ResumeLayout(false);
            this.PanSystemStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicServerConnection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDatabaseConnection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpSystemStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblSystemStatus;
        private System.Windows.Forms.Panel PanSystemStatus;
        private System.Windows.Forms.Label LblDatabaseConnectionDescription;
        private System.Windows.Forms.Label LblDatabaseConnection;
        private System.Windows.Forms.Label LblServerConnectionDescription;
        private System.Windows.Forms.Label LblServerConnection;
        private System.Windows.Forms.PictureBox PicServerConnection;
        private System.Windows.Forms.PictureBox PicDatabaseConnection;
        private System.Windows.Forms.Label LblUserUptime;
        private System.Windows.Forms.Label LblUserInfo;
        private System.Windows.Forms.Label LblUserInformation;
        private System.Windows.Forms.PictureBox PicRefresh;
        private System.Windows.Forms.Label LblDatabaseConnectionInfo;
        private System.Windows.Forms.Label LblServerConnectionInfo;
    }
}
