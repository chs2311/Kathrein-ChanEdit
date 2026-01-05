namespace Kathrein_RecBrowser
{
    partial class Recording
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.ThumbnailBox = new System.Windows.Forms.PictureBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.DetailedTextLabel = new System.Windows.Forms.Label();
            this.PlayWithVLCButton = new System.Windows.Forms.Button();
            this.ConvertToMPEGButton = new System.Windows.Forms.Button();
            this.DateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ThumbnailBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ThumbnailBox
            // 
            this.ThumbnailBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ThumbnailBox.Location = new System.Drawing.Point(10, 10);
            this.ThumbnailBox.Name = "ThumbnailBox";
            this.ThumbnailBox.Size = new System.Drawing.Size(100, 100);
            this.ThumbnailBox.TabIndex = 0;
            this.ThumbnailBox.TabStop = false;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(116, 10);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(421, 34);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "BEST OF YOU DELUXE";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DetailedTextLabel
            // 
            this.DetailedTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DetailedTextLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailedTextLabel.Location = new System.Drawing.Point(116, 44);
            this.DetailedTextLabel.Name = "DetailedTextLabel";
            this.DetailedTextLabel.Size = new System.Drawing.Size(564, 66);
            this.DetailedTextLabel.TabIndex = 2;
            this.DetailedTextLabel.Text = "BEST OF YOU DELUXE lässt dich gut in den Vormittag starten und begleitet dich mit" +
    " den besten und neuesten Clips in deinen Mittag.";
            this.DetailedTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PlayWithVLCButton
            // 
            this.PlayWithVLCButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayWithVLCButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayWithVLCButton.Location = new System.Drawing.Point(686, 10);
            this.PlayWithVLCButton.Name = "PlayWithVLCButton";
            this.PlayWithVLCButton.Size = new System.Drawing.Size(45, 45);
            this.PlayWithVLCButton.TabIndex = 3;
            this.PlayWithVLCButton.UseVisualStyleBackColor = true;
            this.PlayWithVLCButton.Click += new System.EventHandler(this.PlayWithVLC);
            // 
            // ConvertToMPEGButton
            // 
            this.ConvertToMPEGButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ConvertToMPEGButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConvertToMPEGButton.Location = new System.Drawing.Point(686, 65);
            this.ConvertToMPEGButton.Name = "ConvertToMPEGButton";
            this.ConvertToMPEGButton.Size = new System.Drawing.Size(45, 45);
            this.ConvertToMPEGButton.TabIndex = 4;
            this.ConvertToMPEGButton.UseVisualStyleBackColor = true;
            this.ConvertToMPEGButton.Click += new System.EventHandler(this.ConvertToMPEG);
            // 
            // DateLabel
            // 
            this.DateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DateLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(543, 10);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(137, 23);
            this.DateLabel.TabIndex = 5;
            this.DateLabel.Text = "31-12-2016 23:59:60";
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Recording
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.ConvertToMPEGButton);
            this.Controls.Add(this.PlayWithVLCButton);
            this.Controls.Add(this.DetailedTextLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.ThumbnailBox);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Recording";
            this.Size = new System.Drawing.Size(745, 120);
            this.Load += new System.EventHandler(this.LoadAssets);
            ((System.ComponentModel.ISupportInitialize)(this.ThumbnailBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ThumbnailBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label DetailedTextLabel;
        private System.Windows.Forms.Button PlayWithVLCButton;
        private System.Windows.Forms.Button ConvertToMPEGButton;
        private System.Windows.Forms.Label DateLabel;
    }
}
