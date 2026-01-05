using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kathrein_ChanEdit
{
    public partial class SortTVChannels : Form
    {
        public SortTVChannels()
        {
            InitializeComponent();
        }

        public void ChannelsPending()
        {
            FinallyListTV.Items.Clear();
            PendingListTV.Items.Clear();

            List<string> TVChannels = new List<string>();

            foreach (Service channel in Form1.CurrentConfig.Service)
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
                Form1.TVChannels.Add(channel);
            }
        }

        private void SearchChannel(object sender, EventArgs e)
        {
            PendingListTV.Items.Clear();

            if (string.IsNullOrWhiteSpace(FilterTextTV.Text))
            {
                foreach (string itm in Form1.TVChannels)
                {
                    _ = PendingListTV.Items.Add(itm);
                }

                return;
            }

            string[] filter = FilterTextTV.Text.ToUpper().Split(new char[] { ' ' });
            foreach (string itm in Form1.TVChannels)
            {
                if (IsValidFilter(filter, itm))
                {
                    _ = PendingListTV.Items.Add(itm);
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

        private void DeleteAllShown(object sender, EventArgs e)
        {
            foreach (object itm in PendingListTV.Items)
            {
                string ident = (string)itm;
                _ = Form1.TVChannels.Remove(ident);
            }

            SearchChannel(sender, e);
        }

        private void PendingListDoubleClick(object sender, MouseEventArgs e)
        {
            int index = PendingListTV.IndexFromPoint(e.Location);

            if (index != ListBox.NoMatches)
            {
                AddChannel(PendingListTV.Items[index].ToString());
            }

            SearchChannel(sender, e);
        }

        private void FinallyListDoubleClick(object sender, MouseEventArgs e)
        {
            int index = FinallyListTV.IndexFromPoint(e.Location);

            if (index != ListBox.NoMatches)
            {
                string selectedItem = FinallyListTV.Items[index].ToString();
                Form1.TVChannels.Add(selectedItem);
                FinallyListTV.Items.Remove(selectedItem);
                _ = Form1.SortedTVChannels.Remove(selectedItem);
            }

            SearchChannel(sender, e);
        }

        private void AddChannel(string channel)
        {
            string selectedItem = channel;
            _ = Form1.TVChannels.Remove(selectedItem);
            _ = FinallyListTV.Items.Add(selectedItem);
            Form1.SortedTVChannels.Add(selectedItem);
        }

        private void AddAllUnsorted(object sender, EventArgs e)
        {
            string[] strings = new string[Form1.TVChannels.Count];
            int index = 0;
            foreach (object itm in PendingListTV.Items)
            {
                string ident = (string)itm;
                strings[index] = ident;
                index++;
            }

            foreach (string ident in strings)
            {
                AddChannel(ident);
            }

            SearchChannel(sender, e);
        }

        private void AddAllChannels(object sender, EventArgs e)
        {
            string[] strings = new string[Form1.TVChannels.Count];
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
                AddChannel(ident);
            }

            SearchChannel(sender, e);
        }

        private void Delete(object sender, EventArgs e)
        {
            string selectedItem = (string)PendingListTV.SelectedItem;
            _ = Form1.TVChannels.Remove(selectedItem);
            SearchChannel(sender, e);
        }

        private void ShowProperties(object sender, EventArgs e)
        {
            string selectedItem = (string)((ListBox)sender).SelectedItem;
            Service channel = Form1.GetChannelByIdent(selectedItem, "TV");
            Satellite sat = Form1.GetSatelliteBySatId(channel.SatId);
            Transponder tp = Form1.GetTransponderByFrequency(channel.Frequency, channel.SatId);
            ChanInfoLabelTV.Text = $"{sat.SatName}\r\n" +
                $"{tp.Frequency} MHz - {tp.Polarisation} - {tp.SymbolRate} kS/s\r\n" +
                $"V/A/Pcr {channel.VideoPid} / {channel.AudioPid} / {channel.PcrPid}";
        }

        public void ReloadFromList()
        {
            PendingListTV.Items.Clear();
            FinallyListTV.Items.Clear();

            foreach (string ident in Form1.TVChannels)
            {
                _ = PendingListTV.Items.Add(ident);
            }

            foreach(string ident in Form1.SortedTVChannels)
            {
                _ = FinallyListTV.Items.Add(ident);
            }
        }
    }
}
