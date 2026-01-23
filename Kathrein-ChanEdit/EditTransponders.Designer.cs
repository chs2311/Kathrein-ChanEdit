namespace Kathrein_ChanEdit
{
    partial class EditTransponders
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TPGrid = new System.Windows.Forms.DataGridView();
            this.SatIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrequencyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SymbolRateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TsidColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OidColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PolarisationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DvbTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModulationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TPGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(10, 12);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(325, 40);
            this.TitleLabel.TabIndex = 35;
            this.TitleLabel.Text = "Edit Transponders";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TPGrid
            // 
            this.TPGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TPGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.TPGrid.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.TPGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.TPGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TPGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SatIDColumn,
            this.FrequencyColumn,
            this.SymbolRateColumn,
            this.TsidColumn,
            this.OidColumn,
            this.PolarisationColumn,
            this.DvbTypeColumn,
            this.ModulationColumn});
            this.TPGrid.GridColor = System.Drawing.Color.Black;
            this.TPGrid.Location = new System.Drawing.Point(16, 58);
            this.TPGrid.MultiSelect = false;
            this.TPGrid.Name = "TPGrid";
            this.TPGrid.ShowEditingIcon = false;
            this.TPGrid.Size = new System.Drawing.Size(780, 588);
            this.TPGrid.TabIndex = 36;
            // 
            // SatIDColumn
            // 
            this.SatIDColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SatIDColumn.HeaderText = "SatID";
            this.SatIDColumn.Name = "SatIDColumn";
            this.SatIDColumn.ReadOnly = true;
            // 
            // FrequencyColumn
            // 
            this.FrequencyColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FrequencyColumn.HeaderText = "Frequency";
            this.FrequencyColumn.Name = "FrequencyColumn";
            this.FrequencyColumn.ReadOnly = true;
            // 
            // SymbolRateColumn
            // 
            this.SymbolRateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SymbolRateColumn.HeaderText = "Symbol Rate";
            this.SymbolRateColumn.Name = "SymbolRateColumn";
            // 
            // TsidColumn
            // 
            this.TsidColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TsidColumn.HeaderText = "TSID";
            this.TsidColumn.Name = "TsidColumn";
            // 
            // OidColumn
            // 
            this.OidColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OidColumn.HeaderText = "OID";
            this.OidColumn.Name = "OidColumn";
            // 
            // PolarisationColumn
            // 
            this.PolarisationColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PolarisationColumn.HeaderText = "Polarisation";
            this.PolarisationColumn.Name = "PolarisationColumn";
            // 
            // DvbTypeColumn
            // 
            this.DvbTypeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DvbTypeColumn.HeaderText = "DVB Type";
            this.DvbTypeColumn.Name = "DvbTypeColumn";
            // 
            // ModulationColumn
            // 
            this.ModulationColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ModulationColumn.HeaderText = "Modulation";
            this.ModulationColumn.Name = "ModulationColumn";
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.BackColor = System.Drawing.SystemColors.Control;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Location = new System.Drawing.Point(668, 12);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(128, 40);
            this.SaveButton.TabIndex = 37;
            this.SaveButton.Text = "Save Changes";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveTransponders);
            // 
            // LoadButton
            // 
            this.LoadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadButton.BackColor = System.Drawing.SystemColors.Control;
            this.LoadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadButton.Location = new System.Drawing.Point(497, 12);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(165, 40);
            this.LoadButton.TabIndex = 38;
            this.LoadButton.Text = "Load Current Config";
            this.LoadButton.UseVisualStyleBackColor = false;
            this.LoadButton.Click += new System.EventHandler(this.LoadTransponders);
            // 
            // EditTransponders
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(808, 669);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.TPGrid);
            this.Controls.Add(this.TitleLabel);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditTransponders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Satellites";
            ((System.ComponentModel.ISupportInitialize)(this.TPGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.DataGridView TPGrid;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn SatIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrequencyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SymbolRateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TsidColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OidColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PolarisationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DvbTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModulationColumn;
    }
}