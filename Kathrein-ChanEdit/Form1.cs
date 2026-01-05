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
using Kathrein_RecBrowser;

namespace Kathrein_ChanEdit
{
    public partial class Form1 : Form
    {
        public static ServiceList CurrentConfig;

        public static List<string> TVChannels = new List<string>();
        public static List<string> RadioChannels = new List<string>();
        public static List<string> DataChannels = new List<string>();
        public static List<string> SortedTVChannels = new List<string>();
        public static List<string> SortedRadioChannels = new List<string>();
        public static List<string> SortedDataChannels = new List<string>();

        public static SortTVChannels SortTVChannels = new SortTVChannels();
        public static SortRadioChannels SortRadioChannels = new SortRadioChannels();
        public static SortDataChannels SortDataChannels = new SortDataChannels();
        public static EditSatellites EditSatellites = new EditSatellites();
        public static Kathrein_RecBrowser.Form1 KathreinRecBrowser = new Kathrein_RecBrowser.Form1();

        public Form1()
        {
            InitializeComponent();
            OpenAllWindows();
            LoadButtonClicked(null, null);
        }

        private void OpenAllWindows()
        {
            KathreinRecBrowser.FormBorderStyle = FormBorderStyle.None;

            SortTVChannels.Dock = DockStyle.Fill;
            SortRadioChannels.Dock = DockStyle.Fill;
            SortDataChannels.Dock = DockStyle.Fill;
            EditSatellites.Dock = DockStyle.Fill;
            KathreinRecBrowser.Dock = DockStyle.Fill;

            SortTVChannels.TopLevel = false;
            SortRadioChannels.TopLevel = false;
            SortDataChannels.TopLevel = false;
            EditSatellites.TopLevel = false;
            KathreinRecBrowser.TopLevel = false;

            WindowsPanel.Controls.Add(SortTVChannels);
            WindowsPanel.Controls.Add(SortRadioChannels);
            WindowsPanel.Controls.Add(SortDataChannels);
            WindowsPanel.Controls.Add(EditSatellites);
            WindowsPanel.Controls.Add(KathreinRecBrowser);

            SortTVChannels.Show();
            SortRadioChannels.Show();
            SortDataChannels.Show();
            EditSatellites.Show();
            KathreinRecBrowser.Show();

            OpenTVChannels(null, null);
        }

        private void LoadButtonClicked(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML|*.xml";
            ofd.Multiselect = false;
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                CurrentConfig = ServiceList.Load(ofd.FileName);
                EditSatellites.LoadSatellites(sender, e);

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

        private ServiceList PrepForSave()
        {
            ServiceList edited = new ServiceList();
            edited.Overview = CurrentConfig.Overview;
            edited.Satellites = CurrentConfig.Satellites;
            edited.Transponders = CurrentConfig.Transponders;
            edited.Favorites = CurrentConfig.Favorites;

            foreach (Service serv in CurrentConfig.Service)
            {
                if (serv.ServiceType.ToUpper() != "TV" && serv.ServiceType.ToUpper() != "RADIO" && serv.ServiceType.ToUpper() != "DATA")
                {
                    edited.Service.Add(serv);
                }
            }

            int j = 1;
            foreach (object obj in SortTVChannels.FinallyListTV.Items)
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
            foreach (object obj in SortRadioChannels.FinallyListRadio.Items)
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

            int l = 1;
            foreach (object obj in SortDataChannels.FinallyListData.Items)
            {
                string ident = (string)obj;
                Service serv = GetChannelByIdent(ident, "DATA");

                if (serv != null)
                {
                    serv.ChannelNo = l;
                    edited.Service.Add(serv);
                    l++;
                }
            }

            return edited;
        }

        public static Service GetChannelByIdent(string ident, string ServiceType)
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

        public static Satellite GetSatelliteBySatId(int satid)
        {
            foreach(Satellite sat in CurrentConfig.Satellites)
            {
                if(sat.SatID == satid)
                {
                    return sat;
                }
            }

            return null;
        }

        public static Transponder GetTransponderByFrequency(int freq, int satid)
        {
            foreach (Transponder tp in CurrentConfig.Transponders)
            {
                if(tp.SatID == satid && tp.Frequency == freq)
                {
                    return tp;
                }
            }

            return null;
        }

        private void AllChannelsPending()
        {
            TVChannels = new List<string>();
            RadioChannels = new List<string>();
            DataChannels = new List<string>();
            SortedTVChannels = new List<string>();
            SortedRadioChannels = new List<string>();
            SortedDataChannels = new List<string>();

            SortTVChannels.ChannelsPending();
            SortRadioChannels.ChannelsPending();
            SortDataChannels.ChannelsPending();
        }

        private void QuickSaveButtonClicked(object sender, EventArgs e)
        {
            string tmp = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\KCE-Quicksave.xml";

            PrepForSave().Save(tmp);

            CurrentConfig = ServiceList.Load(tmp);

            AllChannelsPending();
        }

        private void ExitButtonClicked(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OpenTVChannels(object sender, EventArgs e)
        {
            SortTVChannels.BringToFront();
        }

        private void OpenRadioChannels(object sender, EventArgs e)
        {
            SortRadioChannels.BringToFront();
        }

        private void OpenDataChannels(object sender, EventArgs e)
        {
            SortDataChannels.BringToFront();
        }

        private void OpenTransponders(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void OpenSatellites(object sender, EventArgs e)
        {
            EditSatellites.BringToFront();
        }

        private void OpenRecBrowser(object sender, EventArgs e)
        {
            KathreinRecBrowser.BringToFront();
        }
    }
}
