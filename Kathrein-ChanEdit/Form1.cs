using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kathrein_ChanEdit
{
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
                this.TVChannels.Add(channel);
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
    }
}
