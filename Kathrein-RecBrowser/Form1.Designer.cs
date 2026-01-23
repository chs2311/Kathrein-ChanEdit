namespace Kathrein_RecBrowser
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitleLabel = new System.Windows.Forms.Label();
            this.DiskDriveSelector = new System.Windows.Forms.ListBox();
            this.SelectInfoLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AvRecordsInfoLabel = new System.Windows.Forms.Label();
            this.DriveValidLabel = new System.Windows.Forms.Label();
            this.ConvAllButton = new System.Windows.Forms.Button();
            this.CustomDirButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(0, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(800, 46);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Kathrein Recordings Browser";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DiskDriveSelector
            // 
            this.DiskDriveSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DiskDriveSelector.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiskDriveSelector.FormattingEnabled = true;
            this.DiskDriveSelector.ItemHeight = 16;
            this.DiskDriveSelector.Items.AddRange(new object[] {
            "A:\\",
            "B:\\",
            "C:\\",
            "D:\\",
            "E:\\",
            "F:\\",
            "G:\\",
            "H:\\",
            "I:\\",
            "J:\\",
            "K:\\",
            "L:\\",
            "M:\\",
            "N:\\",
            "O:\\",
            "P:\\",
            "Q:\\",
            "R:\\",
            "S:\\",
            "T:\\",
            "U:\\",
            "V:\\",
            "W:\\",
            "X:\\",
            "Y:\\",
            "Z:\\"});
            this.DiskDriveSelector.Location = new System.Drawing.Point(15, 81);
            this.DiskDriveSelector.Name = "DiskDriveSelector";
            this.DiskDriveSelector.Size = new System.Drawing.Size(120, 324);
            this.DiskDriveSelector.TabIndex = 1;
            this.DiskDriveSelector.SelectedIndexChanged += new System.EventHandler(this.DriveChanged);
            // 
            // SelectInfoLabel
            // 
            this.SelectInfoLabel.Location = new System.Drawing.Point(12, 46);
            this.SelectInfoLabel.Name = "SelectInfoLabel";
            this.SelectInfoLabel.Size = new System.Drawing.Size(120, 32);
            this.SelectInfoLabel.TabIndex = 2;
            this.SelectInfoLabel.Text = "Select Drive:";
            this.SelectInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(141, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 324);
            this.panel1.TabIndex = 3;
            // 
            // AvRecordsInfoLabel
            // 
            this.AvRecordsInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AvRecordsInfoLabel.Location = new System.Drawing.Point(138, 46);
            this.AvRecordsInfoLabel.Name = "AvRecordsInfoLabel";
            this.AvRecordsInfoLabel.Size = new System.Drawing.Size(650, 32);
            this.AvRecordsInfoLabel.TabIndex = 4;
            this.AvRecordsInfoLabel.Text = "Available Recordings";
            this.AvRecordsInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DriveValidLabel
            // 
            this.DriveValidLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DriveValidLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DriveValidLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DriveValidLabel.Location = new System.Drawing.Point(306, 407);
            this.DriveValidLabel.Name = "DriveValidLabel";
            this.DriveValidLabel.Size = new System.Drawing.Size(482, 29);
            this.DriveValidLabel.TabIndex = 5;
            this.DriveValidLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConvAllButton
            // 
            this.ConvAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ConvAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConvAllButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvAllButton.Location = new System.Drawing.Point(141, 407);
            this.ConvAllButton.Name = "ConvAllButton";
            this.ConvAllButton.Size = new System.Drawing.Size(159, 30);
            this.ConvAllButton.TabIndex = 6;
            this.ConvAllButton.Text = "Convert All to MPEG";
            this.ConvAllButton.UseVisualStyleBackColor = true;
            this.ConvAllButton.Click += new System.EventHandler(this.ConvertAll);
            // 
            // CustomDirButton
            // 
            this.CustomDirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CustomDirButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomDirButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomDirButton.Location = new System.Drawing.Point(15, 407);
            this.CustomDirButton.Name = "CustomDirButton";
            this.CustomDirButton.Size = new System.Drawing.Size(120, 30);
            this.CustomDirButton.TabIndex = 7;
            this.CustomDirButton.Text = "Directory . . . ";
            this.CustomDirButton.UseVisualStyleBackColor = true;
            this.CustomDirButton.Click += new System.EventHandler(this.SelectCustomDir);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DriveValidLabel);
            this.Controls.Add(this.CustomDirButton);
            this.Controls.Add(this.ConvAllButton);
            this.Controls.Add(this.AvRecordsInfoLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SelectInfoLabel);
            this.Controls.Add(this.DiskDriveSelector);
            this.Controls.Add(this.TitleLabel);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Kathrein Recordings Browser";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.ListBox DiskDriveSelector;
        private System.Windows.Forms.Label SelectInfoLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AvRecordsInfoLabel;
        private System.Windows.Forms.Label DriveValidLabel;
        private System.Windows.Forms.Button ConvAllButton;
        private System.Windows.Forms.Button CustomDirButton;
    }
}

