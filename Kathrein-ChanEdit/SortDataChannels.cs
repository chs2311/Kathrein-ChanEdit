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
    public partial class SortDataChannels : Form
    {
        public SortDataChannels()
        {
            InitializeComponent();
        }

        public void ChannelsPending()
        {
            FinallyListData.Items.Clear();
            PendingListData.Items.Clear();

            List<string> DATAChannels = new List<string>();

            foreach (Service channel in Form1.CurrentConfig.Service)
            {
                string type = channel.ServiceType.ToUpper();

                if (type == "DATA")
                {
                    DATAChannels.Add(channel.GetIdent());
                }
            }

            foreach (string channel in DATAChannels)
            {
                _ = PendingListData.Items.Add(channel);
                Form1.DataChannels.Add(channel);
            }
        }

        private void SearchChannel(object sender, EventArgs e)
        {
            PendingListData.Items.Clear();

            if (string.IsNullOrWhiteSpace(FilterTextData.Text))
            {
                foreach (string itm in Form1.DataChannels)
                {
                    _ = PendingListData.Items.Add(itm);
                }

                return;
            }

            string[] filter = FilterTextData.Text.ToUpper().Split(new char[] { ' ' });
            foreach (string itm in Form1.DataChannels)
            {
                if (IsValidFilter(filter, itm))
                {
                    _ = PendingListData.Items.Add(itm);
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
            foreach (object itm in PendingListData.Items)
            {
                string ident = (string)itm;
                _ = Form1.DataChannels.Remove(ident);
            }

            SearchChannel(sender, e);
        }

        private void PendingListDoubleClick(object sender, MouseEventArgs e)
        {
            int index = PendingListData.IndexFromPoint(e.Location);

            if (index != ListBox.NoMatches)
            {
                AddChannel(PendingListData.Items[index].ToString());
            }

            SearchChannel(sender, e);
        }

        private void FinallyListDoubleClick(object sender, MouseEventArgs e)
        {
            int index = FinallyListData.IndexFromPoint(e.Location);

            if (index != ListBox.NoMatches)
            {
                string selectedItem = FinallyListData.Items[index].ToString();
                Form1.DataChannels.Add(selectedItem);
                FinallyListData.Items.Remove(selectedItem);
                _ = Form1.SortedDataChannels.Remove(selectedItem);
            }

            SearchChannel(sender, e);
        }

        private void AddChannel(string channel)
        {
            string selectedItem = channel;
            _ = Form1.DataChannels.Remove(selectedItem);
            _ = FinallyListData.Items.Add(selectedItem);
            Form1.SortedDataChannels.Add(selectedItem);
        }

        private void AddAllUnsorted(object sender, EventArgs e)
        {
            string[] strings = new string[Form1.DataChannels.Count];
            int index = 0;
            foreach (object itm in PendingListData.Items)
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
            string[] strings = new string[Form1.DataChannels.Count];
            int index = 0;
            foreach (object itm in PendingListData.Items)
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
                AddChannel(ident);
            }

            SearchChannel(sender, e);
        }

        private void Delete(object sender, EventArgs e)
        {
            string selectedItem = (string)PendingListData.SelectedItem;
            _ = Form1.DataChannels.Remove(selectedItem);
            SearchChannel(sender, e);
        }

        private void ShowProperties(object sender, EventArgs e)
        {
            string selectedItem = (string)((ListBox)sender).SelectedItem;
            Service channel = Form1.GetChannelByIdent(selectedItem, "DATA");
            Satellite sat = Form1.GetSatelliteBySatId(channel.SatId);
            Transponder tp = Form1.GetTransponderByFrequency(channel.Frequency, channel.SatId);
            ChanInfoLabelData.Text = $"{sat.SatName}\r\n" +
                $"{tp.Frequency} MHz - {tp.Polarisation} - {tp.SymbolRate} kS/s\r\n" +
                $"V/A/Pcr {channel.VideoPid} / {channel.AudioPid} / {channel.PcrPid}";
        }

        public void ReloadFromList()
        {
            PendingListData.Items.Clear();
            FinallyListData.Items.Clear();

            foreach (string ident in Form1.DataChannels)
            {
                _ = PendingListData.Items.Add(ident);
            }

            foreach (string ident in Form1.SortedDataChannels)
            {
                _ = FinallyListData.Items.Add(ident);
            }
        }
    }
}
