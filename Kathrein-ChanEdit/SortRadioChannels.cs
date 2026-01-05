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
    public partial class SortRadioChannels : Form
    {
        public SortRadioChannels()
        {
            InitializeComponent();
        }

        public void ChannelsPending()
        {
            FinallyListRadio.Items.Clear();
            PendingListRadio.Items.Clear();

            List<string> RADIOChannels = new List<string>();

            foreach (Service channel in Form1.CurrentConfig.Service)
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
                Form1.RadioChannels.Add(channel);
            }
        }

        private void SearchChannel(object sender, EventArgs e)
        {
            PendingListRadio.Items.Clear();

            if (string.IsNullOrWhiteSpace(FilterTextRadio.Text))
            {
                foreach (string itm in Form1.RadioChannels)
                {
                    _ = PendingListRadio.Items.Add(itm);
                }

                return;
            }

            string[] filter = FilterTextRadio.Text.ToUpper().Split(new char[] { ' ' });
            foreach (string itm in Form1.RadioChannels)
            {
                if (IsValidFilter(filter, itm))
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

        private void DeleteAllShown(object sender, EventArgs e)
        {
            foreach (object itm in PendingListRadio.Items)
            {
                string ident = (string)itm;
                _ = Form1.RadioChannels.Remove(ident);
            }

            SearchChannel(sender, e);
        }

        private void PendingListDoubleClick(object sender, MouseEventArgs e)
        {
            int index = PendingListRadio.IndexFromPoint(e.Location);

            if (index != ListBox.NoMatches)
            {
                AddChannel(PendingListRadio.Items[index].ToString());
            }

            SearchChannel(sender, e);
        }

        private void FinallyListDoubleClick(object sender, MouseEventArgs e)
        {
            int index = FinallyListRadio.IndexFromPoint(e.Location);

            if (index != ListBox.NoMatches)
            {
                string selectedItem = FinallyListRadio.Items[index].ToString();
                Form1.RadioChannels.Add(selectedItem);
                FinallyListRadio.Items.Remove(selectedItem);
                _ = Form1.SortedRadioChannels.Remove(selectedItem);
            }

            SearchChannel(sender, e);
        }

        private void AddChannel(string channel)
        {
            string selectedItem = channel;
            _ = Form1.RadioChannels.Remove(selectedItem);
            _ = FinallyListRadio.Items.Add(selectedItem);
            Form1.SortedRadioChannels.Add(selectedItem);
        }

        private void AddAllUnsorted(object sender, EventArgs e)
        {
            string[] strings = new string[Form1.RadioChannels.Count];
            int index = 0;
            foreach (object itm in PendingListRadio.Items)
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

        }

        private void Delete(object sender, EventArgs e)
        {
            string selectedItem = (string)PendingListRadio.SelectedItem;
            _ = Form1.RadioChannels.Remove(selectedItem);
            SearchChannel(sender, e);
        }

        private void ShowProperties(object sender, EventArgs e)
        {
            string selectedItem = (string)((ListBox)sender).SelectedItem;
            Service channel = Form1.GetChannelByIdent(selectedItem, "RADIO");
            Satellite sat = Form1.GetSatelliteBySatId(channel.SatId);
            Transponder tp = Form1.GetTransponderByFrequency(channel.Frequency, channel.SatId);
            ChanInfoLabelRadio.Text = $"{sat.SatName}\r\n" +
                $"{tp.Frequency} MHz - {tp.Polarisation} - {tp.SymbolRate} kS/s\r\n" +
                $"V/A/Pcr {channel.VideoPid} / {channel.AudioPid} / {channel.PcrPid}";
        }

        public void ReloadFromList()
        {
            PendingListRadio.Items.Clear();
            FinallyListRadio.Items.Clear();

            foreach (string ident in Form1.RadioChannels)
            {
                _ = PendingListRadio.Items.Add(ident);
            }

            foreach (string ident in Form1.SortedRadioChannels)
            {
                _ = FinallyListRadio.Items.Add(ident);
            }
        }
    }
}
