namespace Kathrein_ChanEdit
{
    partial class SortDataChannels
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
            this.SearchPendingData = new System.Windows.Forms.Label();
            this.FilterTextData = new System.Windows.Forms.TextBox();
            this.SorterData = new System.Windows.Forms.TableLayoutPanel();
            this.FinallyListData = new System.Windows.Forms.ListBox();
            this.PendingListData = new System.Windows.Forms.ListBox();
            this.SortRadioLabel = new System.Windows.Forms.Label();
            this.PendingLabelData = new System.Windows.Forms.Label();
            this.SortedLabelData = new System.Windows.Forms.Label();
            this.ToolBoxDataPanel = new System.Windows.Forms.GroupBox();
            this.AddAllData = new System.Windows.Forms.Button();
            this.AddAlpData = new System.Windows.Forms.Button();
            this.DelChannelData = new System.Windows.Forms.Button();
            this.DelAllData = new System.Windows.Forms.Button();
            this.ChanInfoDataPanel = new System.Windows.Forms.GroupBox();
            this.ChanInfoLabelData = new System.Windows.Forms.Label();
            this.EditChanPropData = new System.Windows.Forms.Button();
            this.SorterData.SuspendLayout();
            this.ToolBoxDataPanel.SuspendLayout();
            this.ChanInfoDataPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchPendingData
            // 
            this.SearchPendingData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchPendingData.Location = new System.Drawing.Point(354, 16);
            this.SearchPendingData.Name = "SearchPendingData";
            this.SearchPendingData.Size = new System.Drawing.Size(180, 26);
            this.SearchPendingData.TabIndex = 31;
            this.SearchPendingData.Text = "Search in Pending:";
            this.SearchPendingData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FilterTextData
            // 
            this.FilterTextData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterTextData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilterTextData.Location = new System.Drawing.Point(540, 16);
            this.FilterTextData.Name = "FilterTextData";
            this.FilterTextData.Size = new System.Drawing.Size(256, 26);
            this.FilterTextData.TabIndex = 30;
            // 
            // SorterData
            // 
            this.SorterData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SorterData.ColumnCount = 2;
            this.SorterData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SorterData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SorterData.Controls.Add(this.FinallyListData, 0, 0);
            this.SorterData.Controls.Add(this.PendingListData, 1, 0);
            this.SorterData.Location = new System.Drawing.Point(9, 81);
            this.SorterData.Name = "SorterData";
            this.SorterData.RowCount = 1;
            this.SorterData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SorterData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SorterData.Size = new System.Drawing.Size(790, 432);
            this.SorterData.TabIndex = 36;
            // 
            // FinallyListData
            // 
            this.FinallyListData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FinallyListData.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinallyListData.FormattingEnabled = true;
            this.FinallyListData.ItemHeight = 21;
            this.FinallyListData.Location = new System.Drawing.Point(3, 3);
            this.FinallyListData.Name = "FinallyListData";
            this.FinallyListData.Size = new System.Drawing.Size(389, 426);
            this.FinallyListData.TabIndex = 0;
            this.FinallyListData.SelectedIndexChanged += new System.EventHandler(this.ShowProperties);
            this.FinallyListData.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FinallyListDoubleClick);
            // 
            // PendingListData
            // 
            this.PendingListData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PendingListData.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PendingListData.FormattingEnabled = true;
            this.PendingListData.ItemHeight = 21;
            this.PendingListData.Location = new System.Drawing.Point(398, 3);
            this.PendingListData.Name = "PendingListData";
            this.PendingListData.Size = new System.Drawing.Size(389, 426);
            this.PendingListData.TabIndex = 1;
            this.PendingListData.SelectedIndexChanged += new System.EventHandler(this.ShowProperties);
            this.PendingListData.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PendingListDoubleClick);
            // 
            // SortRadioLabel
            // 
            this.SortRadioLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortRadioLabel.Location = new System.Drawing.Point(10, 12);
            this.SortRadioLabel.Name = "SortRadioLabel";
            this.SortRadioLabel.Size = new System.Drawing.Size(325, 40);
            this.SortRadioLabel.TabIndex = 34;
            this.SortRadioLabel.Text = "Sort Data Channels";
            this.SortRadioLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PendingLabelData
            // 
            this.PendingLabelData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PendingLabelData.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PendingLabelData.Location = new System.Drawing.Point(610, 52);
            this.PendingLabelData.Name = "PendingLabelData";
            this.PendingLabelData.Size = new System.Drawing.Size(186, 26);
            this.PendingLabelData.TabIndex = 33;
            this.PendingLabelData.Text = "PENDING";
            this.PendingLabelData.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // SortedLabelData
            // 
            this.SortedLabelData.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortedLabelData.Location = new System.Drawing.Point(12, 52);
            this.SortedLabelData.Name = "SortedLabelData";
            this.SortedLabelData.Size = new System.Drawing.Size(186, 26);
            this.SortedLabelData.TabIndex = 32;
            this.SortedLabelData.Text = "SORTED";
            this.SortedLabelData.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ToolBoxDataPanel
            // 
            this.ToolBoxDataPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ToolBoxDataPanel.Controls.Add(this.AddAllData);
            this.ToolBoxDataPanel.Controls.Add(this.AddAlpData);
            this.ToolBoxDataPanel.Controls.Add(this.DelChannelData);
            this.ToolBoxDataPanel.Controls.Add(this.DelAllData);
            this.ToolBoxDataPanel.Location = new System.Drawing.Point(9, 519);
            this.ToolBoxDataPanel.Name = "ToolBoxDataPanel";
            this.ToolBoxDataPanel.Size = new System.Drawing.Size(546, 138);
            this.ToolBoxDataPanel.TabIndex = 37;
            this.ToolBoxDataPanel.TabStop = false;
            this.ToolBoxDataPanel.Text = "ToolBox";
            // 
            // AddAllData
            // 
            this.AddAllData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddAllData.BackColor = System.Drawing.SystemColors.Control;
            this.AddAllData.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AddAllData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddAllData.Location = new System.Drawing.Point(10, 52);
            this.AddAllData.Name = "AddAllData";
            this.AddAllData.Size = new System.Drawing.Size(120, 35);
            this.AddAllData.TabIndex = 30;
            this.AddAllData.Text = "Add all";
            this.AddAllData.UseVisualStyleBackColor = false;
            this.AddAllData.Click += new System.EventHandler(this.AddAllUnsorted);
            // 
            // AddAlpData
            // 
            this.AddAlpData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddAlpData.BackColor = System.Drawing.SystemColors.Control;
            this.AddAlpData.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AddAlpData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddAlpData.Location = new System.Drawing.Point(136, 52);
            this.AddAlpData.Name = "AddAlpData";
            this.AddAlpData.Size = new System.Drawing.Size(140, 35);
            this.AddAlpData.TabIndex = 29;
            this.AddAlpData.Text = "Add in alp. Order";
            this.AddAlpData.UseVisualStyleBackColor = false;
            this.AddAlpData.Click += new System.EventHandler(this.AddAllChannels);
            // 
            // DelChannelData
            // 
            this.DelChannelData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DelChannelData.BackColor = System.Drawing.SystemColors.Control;
            this.DelChannelData.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DelChannelData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelChannelData.Location = new System.Drawing.Point(427, 52);
            this.DelChannelData.Name = "DelChannelData";
            this.DelChannelData.Size = new System.Drawing.Size(110, 35);
            this.DelChannelData.TabIndex = 27;
            this.DelChannelData.Text = "Delete";
            this.DelChannelData.UseVisualStyleBackColor = false;
            this.DelChannelData.Click += new System.EventHandler(this.Delete);
            // 
            // DelAllData
            // 
            this.DelAllData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DelAllData.BackColor = System.Drawing.SystemColors.Control;
            this.DelAllData.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DelAllData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelAllData.Location = new System.Drawing.Point(282, 52);
            this.DelAllData.Name = "DelAllData";
            this.DelAllData.Size = new System.Drawing.Size(139, 35);
            this.DelAllData.TabIndex = 28;
            this.DelAllData.Text = "Delete All Shown";
            this.DelAllData.UseVisualStyleBackColor = false;
            this.DelAllData.Click += new System.EventHandler(this.DeleteAllShown);
            // 
            // ChanInfoDataPanel
            // 
            this.ChanInfoDataPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ChanInfoDataPanel.Controls.Add(this.ChanInfoLabelData);
            this.ChanInfoDataPanel.Controls.Add(this.EditChanPropData);
            this.ChanInfoDataPanel.Location = new System.Drawing.Point(570, 519);
            this.ChanInfoDataPanel.Name = "ChanInfoDataPanel";
            this.ChanInfoDataPanel.Size = new System.Drawing.Size(229, 138);
            this.ChanInfoDataPanel.TabIndex = 38;
            this.ChanInfoDataPanel.TabStop = false;
            this.ChanInfoDataPanel.Text = "Channel Information";
            // 
            // ChanInfoLabelData
            // 
            this.ChanInfoLabelData.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChanInfoLabelData.Location = new System.Drawing.Point(6, 22);
            this.ChanInfoLabelData.Name = "ChanInfoLabelData";
            this.ChanInfoLabelData.Size = new System.Drawing.Size(217, 77);
            this.ChanInfoLabelData.TabIndex = 1;
            this.ChanInfoLabelData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EditChanPropData
            // 
            this.EditChanPropData.BackColor = System.Drawing.SystemColors.Control;
            this.EditChanPropData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditChanPropData.Location = new System.Drawing.Point(6, 102);
            this.EditChanPropData.Name = "EditChanPropData";
            this.EditChanPropData.Size = new System.Drawing.Size(217, 30);
            this.EditChanPropData.TabIndex = 0;
            this.EditChanPropData.Text = "Edit Channel Properties";
            this.EditChanPropData.UseVisualStyleBackColor = false;
            // 
            // SortDataChannels
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(808, 669);
            this.Controls.Add(this.ChanInfoDataPanel);
            this.Controls.Add(this.ToolBoxDataPanel);
            this.Controls.Add(this.SearchPendingData);
            this.Controls.Add(this.FilterTextData);
            this.Controls.Add(this.SorterData);
            this.Controls.Add(this.SortRadioLabel);
            this.Controls.Add(this.PendingLabelData);
            this.Controls.Add(this.SortedLabelData);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SortDataChannels";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sort Radio Channels";
            this.SorterData.ResumeLayout(false);
            this.ToolBoxDataPanel.ResumeLayout(false);
            this.ChanInfoDataPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SearchPendingData;
        private System.Windows.Forms.TextBox FilterTextData;
        private System.Windows.Forms.TableLayoutPanel SorterData;
        private System.Windows.Forms.Label SortRadioLabel;
        private System.Windows.Forms.Label PendingLabelData;
        private System.Windows.Forms.Label SortedLabelData;
        public System.Windows.Forms.ListBox FinallyListData;
        public System.Windows.Forms.ListBox PendingListData;
        private System.Windows.Forms.GroupBox ToolBoxDataPanel;
        private System.Windows.Forms.Button AddAllData;
        private System.Windows.Forms.Button AddAlpData;
        private System.Windows.Forms.Button DelChannelData;
        private System.Windows.Forms.Button DelAllData;
        private System.Windows.Forms.GroupBox ChanInfoDataPanel;
        private System.Windows.Forms.Label ChanInfoLabelData;
        private System.Windows.Forms.Button EditChanPropData;
    }
}