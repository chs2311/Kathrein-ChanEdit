namespace Kathrein_ChanEdit
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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SideBarPanel = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.QuickSaveButton = new System.Windows.Forms.Button();
            this.SaveXMLButton = new System.Windows.Forms.Button();
            this.LoadXMLButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.WindowsPanel = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.TopPanel.SuspendLayout();
            this.SideBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.TopPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TopPanel.Controls.Add(this.TitleLabel);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1008, 60);
            this.TopPanel.TabIndex = 0;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleLabel.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(0, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(1006, 58);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Kathrein Channel Editor";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SideBarPanel
            // 
            this.SideBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.SideBarPanel.Controls.Add(this.button7);
            this.SideBarPanel.Controls.Add(this.button6);
            this.SideBarPanel.Controls.Add(this.QuickSaveButton);
            this.SideBarPanel.Controls.Add(this.SaveXMLButton);
            this.SideBarPanel.Controls.Add(this.LoadXMLButton);
            this.SideBarPanel.Controls.Add(this.button5);
            this.SideBarPanel.Controls.Add(this.button4);
            this.SideBarPanel.Controls.Add(this.button3);
            this.SideBarPanel.Controls.Add(this.button2);
            this.SideBarPanel.Controls.Add(this.button1);
            this.SideBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBarPanel.Location = new System.Drawing.Point(0, 60);
            this.SideBarPanel.Name = "SideBarPanel";
            this.SideBarPanel.Size = new System.Drawing.Size(200, 669);
            this.SideBarPanel.TabIndex = 3;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(0, 461);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(200, 52);
            this.button6.TabIndex = 13;
            this.button6.Text = "Exit";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.ExitButtonClicked);
            // 
            // QuickSaveButton
            // 
            this.QuickSaveButton.BackColor = System.Drawing.Color.Transparent;
            this.QuickSaveButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.QuickSaveButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.QuickSaveButton.FlatAppearance.BorderSize = 0;
            this.QuickSaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.QuickSaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.QuickSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuickSaveButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuickSaveButton.ForeColor = System.Drawing.Color.White;
            this.QuickSaveButton.Location = new System.Drawing.Point(0, 513);
            this.QuickSaveButton.Name = "QuickSaveButton";
            this.QuickSaveButton.Size = new System.Drawing.Size(200, 52);
            this.QuickSaveButton.TabIndex = 12;
            this.QuickSaveButton.Text = "Quick Save";
            this.QuickSaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.QuickSaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.QuickSaveButton.UseVisualStyleBackColor = false;
            this.QuickSaveButton.Click += new System.EventHandler(this.QuickSaveButtonClicked);
            // 
            // SaveXMLButton
            // 
            this.SaveXMLButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveXMLButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SaveXMLButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SaveXMLButton.FlatAppearance.BorderSize = 0;
            this.SaveXMLButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.SaveXMLButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.SaveXMLButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveXMLButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveXMLButton.ForeColor = System.Drawing.Color.White;
            this.SaveXMLButton.Location = new System.Drawing.Point(0, 565);
            this.SaveXMLButton.Name = "SaveXMLButton";
            this.SaveXMLButton.Size = new System.Drawing.Size(200, 52);
            this.SaveXMLButton.TabIndex = 11;
            this.SaveXMLButton.Text = "Save *.xml";
            this.SaveXMLButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveXMLButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveXMLButton.UseVisualStyleBackColor = false;
            this.SaveXMLButton.Click += new System.EventHandler(this.SaveButtonClicked);
            // 
            // LoadXMLButton
            // 
            this.LoadXMLButton.BackColor = System.Drawing.Color.Transparent;
            this.LoadXMLButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LoadXMLButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.LoadXMLButton.FlatAppearance.BorderSize = 0;
            this.LoadXMLButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.LoadXMLButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.LoadXMLButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadXMLButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadXMLButton.ForeColor = System.Drawing.Color.White;
            this.LoadXMLButton.Location = new System.Drawing.Point(0, 617);
            this.LoadXMLButton.Name = "LoadXMLButton";
            this.LoadXMLButton.Size = new System.Drawing.Size(200, 52);
            this.LoadXMLButton.TabIndex = 10;
            this.LoadXMLButton.Text = "Load *.xml";
            this.LoadXMLButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoadXMLButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LoadXMLButton.UseVisualStyleBackColor = false;
            this.LoadXMLButton.Click += new System.EventHandler(this.LoadButtonClicked);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(0, 208);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 52);
            this.button5.TabIndex = 8;
            this.button5.Text = "Satellites";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.OpenSatellites);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(0, 156);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 52);
            this.button4.TabIndex = 7;
            this.button4.Text = "Transponders";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.OpenTransponders);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 104);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 52);
            this.button3.TabIndex = 6;
            this.button3.Text = "Data Channels";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.OpenDataChannels);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 52);
            this.button2.TabIndex = 5;
            this.button2.Text = "Radio Channels";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.OpenRadioChannels);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 52);
            this.button1.TabIndex = 4;
            this.button1.Text = "TV Channels";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.OpenTVChannels);
            // 
            // WindowsPanel
            // 
            this.WindowsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WindowsPanel.Location = new System.Drawing.Point(200, 60);
            this.WindowsPanel.Name = "WindowsPanel";
            this.WindowsPanel.Size = new System.Drawing.Size(808, 669);
            this.WindowsPanel.TabIndex = 4;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(0, 260);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(200, 52);
            this.button7.TabIndex = 14;
            this.button7.Text = "Browse Recordings";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.OpenRecBrowser);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.WindowsPanel);
            this.Controls.Add(this.SideBarPanel);
            this.Controls.Add(this.TopPanel);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kathrein Channel Editor";
            this.TopPanel.ResumeLayout(false);
            this.SideBarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Panel SideBarPanel;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button QuickSaveButton;
        private System.Windows.Forms.Button SaveXMLButton;
        private System.Windows.Forms.Button LoadXMLButton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel WindowsPanel;
        private System.Windows.Forms.Button button7;
    }
}

