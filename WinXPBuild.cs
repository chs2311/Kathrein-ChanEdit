using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Kathrein_ChanEdit_WinXP
{
    internal static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public partial class Form1 : Form
    {
        public ServiceList CurrentConfig;

        List<string> TVChannels = new List<string>();
        List<string> RadioChannels = new List<string>();

        List<string> SortedTVChannels = new List<string>();
        List<string> SortedRadioChannels = new List<string>();

        public Form1()
        {
            InitializeComponent();
            LoadButtonClicked(null, null);
        }

        private void LoadButtonClicked(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML|*.xml";
            ofd.Multiselect = false;
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                CurrentConfig = ServiceList.Load(ofd.FileName);

                AllChannelsPending();
            }
        }

        private void SaveButtonClicked(object sender, EventArgs e)
        {
            ServiceList edited = PrepForSave();

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML|*.xml";
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                edited.Save(sfd.FileName);
            }
        }

        private Service GetChannelByIdent(string ident, string ServiceType)
        {
            foreach (Service serv in CurrentConfig.Service)
            {
                if(serv.ServiceType.ToUpper() == ServiceType)
                {
                    if(serv.IsIdent(ident))
                    {
                        return serv;
                    }
                }
            }

            return null;
        }

        private void AllChannelsPending()
        {
            TVChannels = new List<string>();
            RadioChannels = new List<string>();
            SortedTVChannels = new List<string>();
            SortedRadioChannels = new List<string>();

            TVChannelsPending();
            RadioChannelsPending();
        }

        private void TVChannelsPending()
        {
            FinallyListTV.Items.Clear();
            PendingListTV.Items.Clear();

            List<string> TVChannels = new List<string>();

            foreach (Service channel in CurrentConfig.Service)
            {
                string type = channel.ServiceType.ToUpper();

                if (type == "TV")
                {
                    TVChannels.Add(channel.GetIdent());
                }
            }

            foreach (string channel in TVChannels)
            {
                _ = PendingListTV.Items.Add(channel);
                TVChannels.Add(channel);
            }
        }

        private void RadioChannelsPending()
        {
            FinallyListRadio.Items.Clear();
            PendingListRadio.Items.Clear();

            List<string> RADIOChannels = new List<string>();

            foreach (Service channel in CurrentConfig.Service)
            {
                string type = channel.ServiceType.ToUpper();

                if (type == "RADIO")
                {
                    RADIOChannels.Add(channel.GetIdent());
                }
            }

            foreach (string channel in RADIOChannels)
            {
                _ = PendingListRadio.Items.Add(channel);
                RadioChannels.Add(channel);
            }
        }

        private void SearchTVChannel(object sender, EventArgs e)
        {
            PendingListTV.Items.Clear();

            if (string.IsNullOrWhiteSpace(FilterTextTV.Text))
            {
                foreach (string itm in TVChannels)
                {
                    _ = PendingListTV.Items.Add(itm);
                }

                return;
            }

            string[] filter = FilterTextTV.Text.ToUpper().Split(new char[] { ' ' });
            foreach (string itm in TVChannels)
            {
                if (IsValidFilter(filter, itm))
                {
                    _ = PendingListTV.Items.Add(itm);
                }
            }
        }

        private void SearchRadioChannel(object sender, EventArgs e)
        {
            PendingListRadio.Items.Clear();

            if (string.IsNullOrWhiteSpace(FilterTextRadio.Text))
            {
                foreach(string itm in RadioChannels)
                {
                    _ = PendingListRadio.Items.Add(itm);
                }

                return;
            }

            string[] filter = FilterTextRadio.Text.ToUpper().Split(new char[] { ' ' });
            foreach (string itm in RadioChannels)
            {
                if(IsValidFilter(filter, itm))
                {
                    _ = PendingListRadio.Items.Add(itm);
                }
            }
        }

        private bool IsValidFilter(string[] filter, string input)
        {
            string text = input.Substring(8);
            foreach (string f in filter)
            {
                if (!string.IsNullOrWhiteSpace(f))
                {
                    if (!text.ToUpper().Contains(f.ToUpper()))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private void DeleteAllShownTV(object sender, EventArgs e)
        {
            foreach(object itm in PendingListTV.Items)
            {
                string ident = (string)itm;
                _ = TVChannels.Remove(ident);
            }

            SearchTVChannel(sender, e);
        }

        private void DeleteAllShownRadio(object sender, EventArgs e)
        {
            foreach (object itm in PendingListRadio.Items)
            {
                string ident = (string)itm;
                _ = RadioChannels.Remove(ident);
            }

            SearchRadioChannel(sender, e);
        }

        private void PendingListTVDoubleClick(object sender, MouseEventArgs e)
        {
            int index = PendingListTV.IndexFromPoint(e.Location);

            if (index != ListBox.NoMatches)
            {
                AddTVChannel(PendingListTV.Items[index].ToString());
            }

            SearchTVChannel(sender, e);
        }

        private void PendingListRadioDoubleClick(object sender, MouseEventArgs e)
        {
            int index = PendingListRadio.IndexFromPoint(e.Location);

            if (index != ListBox.NoMatches)
            {
                AddRadioChannel(PendingListRadio.Items[index].ToString());
            }

            SearchRadioChannel(sender, e);
        }

        private void FinallyListTVDoubleClick(object sender, MouseEventArgs e)
        {
            int index = FinallyListTV.IndexFromPoint(e.Location);

            if (index != ListBox.NoMatches)
            {
                string selectedItem = FinallyListTV.Items[index].ToString();
                TVChannels.Add(selectedItem);
                FinallyListTV.Items.Remove(selectedItem);
                _ = SortedTVChannels.Remove(selectedItem);
            }

            SearchTVChannel(sender, e);
        }

        private void FinallyListRadioDoubleClick(object sender, MouseEventArgs e)
        {
            int index = FinallyListRadio.IndexFromPoint(e.Location);

            if (index != ListBox.NoMatches)
            {
                string selectedItem = FinallyListRadio.Items[index].ToString() ;
                RadioChannels.Add(selectedItem);
                FinallyListRadio.Items.Remove(selectedItem);
                _ = SortedRadioChannels.Remove(selectedItem);
            }

            SearchRadioChannel(sender, e);
        }

        private void AddTVChannel(string channel)
        {
            string selectedItem = channel;
            _ = TVChannels.Remove(selectedItem);
            _ = FinallyListTV.Items.Add(selectedItem);
            SortedTVChannels.Add(selectedItem);
        }

        private void AddRadioChannel(string channel)
        {
            string selectedItem = channel;
            _ = RadioChannels.Remove(selectedItem);
            _ = FinallyListRadio.Items.Add(selectedItem);
            SortedRadioChannels.Add(selectedItem);
        }

        private void AddAllTVChannels(object sender, EventArgs e)
        {
            string[] strings = new string[TVChannels.Count];
            int index = 0;
            foreach (object itm in PendingListTV.Items)
            {
                string ident = (string)itm;
                strings[index] = ident;
                index++;
            }

            List<string> sorted = strings
            .Where(s =>
            {
                return s != null;
            }).OrderBy(s =>
            {
                return s.Length > 10 ? s.Substring(13) : s;
            })
            .ToList();

            foreach (string ident in sorted)
            {
                AddTVChannel(ident);
            }

            SearchTVChannel(sender, e);
        }

        private void AddAllRadioChannels(object sender, EventArgs e)
        {
            string[] strings = new string[RadioChannels.Count];
            int index = 0;
            foreach (object itm in PendingListRadio.Items)
            {
                string ident = (string)itm;
                strings[index] = ident;
                index++;
            }

            List<string> sorted = strings
            .Where(s =>
            {
                return s != null;
            }).OrderBy(s =>
            {
                return s.Length > 10 ? s.Substring(10) : s;
            })
            .ToList();

            foreach (string ident in sorted)
            {
                AddRadioChannel(ident);
            }

            SearchRadioChannel(sender, e);
        }

        private void DeleteTV(object sender, EventArgs e)
        {
            string selectedItem = (string)PendingListTV.SelectedItem;
            _ = TVChannels.Remove(selectedItem);
            SearchTVChannel(sender, e);
        }

        private void DeleteRadio(object sender, EventArgs e)
        {
            string selectedItem = (string)PendingListRadio.SelectedItem;
            _ = RadioChannels.Remove(selectedItem);
            SearchRadioChannel(sender, e);
        }

        private void QuickSaveButtonClicked(object sender, EventArgs e)
        {
            string tmp = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\KCE-Quicksave.xml";

            PrepForSave().Save(tmp);

            CurrentConfig = ServiceList.Load(tmp);

            AllChannelsPending();
        }

        private ServiceList PrepForSave()
        {
            ServiceList edited = new ServiceList();
            edited.Overview = CurrentConfig.Overview;
            edited.Satellites = CurrentConfig.Satellites;
            edited.Transponders = CurrentConfig.Transponders;
            edited.Favorites = CurrentConfig.Favorites;

            foreach (Service serv in CurrentConfig.Service)
            {
                if (serv.ServiceType.ToUpper() != "TV" && serv.ServiceType.ToUpper() != "RADIO")
                {
                    edited.Service.Add(serv);
                }
            }

            int j = 1;
            foreach (object obj in FinallyListTV.Items)
            {
                string ident = (string)obj;
                Service serv = GetChannelByIdent(ident, "TV");

                if (serv != null)
                {
                    serv.ChannelNo = j;
                    edited.Service.Add(serv);
                    j++;
                }
            }

            int k = 1;
            foreach (object obj in FinallyListRadio.Items)
            {
                string ident = (string)obj;
                Service serv = GetChannelByIdent(ident, "RADIO");

                if (serv != null)
                {
                    serv.ChannelNo = k;
                    edited.Service.Add(serv);
                    k++;
                }
            }

            return edited;
        }

        private void AddAllUnsortedTV(object sender, EventArgs e)
        {
            string[] strings = new string[TVChannels.Count];
            int index = 0;
            foreach (object itm in PendingListTV.Items)
            {
                string ident = (string)itm;
                strings[index] = ident;
                index++;
            }

            foreach (string ident in strings)
            {
                AddTVChannel(ident);
            }

            SearchTVChannel(sender, e);
        }

        private void AddAllRadioUnsorted(object sender, EventArgs e)
        {
            string[] strings = new string[RadioChannels.Count];
            int index = 0;
            foreach (object itm in PendingListRadio.Items)
            {
                string ident = (string)itm;
                strings[index] = ident;
                index++;
            }

            foreach (string ident in strings)
            {
                AddRadioChannel(ident);
            }

            SearchRadioChannel(sender, e);
        }

        private void InsertTV(object sender, EventArgs e)
        {
            string cbtext = Clipboard.GetText();
            string[] idents = cbtext.Split(';');

            foreach (string ident in idents)
            {
                if (string.IsNullOrEmpty(ident))
                {
                    continue;
                }

                _ = FinallyListTV.Items.Add(ident);
                SortedTVChannels.Add(ident);
            }
        }

        private void InsertRadio(object sender, EventArgs e)
        {
            string cbtext = Clipboard.GetText();
            string[] idents = cbtext.Split(';');

            foreach (string ident in idents)
            {
                if(string.IsNullOrEmpty(ident))
                { 
                    continue; 
                }

                _ = FinallyListRadio.Items.Add(ident);
                SortedRadioChannels.Add(ident);
            }
        }

        private void CopyCBTV(object sender, EventArgs e)
        {
            string cbtext = "";
            foreach(object obj in FinallyListTV.Items)
            {
                string ident = (string)obj;
                cbtext += ident + ";";
            }

            Clipboard.SetText(cbtext);
        }

        private void CopyCBRadio(object sender, EventArgs e)
        {
            string cbtext = "";
            foreach (object obj in FinallyListRadio.Items)
            {
                string ident = (string)obj;
                cbtext += ident + ";";
            }

            Clipboard.SetText(cbtext);
        }

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
            TopPanel = new System.Windows.Forms.Panel();
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            TitleLabel = new System.Windows.Forms.Label();
            MainPanel = new System.Windows.Forms.TableLayoutPanel();
            groupBox1 = new System.Windows.Forms.GroupBox();
            button7 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            button6 = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            FilterTextTV = new System.Windows.Forms.TextBox();
            SorterTV = new System.Windows.Forms.TableLayoutPanel();
            FinallyListTV = new System.Windows.Forms.ListBox();
            PendingListTV = new System.Windows.Forms.ListBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            button8 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            FilterTextRadio = new System.Windows.Forms.TextBox();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            FinallyListRadio = new System.Windows.Forms.ListBox();
            PendingListRadio = new System.Windows.Forms.ListBox();
            button9 = new System.Windows.Forms.Button();
            button10 = new System.Windows.Forms.Button();
            button11 = new System.Windows.Forms.Button();
            button12 = new System.Windows.Forms.Button();
            button13 = new System.Windows.Forms.Button();
            button14 = new System.Windows.Forms.Button();
            button15 = new System.Windows.Forms.Button();
            TopPanel.SuspendLayout();
            MainPanel.SuspendLayout();
            groupBox1.SuspendLayout();
            SorterTV.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
            TopPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            TopPanel.Controls.Add(button9);
            TopPanel.Controls.Add(button2);
            TopPanel.Controls.Add(button1);
            TopPanel.Controls.Add(TitleLabel);
            TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            TopPanel.Location = new System.Drawing.Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new System.Drawing.Size(1097, 60);
            TopPanel.TabIndex = 0;
            // 
            // button2
            // 
            button2.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
            button2.BackColor = System.Drawing.Color.PowderBlue;
            button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Location = new System.Drawing.Point(936, 3);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(75, 52);
            button2.TabIndex = 2;
            button2.Text = "SAVE *.xml";
            button2.UseVisualStyleBackColor = false;
            button2.Click += new System.EventHandler(SaveButtonClicked);
            // 
            // button1
            // 
            button1.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
            button1.BackColor = System.Drawing.Color.PowderBlue;
            button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Location = new System.Drawing.Point(1017, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 52);
            button1.TabIndex = 1;
            button1.Text = "LOAD *.xml";
            button1.UseVisualStyleBackColor = false;
            button1.Click += new System.EventHandler(LoadButtonClicked);
            // 
            // TitleLabel
            // 
            TitleLabel.Anchor = (System.Windows.Forms.AnchorStyles)System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            TitleLabel.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            TitleLabel.Location = new System.Drawing.Point(0, 0);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new System.Drawing.Size(820, 58);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Kathrein Channel Editor";
            TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainPanel
            // 
            MainPanel.ColumnCount = 2;
            _ = MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            _ = MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            _ = MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            MainPanel.Controls.Add(groupBox1, 0, 0);
            MainPanel.Controls.Add(groupBox2, 1, 0);
            MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            MainPanel.Location = new System.Drawing.Point(0, 60);
            MainPanel.Name = "MainPanel";
            MainPanel.RowCount = 1;
            _ = MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            _ = MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            MainPanel.Size = new System.Drawing.Size(1097, 561);
            MainPanel.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button13);
            groupBox1.Controls.Add(button12);
            groupBox1.Controls.Add(button11);
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(FilterTextTV);
            groupBox1.Controls.Add(SorterTV);
            groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox1.Location = new System.Drawing.Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(542, 555);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Television Channels";
            // 
            // button7
            //
            button7.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
            button7.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
            button7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            button7.FlatAppearance.BorderSize = 2;
            button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button7.Location = new System.Drawing.Point(135, 514);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(140, 35);
            button7.TabIndex = 14;
            button7.Text = "Add in alp. Order";
            button7.UseVisualStyleBackColor = false;
            button7.Click += new System.EventHandler(AddAllTVChannels);
            // 
            // button5
            // 
            button5.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
            button5.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            button5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            button5.FlatAppearance.BorderSize = 2;
            button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button5.Location = new System.Drawing.Point(281, 514);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(139, 35);
            button5.TabIndex = 13;
            button5.Text = "Delete All Shown";
            button5.UseVisualStyleBackColor = false;
            button5.Click += new System.EventHandler(DeleteAllShownTV);
            // 
            // button6
            // 
            button6.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
            button6.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            button6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            button6.FlatAppearance.BorderSize = 2;
            button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button6.Location = new System.Drawing.Point(426, 514);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(110, 35);
            button6.TabIndex = 12;
            button6.Text = "Delete";
            button6.UseVisualStyleBackColor = false;
            button6.Click += new System.EventHandler(DeleteTV);
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(347, 85);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(186, 26);
            label4.TabIndex = 4;
            label4.Text = "PENDING";
            label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(9, 85);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(186, 26);
            label3.TabIndex = 3;
            label3.Text = "SORTED";
            label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label1.Location = new System.Drawing.Point(160, 38);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(183, 26);
            label1.TabIndex = 2;
            label1.Text = "Search in Pending:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FilterTextTV
            // 
            FilterTextTV.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            FilterTextTV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            FilterTextTV.Location = new System.Drawing.Point(349, 38);
            FilterTextTV.Name = "FilterTextTV";
            FilterTextTV.Size = new System.Drawing.Size(184, 26);
            FilterTextTV.TabIndex = 1;
            FilterTextTV.TextChanged += new System.EventHandler(SearchTVChannel);
            // 
            // SorterTV
            // 
            SorterTV.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom
            | System.Windows.Forms.AnchorStyles.Left
            | System.Windows.Forms.AnchorStyles.Right;
            SorterTV.ColumnCount = 2;
            _ = SorterTV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            _ = SorterTV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            SorterTV.Controls.Add(FinallyListTV, 0, 0);
            SorterTV.Controls.Add(PendingListTV, 1, 0);
            SorterTV.Location = new System.Drawing.Point(9, 114);
            SorterTV.Name = "SorterTV";
            SorterTV.RowCount = 1;
            _ = SorterTV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            _ = SorterTV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            SorterTV.Size = new System.Drawing.Size(527, 394);
            SorterTV.TabIndex = 0;
            // 
            // FinallyListTV
            // 
            FinallyListTV.Dock = System.Windows.Forms.DockStyle.Fill;
            FinallyListTV.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            FinallyListTV.FormattingEnabled = true;
            FinallyListTV.ItemHeight = 21;
            FinallyListTV.Location = new System.Drawing.Point(3, 3);
            FinallyListTV.Name = "FinallyListTV";
            FinallyListTV.Size = new System.Drawing.Size(257, 388);
            FinallyListTV.TabIndex = 0;
            FinallyListTV.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(FinallyListTVDoubleClick);
            // 
            // PendingListTV
            // 
            PendingListTV.Dock = System.Windows.Forms.DockStyle.Fill;
            PendingListTV.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            PendingListTV.FormattingEnabled = true;
            PendingListTV.ItemHeight = 21;
            PendingListTV.Location = new System.Drawing.Point(266, 3);
            PendingListTV.Name = "PendingListTV";
            PendingListTV.Size = new System.Drawing.Size(258, 388);
            PendingListTV.TabIndex = 1;
            PendingListTV.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(PendingListTVDoubleClick);
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button14);
            groupBox2.Controls.Add(button15);
            groupBox2.Controls.Add(button10);
            groupBox2.Controls.Add(button8);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(FilterTextRadio);
            groupBox2.Controls.Add(tableLayoutPanel1);
            groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox2.Location = new System.Drawing.Point(551, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(543, 555);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Radio Channels";
            // 
            // button8
            // 
            button8.Anchor = System.Windows.Forms.AnchorStyles.Bottom
                | System.Windows.Forms.AnchorStyles.Left;
            button8.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
            button8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            button8.FlatAppearance.BorderSize = 2;
            button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button8.Location = new System.Drawing.Point(130, 511);
            button8.Name = "button8";
            button8.Size = new System.Drawing.Size(140, 35);
            button8.TabIndex = 15;
            button8.Text = "Add in alp. Order";
            button8.UseVisualStyleBackColor = false;
            button8.Click += new System.EventHandler(AddAllRadioChannels);
            // 
            // button4
            // 
            button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            button4.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            button4.FlatAppearance.BorderSize = 2;
            button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button4.Location = new System.Drawing.Point(276, 511);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(139, 35);
            button4.TabIndex = 11;
            button4.Text = "Delete All Shown";
            button4.UseVisualStyleBackColor = false;
            button4.Click += new System.EventHandler(DeleteAllShownRadio);
            // 
            // button3
            // 
            button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            button3.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button3.Location = new System.Drawing.Point(421, 511);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(110, 35);
            button3.TabIndex = 10;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += new System.EventHandler(DeleteRadio);
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(342, 85);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(186, 26);
            label2.TabIndex = 9;
            label2.Text = "PENDING";
            label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label5
            // 
            label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(3, 85);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(186, 26);
            label5.TabIndex = 8;
            label5.Text = "SORTED";
            label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label6
            // 
            label6.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label6.Location = new System.Drawing.Point(155, 38);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(183, 26);
            label6.TabIndex = 7;
            label6.Text = "Search in Pending:";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FilterTextRadio
            // 
            FilterTextRadio.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            FilterTextRadio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            FilterTextRadio.Location = new System.Drawing.Point(344, 38);
            FilterTextRadio.Name = "FilterTextRadio";
            FilterTextRadio.Size = new System.Drawing.Size(184, 26);
            FilterTextRadio.TabIndex = 6;
            FilterTextRadio.TextChanged += new System.EventHandler(SearchRadioChannel);
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom
            | System.Windows.Forms.AnchorStyles.Left
            | System.Windows.Forms.AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            _ = tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            _ = tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(FinallyListRadio, 0, 0);
            tableLayoutPanel1.Controls.Add(PendingListRadio, 1, 0);
            tableLayoutPanel1.Location = new System.Drawing.Point(3, 114);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            _ = tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            _ = tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new System.Drawing.Size(528, 394);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // FinallyListRadio
            // 
            FinallyListRadio.Dock = System.Windows.Forms.DockStyle.Fill;
            FinallyListRadio.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            FinallyListRadio.FormattingEnabled = true;
            FinallyListRadio.ItemHeight = 21;
            FinallyListRadio.Location = new System.Drawing.Point(3, 3);
            FinallyListRadio.Name = "FinallyListRadio";
            FinallyListRadio.Size = new System.Drawing.Size(258, 388);
            FinallyListRadio.TabIndex = 0;
            FinallyListRadio.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(FinallyListRadioDoubleClick);
            // 
            // PendingListRadio
            // 
            PendingListRadio.Dock = System.Windows.Forms.DockStyle.Fill;
            PendingListRadio.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            PendingListRadio.FormattingEnabled = true;
            PendingListRadio.ItemHeight = 21;
            PendingListRadio.Location = new System.Drawing.Point(267, 3);
            PendingListRadio.Name = "PendingListRadio";
            PendingListRadio.Size = new System.Drawing.Size(258, 388);
            PendingListRadio.TabIndex = 1;
            PendingListRadio.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(PendingListRadioDoubleClick);
            // 
            // button9
            // 
            button9.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            button9.BackColor = System.Drawing.Color.PowderBlue;
            button9.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            button9.FlatAppearance.BorderSize = 2;
            button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button9.Location = new System.Drawing.Point(855, 3);
            button9.Name = "button9";
            button9.Size = new System.Drawing.Size(75, 52);
            button9.TabIndex = 3;
            button9.Text = "Quick Save";
            button9.UseVisualStyleBackColor = false;
            button9.Click += new System.EventHandler(QuickSaveButtonClicked);
            // 
            // button10
            // 
            button10.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            button10.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
            button10.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            button10.FlatAppearance.BorderSize = 2;
            button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button10.Location = new System.Drawing.Point(3, 511);
            button10.Name = "button10";
            button10.Size = new System.Drawing.Size(121, 35);
            button10.TabIndex = 16;
            button10.Text = "Add all";
            button10.UseVisualStyleBackColor = false;
            button10.Click += new System.EventHandler(AddAllRadioUnsorted);
            // 
            // button11
            // 
            button11.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            button11.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
            button11.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            button11.FlatAppearance.BorderSize = 2;
            button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button11.Location = new System.Drawing.Point(9, 514);
            button11.Name = "button11";
            button11.Size = new System.Drawing.Size(120, 35);
            button11.TabIndex = 17;
            button11.Text = "Add all";
            button11.UseVisualStyleBackColor = false;
            button11.Click += new System.EventHandler(AddAllUnsortedTV);
            // 
            // button12
            // 
            button12.Location = new System.Drawing.Point(4, 25);
            button12.Name = "button12";
            button12.Size = new System.Drawing.Size(157, 26);
            button12.TabIndex = 18;
            button12.Text = "Insert Clipboard";
            button12.UseVisualStyleBackColor = true;
            button12.Click += new System.EventHandler(InsertTV);
            // 
            // button13
            // 
            button13.Location = new System.Drawing.Point(4, 56);
            button13.Name = "button13";
            button13.Size = new System.Drawing.Size(157, 26);
            button13.TabIndex = 19;
            button13.Text = "Copy to Clipboard";
            button13.UseVisualStyleBackColor = true;
            button13.Click += new System.EventHandler(CopyCBTV);
            // 
            // button14
            // 
            button14.Location = new System.Drawing.Point(6, 56);
            button14.Name = "button14";
            button14.Size = new System.Drawing.Size(157, 26);
            button14.TabIndex = 21;
            button14.Text = "Copy to Clipboard";
            button14.UseVisualStyleBackColor = true;
            button14.Click += new System.EventHandler(CopyCBRadio);
            // 
            // button15
            // 
            button15.Location = new System.Drawing.Point(6, 25);
            button15.Name = "button15";
            button15.Size = new System.Drawing.Size(157, 26);
            button15.TabIndex = 20;
            button15.Text = "Insert Clipboard";
            button15.UseVisualStyleBackColor = true;
            button15.Click += new System.EventHandler(InsertRadio);
            // 
            // Form1
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1097, 621);
            Controls.Add(MainPanel);
            Controls.Add(TopPanel);
            Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Kathrein Channel Editor";
            TopPanel.ResumeLayout(false);
            MainPanel.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            SorterTV.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TableLayoutPanel MainPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel SorterTV;
        private System.Windows.Forms.ListBox FinallyListTV;
        private System.Windows.Forms.ListBox PendingListTV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FilterTextTV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox FilterTextRadio;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox FinallyListRadio;
        private System.Windows.Forms.ListBox PendingListRadio;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
    }

    [XmlRoot("Servicelist")]
    public class ServiceList
    {
        [XmlElement("Overview")]
        public Overview Overview { get; set; }

        [XmlElement("Satellite")]
        public List<Satellite> Satellites { get; set; }

        [XmlElement("Transponder")]
        public List<Transponder> Transponders { get; set; }

        [XmlElement("Service")]
        public List<Service> Service { get; set; }

        [XmlElement("Favorite")]
        public List<Favorite> Favorites { get; set; }

        public ServiceList()
        {
            Satellites     = new List<Satellite>();
            Transponders   = new List<Transponder>();
            Service        = new List<Service>();
            Favorites      = new List<Favorite>();
        }

        public void Save(string path)
        {
            try
            {
                using(FileStream FS = new FileStream(path, FileMode.Create, FileAccess.Write))
                {
                    XmlSerializer XS = new XmlSerializer(typeof(ServiceList));
                    XS.Serialize(FS, this);
                }
            }
            catch (Exception ex)
            {
                DialogResult dr = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                
                if(dr == DialogResult.Retry)
                {
                    Save(path);
                }
            }
        }

        public static ServiceList Load(string path)
        {
            try
            {
                using (FileStream FS = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    XmlSerializer XS = new XmlSerializer(typeof(ServiceList));
                    object obj = XS.Deserialize(FS);
                    ServiceList sl = (ServiceList)obj;
                    return sl;
                }
            }
            catch (Exception ex)
            {
                DialogResult dr = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                if (dr == DialogResult.Retry)
                {
                    return Load(path);
                }
                else
                {
                    return new ServiceList();
                }
            }
        }
    }

    public class Overview
    {
        [XmlElement("Version")]
        public string Version { get; set; }

        [XmlElement("Date")]
        public string Date { get; set; }

        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlElement("Author")]
        public string Author { get; set; }

        [XmlElement("Typ")]
        public string Typ { get; set; }

        [XmlElement("Country")]
        public string Country { get; set; }

    }

    public class Satellite
    {
        [XmlElement("SatId")]
        public int SatID { get; set; }

        [XmlElement("SatName")]
        public string SatName { get; set; }

        [XmlElement("LO1Frequency")]
        public int LO1Frequency { get; set; }

        [XmlElement("LO2Frequency")]
        public int LO2Frequency { get; set; }

        [XmlElement("BandSwitchFreq")]
        public int BandSwitchFreq { get; set; }

        [XmlElement("Longitude")]
        public int Longitude { get; set; }

        [XmlElement("SkewOffset")]
        public int SkewOffset { get; set; }
    }

    public class Transponder
    {
        [XmlElement("SatId")]
        public int SatID { get; set; }

        [XmlElement("Frequency")]
        public int Frequency { get; set; }

        [XmlElement("SymbolRate")]
        public int SymbolRate { get; set; }

        [XmlElement("Tsid")]
        public int Tsid { get; set; }

        [XmlElement("Oid")]
        public int Oid { get; set; }

        [XmlElement("Polarisation")]
        public string Polarisation { get; set; }

        [XmlElement("DvbType")]
        public string DvbType { get; set; }

        [XmlElement("Modulation")]
        public string Modulation { get; set; }
    }

    public class Service
    {
        [XmlElement("ChannelNo")]
        public int ChannelNo { get; set; }

        [XmlElement("ServiceName")]
        public string ServiceName { get; set; }

        [XmlElement("ServiceType")]
        public string ServiceType { get; set; }

        [XmlElement("Scrambled")]
        public bool Scrambled { get; set; }

        [XmlElement("SatId")]
        public int SatId { get; set; }

        [XmlElement("Frequency")]
        public int Frequency { get; set; }

        [XmlElement("Sid")]
        public int Sid { get; set; }

        [XmlElement("Tsid")]
        public int Tsid { get; set; }

        [XmlElement("Oid")]
        public int Oid { get; set; }

        [XmlElement("AudioPid")]
        public int AudioPid { get; set; }

        [XmlElement("VideoPid")]
        public int VideoPid { get; set; }

        [XmlElement("PcrPid")]
        public int PcrPid { get; set; }

        [XmlElement("ChildrenLock")]
        public bool ChildrenLock { get; set; }

        [XmlElement("Skip")]
        public bool Skip { get; set; }

        [XmlElement("HD")]
        public bool HD { get; set; }

        [XmlElement("FavoriteNo")]
        public int FavoriteNo { get; set; }

        public string GetIdent()
        {
            return $"#{ChannelNo,5} {(HD ? "HD" : "  ")} | {(Scrambled ? "$" : " ")} {ServiceName}";
        }

        public bool IsIdent(string ident)
        {
            return ident == GetIdent();
        }
    }

    public class Favorite
    {
        [XmlElement("FavoriteNo")]
        public int FavoriteNo { get; set; }

        [XmlElement("ServiceType")]
        public string ServiceType { get; set; }

        [XmlElement("FavoriteName")]
        public string FavoriteName { get; set; }
    }
}
