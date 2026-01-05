namespace Kathrein_ChanEdit
{
    partial class SortTVChannels
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
            this.ToolBoxTVPanel = new System.Windows.Forms.GroupBox();
            this.AddAllTV = new System.Windows.Forms.Button();
            this.AddAlpTV = new System.Windows.Forms.Button();
            this.DelChannelTV = new System.Windows.Forms.Button();
            this.DelAllTV = new System.Windows.Forms.Button();
            this.SortTVLabel = new System.Windows.Forms.Label();
            this.PendingLabelTV = new System.Windows.Forms.Label();
            this.SortedLabelTV = new System.Windows.Forms.Label();
            this.SearchPendingLabelTV = new System.Windows.Forms.Label();
            this.FilterTextTV = new System.Windows.Forms.TextBox();
            this.SorterTV = new System.Windows.Forms.TableLayoutPanel();
            this.FinallyListTV = new System.Windows.Forms.ListBox();
            this.PendingListTV = new System.Windows.Forms.ListBox();
            this.ChanInfoTVPanel = new System.Windows.Forms.GroupBox();
            this.EditChanPropTV = new System.Windows.Forms.Button();
            this.ChanInfoLabelTV = new System.Windows.Forms.Label();
            this.ToolBoxTVPanel.SuspendLayout();
            this.SorterTV.SuspendLayout();
            this.ChanInfoTVPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolBoxTVPanel
            // 
            this.ToolBoxTVPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ToolBoxTVPanel.Controls.Add(this.AddAllTV);
            this.ToolBoxTVPanel.Controls.Add(this.AddAlpTV);
            this.ToolBoxTVPanel.Controls.Add(this.DelChannelTV);
            this.ToolBoxTVPanel.Controls.Add(this.DelAllTV);
            this.ToolBoxTVPanel.Location = new System.Drawing.Point(9, 519);
            this.ToolBoxTVPanel.Name = "ToolBoxTVPanel";
            this.ToolBoxTVPanel.Size = new System.Drawing.Size(546, 138);
            this.ToolBoxTVPanel.TabIndex = 35;
            this.ToolBoxTVPanel.TabStop = false;
            this.ToolBoxTVPanel.Text = "ToolBox";
            // 
            // AddAllTV
            // 
            this.AddAllTV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddAllTV.BackColor = System.Drawing.SystemColors.Control;
            this.AddAllTV.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AddAllTV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddAllTV.Location = new System.Drawing.Point(10, 52);
            this.AddAllTV.Name = "AddAllTV";
            this.AddAllTV.Size = new System.Drawing.Size(120, 35);
            this.AddAllTV.TabIndex = 30;
            this.AddAllTV.Text = "Add all";
            this.AddAllTV.UseVisualStyleBackColor = false;
            this.AddAllTV.Click += new System.EventHandler(this.AddAllUnsorted);
            // 
            // AddAlpTV
            // 
            this.AddAlpTV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddAlpTV.BackColor = System.Drawing.SystemColors.Control;
            this.AddAlpTV.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AddAlpTV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddAlpTV.Location = new System.Drawing.Point(136, 52);
            this.AddAlpTV.Name = "AddAlpTV";
            this.AddAlpTV.Size = new System.Drawing.Size(140, 35);
            this.AddAlpTV.TabIndex = 29;
            this.AddAlpTV.Text = "Add in alp. Order";
            this.AddAlpTV.UseVisualStyleBackColor = false;
            this.AddAlpTV.Click += new System.EventHandler(this.AddAllChannels);
            // 
            // DelChannelTV
            // 
            this.DelChannelTV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DelChannelTV.BackColor = System.Drawing.SystemColors.Control;
            this.DelChannelTV.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DelChannelTV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelChannelTV.Location = new System.Drawing.Point(427, 52);
            this.DelChannelTV.Name = "DelChannelTV";
            this.DelChannelTV.Size = new System.Drawing.Size(110, 35);
            this.DelChannelTV.TabIndex = 27;
            this.DelChannelTV.Text = "Delete";
            this.DelChannelTV.UseVisualStyleBackColor = false;
            this.DelChannelTV.Click += new System.EventHandler(this.Delete);
            // 
            // DelAllTV
            // 
            this.DelAllTV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DelAllTV.BackColor = System.Drawing.SystemColors.Control;
            this.DelAllTV.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DelAllTV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelAllTV.Location = new System.Drawing.Point(282, 52);
            this.DelAllTV.Name = "DelAllTV";
            this.DelAllTV.Size = new System.Drawing.Size(139, 35);
            this.DelAllTV.TabIndex = 28;
            this.DelAllTV.Text = "Delete All Shown";
            this.DelAllTV.UseVisualStyleBackColor = false;
            this.DelAllTV.Click += new System.EventHandler(this.DeleteAllShown);
            // 
            // SortTVLabel
            // 
            this.SortTVLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortTVLabel.Location = new System.Drawing.Point(10, 12);
            this.SortTVLabel.Name = "SortTVLabel";
            this.SortTVLabel.Size = new System.Drawing.Size(325, 40);
            this.SortTVLabel.TabIndex = 34;
            this.SortTVLabel.Text = "Sort TV Channels";
            this.SortTVLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PendingLabelTV
            // 
            this.PendingLabelTV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PendingLabelTV.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PendingLabelTV.Location = new System.Drawing.Point(610, 52);
            this.PendingLabelTV.Name = "PendingLabelTV";
            this.PendingLabelTV.Size = new System.Drawing.Size(186, 26);
            this.PendingLabelTV.TabIndex = 33;
            this.PendingLabelTV.Text = "PENDING";
            this.PendingLabelTV.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // SortedLabelTV
            // 
            this.SortedLabelTV.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortedLabelTV.Location = new System.Drawing.Point(12, 52);
            this.SortedLabelTV.Name = "SortedLabelTV";
            this.SortedLabelTV.Size = new System.Drawing.Size(186, 26);
            this.SortedLabelTV.TabIndex = 32;
            this.SortedLabelTV.Text = "SORTED";
            this.SortedLabelTV.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // SearchPendingLabelTV
            // 
            this.SearchPendingLabelTV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchPendingLabelTV.Location = new System.Drawing.Point(357, 16);
            this.SearchPendingLabelTV.Name = "SearchPendingLabelTV";
            this.SearchPendingLabelTV.Size = new System.Drawing.Size(180, 26);
            this.SearchPendingLabelTV.TabIndex = 31;
            this.SearchPendingLabelTV.Text = "Search in Pending:";
            this.SearchPendingLabelTV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FilterTextTV
            // 
            this.FilterTextTV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterTextTV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilterTextTV.Location = new System.Drawing.Point(540, 16);
            this.FilterTextTV.Name = "FilterTextTV";
            this.FilterTextTV.Size = new System.Drawing.Size(256, 26);
            this.FilterTextTV.TabIndex = 30;
            // 
            // SorterTV
            // 
            this.SorterTV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SorterTV.ColumnCount = 2;
            this.SorterTV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SorterTV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SorterTV.Controls.Add(this.FinallyListTV, 0, 0);
            this.SorterTV.Controls.Add(this.PendingListTV, 1, 0);
            this.SorterTV.Location = new System.Drawing.Point(9, 81);
            this.SorterTV.Name = "SorterTV";
            this.SorterTV.RowCount = 1;
            this.SorterTV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SorterTV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SorterTV.Size = new System.Drawing.Size(790, 432);
            this.SorterTV.TabIndex = 29;
            // 
            // FinallyListTV
            // 
            this.FinallyListTV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FinallyListTV.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinallyListTV.FormattingEnabled = true;
            this.FinallyListTV.ItemHeight = 21;
            this.FinallyListTV.Location = new System.Drawing.Point(3, 3);
            this.FinallyListTV.Name = "FinallyListTV";
            this.FinallyListTV.Size = new System.Drawing.Size(389, 426);
            this.FinallyListTV.TabIndex = 0;
            this.FinallyListTV.SelectedIndexChanged += new System.EventHandler(this.ShowProperties);
            this.FinallyListTV.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FinallyListDoubleClick);
            // 
            // PendingListTV
            // 
            this.PendingListTV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PendingListTV.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PendingListTV.FormattingEnabled = true;
            this.PendingListTV.ItemHeight = 21;
            this.PendingListTV.Location = new System.Drawing.Point(398, 3);
            this.PendingListTV.Name = "PendingListTV";
            this.PendingListTV.Size = new System.Drawing.Size(389, 426);
            this.PendingListTV.TabIndex = 1;
            this.PendingListTV.SelectedIndexChanged += new System.EventHandler(this.ShowProperties);
            this.PendingListTV.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PendingListDoubleClick);
            // 
            // ChanInfoTVPanel
            // 
            this.ChanInfoTVPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ChanInfoTVPanel.Controls.Add(this.ChanInfoLabelTV);
            this.ChanInfoTVPanel.Controls.Add(this.EditChanPropTV);
            this.ChanInfoTVPanel.Location = new System.Drawing.Point(570, 519);
            this.ChanInfoTVPanel.Name = "ChanInfoTVPanel";
            this.ChanInfoTVPanel.Size = new System.Drawing.Size(229, 138);
            this.ChanInfoTVPanel.TabIndex = 36;
            this.ChanInfoTVPanel.TabStop = false;
            this.ChanInfoTVPanel.Text = "Channel Information";
            // 
            // EditChanPropTV
            // 
            this.EditChanPropTV.BackColor = System.Drawing.SystemColors.Control;
            this.EditChanPropTV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditChanPropTV.Location = new System.Drawing.Point(6, 102);
            this.EditChanPropTV.Name = "EditChanPropTV";
            this.EditChanPropTV.Size = new System.Drawing.Size(217, 30);
            this.EditChanPropTV.TabIndex = 0;
            this.EditChanPropTV.Text = "Edit Channel Properties";
            this.EditChanPropTV.UseVisualStyleBackColor = false;
            // 
            // ChanInfoLabelTV
            // 
            this.ChanInfoLabelTV.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChanInfoLabelTV.Location = new System.Drawing.Point(6, 22);
            this.ChanInfoLabelTV.Name = "ChanInfoLabelTV";
            this.ChanInfoLabelTV.Size = new System.Drawing.Size(217, 77);
            this.ChanInfoLabelTV.TabIndex = 1;
            this.ChanInfoLabelTV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SortTVChannels
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(808, 669);
            this.Controls.Add(this.ChanInfoTVPanel);
            this.Controls.Add(this.ToolBoxTVPanel);
            this.Controls.Add(this.SortTVLabel);
            this.Controls.Add(this.PendingLabelTV);
            this.Controls.Add(this.SortedLabelTV);
            this.Controls.Add(this.SearchPendingLabelTV);
            this.Controls.Add(this.FilterTextTV);
            this.Controls.Add(this.SorterTV);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SortTVChannels";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sort TV Channels";
            this.ToolBoxTVPanel.ResumeLayout(false);
            this.SorterTV.ResumeLayout(false);
            this.ChanInfoTVPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox ToolBoxTVPanel;
        private System.Windows.Forms.Button AddAllTV;
        private System.Windows.Forms.Button AddAlpTV;
        private System.Windows.Forms.Button DelChannelTV;
        private System.Windows.Forms.Button DelAllTV;
        private System.Windows.Forms.Label SortTVLabel;
        private System.Windows.Forms.Label PendingLabelTV;
        private System.Windows.Forms.Label SortedLabelTV;
        private System.Windows.Forms.Label SearchPendingLabelTV;
        private System.Windows.Forms.TextBox FilterTextTV;
        private System.Windows.Forms.TableLayoutPanel SorterTV;
        public System.Windows.Forms.ListBox FinallyListTV;
        public System.Windows.Forms.ListBox PendingListTV;
        private System.Windows.Forms.GroupBox ChanInfoTVPanel;
        private System.Windows.Forms.Button EditChanPropTV;
        private System.Windows.Forms.Label ChanInfoLabelTV;
    }
}