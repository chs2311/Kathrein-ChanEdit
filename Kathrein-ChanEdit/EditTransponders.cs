using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kathrein_ChanEdit
{
    public partial class EditTransponders : Form
    {
        public EditTransponders()
        {
            InitializeComponent();
        }

        public void LoadTransponders(object sender, EventArgs e)
        {
            TPGrid.Rows.Clear();

            foreach(Transponder tp in Form1.CurrentConfig.Transponders)
            {
                _ = TPGrid.Rows.Add($"{tp.SatID} [ {Form1.GetSatelliteBySatId(tp.SatID).SatName} ]", 
                    tp.Frequency, tp.SymbolRate, tp.Tsid, tp.Oid, tp.Polarisation, tp.DvbType, tp.Modulation);
            }
        }

        private bool IsTransponder((int, int) a, (int, int) b)
        {
            return a.Item1 == b.Item1 && a.Item2 == b.Item2;
        }

        private void SaveTransponders(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("If you deleted any transponder, \r\n" +
                "all channels that depend on that one will also be deleted!\r\n" +
                "This action cannot be reversed! and could make your entire Channel Config unusable!\r\n" +
                "\r\n" +
                "Do you still want to continue to save?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(dr == DialogResult.No)
            {
                return;
            }

            List<Transponder> NTP = new List<Transponder>();
            List<(int, int)> RemovedTransponders = new List<(int, int)>();

            for (int i = 0; i < TPGrid.Rows.Count - 1; i++)
            {
                Transponder TP = new Transponder();

                TP.SatID = Convert.ToInt32(((string)TPGrid.Rows[i].Cells[0].Value).Split(' ')[0]);
                TP.Frequency = (int)TPGrid.Rows[i].Cells[1].Value;
                TP.SymbolRate = (int)TPGrid.Rows[i].Cells[2].Value;
                TP.Tsid = (int)TPGrid.Rows[i].Cells[3].Value;
                TP.Oid = (int)TPGrid.Rows[i].Cells[4].Value;
                TP.Polarisation = (string)TPGrid.Rows[i].Cells[5].Value;
                TP.DvbType = (string)TPGrid.Rows[i].Cells[6].Value;
                TP.Modulation = (string)TPGrid.Rows[i].Cells[7].Value;

                NTP.Add(TP);
            }

            for (int i = Form1.CurrentConfig.Satellites.Count - 1; i >= 0; i--)
            {
                Transponder OTP = Form1.CurrentConfig.Transponders[i];

                bool stillExists = NTP.Any(s =>
                {
                    return s.SatID == OTP.SatID && s.Frequency == OTP.Frequency;
                });

                if (!stillExists)
                {
                    RemovedTransponders.Add((OTP.SatID, OTP.Frequency));
                    Form1.CurrentConfig.Satellites.RemoveAt(i);
                }
            }

            foreach (Transponder TP in NTP)
            {
                Transponder OTP = Form1.CurrentConfig.Transponders
                    .FirstOrDefault(s =>
                    {
                        return s.SatID == TP.SatID && s.Frequency == TP.Frequency;
                    });

                if (OTP != null)
                {
                    OTP.SatID = TP.SatID;
                    OTP.Frequency = TP.Frequency;
                    OTP.SymbolRate = TP.SymbolRate;
                    OTP.Tsid = TP.Tsid;
                    OTP.Oid = TP.Oid;
                    OTP.Polarisation = TP.Polarisation;
                    OTP.DvbType = TP.DvbType;
                    OTP.Modulation = TP.Modulation;
                }
                else
                {
                    Form1.CurrentConfig.Transponders.Add(TP);
                }
            }

            for(int k = Form1.CurrentConfig.Service.Count - 1; k >= 0; k--)
            {
                Service serv = Form1.CurrentConfig.Service[k];

                foreach((int, int) Removed in RemovedTransponders)
                {
                    if(IsTransponder(Removed, (serv.SatId, serv.Frequency)))
                    {
                        Form1.CurrentConfig.Service.RemoveAt(k);
                    }
                }
            }

            for(int l = Form1.TVChannels.Count - 1; l >= 0; l--)
            {
                string ident = Form1.TVChannels[l];
                Service serv = Form1.GetChannelByIdent(ident, "TV");

                if(serv == null)
                {
                    Form1.TVChannels.RemoveAt(l);
                }
            }

            for (int l = Form1.RadioChannels.Count - 1; l >= 0; l--)
            {
                string ident = Form1.RadioChannels[l];
                Service serv = Form1.GetChannelByIdent(ident, "RADIO");

                if (serv == null)
                {
                    Form1.RadioChannels.RemoveAt(l);
                }
            }

            for (int l = Form1.DataChannels.Count - 1; l >= 0; l--)
            {
                string ident = Form1.DataChannels[l];
                Service serv = Form1.GetChannelByIdent(ident, "DATA");

                if (serv == null)
                {
                    Form1.DataChannels.RemoveAt(l);
                }
            }

            for (int l = Form1.SortedTVChannels.Count - 1; l >= 0; l--)
            {
                string ident = Form1.SortedTVChannels[l];
                Service serv = Form1.GetChannelByIdent(ident, "TV");

                if (serv == null)
                {
                    Form1.SortedTVChannels.RemoveAt(l);
                }
            }

            for (int l = Form1.SortedRadioChannels.Count - 1; l >= 0; l--)
            {
                string ident = Form1.SortedRadioChannels[l];
                Service serv = Form1.GetChannelByIdent(ident, "RADIO");

                if (serv == null)
                {
                    Form1.SortedRadioChannels.RemoveAt(l);
                }
            }

            for (int l = Form1.SortedDataChannels.Count - 1; l >= 0; l--)
            {
                string ident = Form1.SortedDataChannels[l];
                Service serv = Form1.GetChannelByIdent(ident, "DATA");

                if (serv == null)
                {
                    Form1.SortedDataChannels.RemoveAt(l);
                }
            }

            Form1.SortTVChannels.ReloadFromList();
            Form1.SortRadioChannels.ReloadFromList();
            Form1.SortDataChannels.ReloadFromList();
        }
    }
}
