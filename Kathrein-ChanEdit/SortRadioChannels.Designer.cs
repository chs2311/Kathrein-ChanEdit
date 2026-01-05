namespace Kathrein_ChanEdit
{
    partial class SortRadioChannels
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
            this.SearchPendingRadio = new System.Windows.Forms.Label();
            this.FilterTextRadio = new System.Windows.Forms.TextBox();
            this.SorterRadio = new System.Windows.Forms.TableLayoutPanel();
            this.FinallyListRadio = new System.Windows.Forms.ListBox();
            this.PendingListRadio = new System.Windows.Forms.ListBox();
            this.SortRadioLabel = new System.Windows.Forms.Label();
            this.PendingLabelRadio = new System.Windows.Forms.Label();
            this.SortedLabelRadio = new System.Windows.Forms.Label();
            this.ToolBoxRadioPanel = new System.Windows.Forms.GroupBox();
            this.AddAllRadio = new System.Windows.Forms.Button();
            this.AddAlpRadio = new System.Windows.Forms.Button();
            this.DelChannelRadio = new System.Windows.Forms.Button();
            this.DelAllRadio = new System.Windows.Forms.Button();
            this.ChanInfoRadioPanel = new System.Windows.Forms.GroupBox();
            this.ChanInfoLabelRadio = new System.Windows.Forms.Label();
            this.EditChanPropRadio = new System.Windows.Forms.Button();
            this.SorterRadio.SuspendLayout();
            this.ToolBoxRadioPanel.SuspendLayout();
            this.ChanInfoRadioPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchPendingRadio
            // 
            this.SearchPendingRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchPendingRadio.Location = new System.Drawing.Point(354, 16);
            this.SearchPendingRadio.Name = "SearchPendingRadio";
            this.SearchPendingRadio.Size = new System.Drawing.Size(180, 26);
            this.SearchPendingRadio.TabIndex = 31;
            this.SearchPendingRadio.Text = "Search in Pending:";
            this.SearchPendingRadio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FilterTextRadio
            // 
            this.FilterTextRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterTextRadio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilterTextRadio.Location = new System.Drawing.Point(540, 16);
            this.FilterTextRadio.Name = "FilterTextRadio";
            this.FilterTextRadio.Size = new System.Drawing.Size(256, 26);
            this.FilterTextRadio.TabIndex = 30;
            // 
            // SorterRadio
            // 
            this.SorterRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SorterRadio.ColumnCount = 2;
            this.SorterRadio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SorterRadio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SorterRadio.Controls.Add(this.FinallyListRadio, 0, 0);
            this.SorterRadio.Controls.Add(this.PendingListRadio, 1, 0);
            this.SorterRadio.Location = new System.Drawing.Point(9, 81);
            this.SorterRadio.Name = "SorterRadio";
            this.SorterRadio.RowCount = 1;
            this.SorterRadio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SorterRadio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SorterRadio.Size = new System.Drawing.Size(790, 432);
            this.SorterRadio.TabIndex = 36;
            // 
            // FinallyListRadio
            // 
            this.FinallyListRadio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FinallyListRadio.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinallyListRadio.FormattingEnabled = true;
            this.FinallyListRadio.ItemHeight = 21;
            this.FinallyListRadio.Location = new System.Drawing.Point(3, 3);
            this.FinallyListRadio.Name = "FinallyListRadio";
            this.FinallyListRadio.Size = new System.Drawing.Size(389, 426);
            this.FinallyListRadio.TabIndex = 0;
            this.FinallyListRadio.SelectedIndexChanged += new System.EventHandler(this.ShowProperties);
            this.FinallyListRadio.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FinallyListDoubleClick);
            // 
            // PendingListRadio
            // 
            this.PendingListRadio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PendingListRadio.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PendingListRadio.FormattingEnabled = true;
            this.PendingListRadio.ItemHeight = 21;
            this.PendingListRadio.Location = new System.Drawing.Point(398, 3);
            this.PendingListRadio.Name = "PendingListRadio";
            this.PendingListRadio.Size = new System.Drawing.Size(389, 426);
            this.PendingListRadio.TabIndex = 1;
            this.PendingListRadio.SelectedIndexChanged += new System.EventHandler(this.ShowProperties);
            this.PendingListRadio.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PendingListDoubleClick);
            // 
            // SortRadioLabel
            // 
            this.SortRadioLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortRadioLabel.Location = new System.Drawing.Point(10, 12);
            this.SortRadioLabel.Name = "SortRadioLabel";
            this.SortRadioLabel.Size = new System.Drawing.Size(325, 40);
            this.SortRadioLabel.TabIndex = 34;
            this.SortRadioLabel.Text = "Sort Radio Channels";
            this.SortRadioLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PendingLabelRadio
            // 
            this.PendingLabelRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PendingLabelRadio.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PendingLabelRadio.Location = new System.Drawing.Point(610, 52);
            this.PendingLabelRadio.Name = "PendingLabelRadio";
            this.PendingLabelRadio.Size = new System.Drawing.Size(186, 26);
            this.PendingLabelRadio.TabIndex = 33;
            this.PendingLabelRadio.Text = "PENDING";
            this.PendingLabelRadio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // SortedLabelRadio
            // 
            this.SortedLabelRadio.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortedLabelRadio.Location = new System.Drawing.Point(12, 52);
            this.SortedLabelRadio.Name = "SortedLabelRadio";
            this.SortedLabelRadio.Size = new System.Drawing.Size(186, 26);
            this.SortedLabelRadio.TabIndex = 32;
            this.SortedLabelRadio.Text = "SORTED";
            this.SortedLabelRadio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ToolBoxRadioPanel
            // 
            this.ToolBoxRadioPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ToolBoxRadioPanel.Controls.Add(this.AddAllRadio);
            this.ToolBoxRadioPanel.Controls.Add(this.AddAlpRadio);
            this.ToolBoxRadioPanel.Controls.Add(this.DelChannelRadio);
            this.ToolBoxRadioPanel.Controls.Add(this.DelAllRadio);
            this.ToolBoxRadioPanel.Location = new System.Drawing.Point(9, 519);
            this.ToolBoxRadioPanel.Name = "ToolBoxRadioPanel";
            this.ToolBoxRadioPanel.Size = new System.Drawing.Size(546, 138);
            this.ToolBoxRadioPanel.TabIndex = 37;
            this.ToolBoxRadioPanel.TabStop = false;
            this.ToolBoxRadioPanel.Text = "ToolBox";
            // 
            // AddAllRadio
            // 
            this.AddAllRadio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddAllRadio.BackColor = System.Drawing.SystemColors.Control;
            this.AddAllRadio.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AddAllRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddAllRadio.Location = new System.Drawing.Point(10, 52);
            this.AddAllRadio.Name = "AddAllRadio";
            this.AddAllRadio.Size = new System.Drawing.Size(120, 35);
            this.AddAllRadio.TabIndex = 30;
            this.AddAllRadio.Text = "Add all";
            this.AddAllRadio.UseVisualStyleBackColor = false;
            this.AddAllRadio.Click += new System.EventHandler(this.AddAllUnsorted);
            // 
            // AddAlpRadio
            // 
            this.AddAlpRadio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddAlpRadio.BackColor = System.Drawing.SystemColors.Control;
            this.AddAlpRadio.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AddAlpRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddAlpRadio.Location = new System.Drawing.Point(136, 52);
            this.AddAlpRadio.Name = "AddAlpRadio";
            this.AddAlpRadio.Size = new System.Drawing.Size(140, 35);
            this.AddAlpRadio.TabIndex = 29;
            this.AddAlpRadio.Text = "Add in alp. Order";
            this.AddAlpRadio.UseVisualStyleBackColor = false;
            this.AddAlpRadio.Click += new System.EventHandler(this.AddAllChannels);
            // 
            // DelChannelRadio
            // 
            this.DelChannelRadio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DelChannelRadio.BackColor = System.Drawing.SystemColors.Control;
            this.DelChannelRadio.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DelChannelRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelChannelRadio.Location = new System.Drawing.Point(427, 52);
            this.DelChannelRadio.Name = "DelChannelRadio";
            this.DelChannelRadio.Size = new System.Drawing.Size(110, 35);
            this.DelChannelRadio.TabIndex = 27;
            this.DelChannelRadio.Text = "Delete";
            this.DelChannelRadio.UseVisualStyleBackColor = false;
            this.DelChannelRadio.Click += new System.EventHandler(this.Delete);
            // 
            // DelAllRadio
            // 
            this.DelAllRadio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DelAllRadio.BackColor = System.Drawing.SystemColors.Control;
            this.DelAllRadio.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DelAllRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelAllRadio.Location = new System.Drawing.Point(282, 52);
            this.DelAllRadio.Name = "DelAllRadio";
            this.DelAllRadio.Size = new System.Drawing.Size(139, 35);
            this.DelAllRadio.TabIndex = 28;
            this.DelAllRadio.Text = "Delete All Shown";
            this.DelAllRadio.UseVisualStyleBackColor = false;
            this.DelAllRadio.Click += new System.EventHandler(this.DeleteAllShown);
            // 
            // ChanInfoRadioPanel
            // 
            this.ChanInfoRadioPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ChanInfoRadioPanel.Controls.Add(this.ChanInfoLabelRadio);
            this.ChanInfoRadioPanel.Controls.Add(this.EditChanPropRadio);
            this.ChanInfoRadioPanel.Location = new System.Drawing.Point(570, 519);
            this.ChanInfoRadioPanel.Name = "ChanInfoRadioPanel";
            this.ChanInfoRadioPanel.Size = new System.Drawing.Size(229, 138);
            this.ChanInfoRadioPanel.TabIndex = 38;
            this.ChanInfoRadioPanel.TabStop = false;
            this.ChanInfoRadioPanel.Text = "Channel Information";
            // 
            // ChanInfoLabelRadio
            // 
            this.ChanInfoLabelRadio.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChanInfoLabelRadio.Location = new System.Drawing.Point(6, 22);
            this.ChanInfoLabelRadio.Name = "ChanInfoLabelRadio";
            this.ChanInfoLabelRadio.Size = new System.Drawing.Size(217, 77);
            this.ChanInfoLabelRadio.TabIndex = 1;
            this.ChanInfoLabelRadio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EditChanPropRadio
            // 
            this.EditChanPropRadio.BackColor = System.Drawing.SystemColors.Control;
            this.EditChanPropRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditChanPropRadio.Location = new System.Drawing.Point(6, 102);
            this.EditChanPropRadio.Name = "EditChanPropRadio";
            this.EditChanPropRadio.Size = new System.Drawing.Size(217, 30);
            this.EditChanPropRadio.TabIndex = 0;
            this.EditChanPropRadio.Text = "Edit Channel Properties";
            this.EditChanPropRadio.UseVisualStyleBackColor = false;
            // 
            // SortRadioChannels
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(808, 669);
            this.Controls.Add(this.ChanInfoRadioPanel);
            this.Controls.Add(this.ToolBoxRadioPanel);
            this.Controls.Add(this.SearchPendingRadio);
            this.Controls.Add(this.FilterTextRadio);
            this.Controls.Add(this.SorterRadio);
            this.Controls.Add(this.SortRadioLabel);
            this.Controls.Add(this.PendingLabelRadio);
            this.Controls.Add(this.SortedLabelRadio);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SortRadioChannels";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sort Radio Channels";
            this.SorterRadio.ResumeLayout(false);
            this.ToolBoxRadioPanel.ResumeLayout(false);
            this.ChanInfoRadioPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SearchPendingRadio;
        private System.Windows.Forms.TextBox FilterTextRadio;
        private System.Windows.Forms.TableLayoutPanel SorterRadio;
        private System.Windows.Forms.Label SortRadioLabel;
        private System.Windows.Forms.Label PendingLabelRadio;
        private System.Windows.Forms.Label SortedLabelRadio;
        public System.Windows.Forms.ListBox FinallyListRadio;
        public System.Windows.Forms.ListBox PendingListRadio;
        private System.Windows.Forms.GroupBox ToolBoxRadioPanel;
        private System.Windows.Forms.Button AddAllRadio;
        private System.Windows.Forms.Button AddAlpRadio;
        private System.Windows.Forms.Button DelChannelRadio;
        private System.Windows.Forms.Button DelAllRadio;
        private System.Windows.Forms.GroupBox ChanInfoRadioPanel;
        private System.Windows.Forms.Label ChanInfoLabelRadio;
        private System.Windows.Forms.Button EditChanPropRadio;
    }
}