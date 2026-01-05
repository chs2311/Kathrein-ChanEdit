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
    public partial class EditSatellites : Form
    {
        public EditSatellites()
        {
            InitializeComponent();
        }

        public void LoadSatellites(object sender, EventArgs e)
        {
            SatGrid.Rows.Clear();

            foreach(Satellite sat in Form1.CurrentConfig.Satellites)
            {
                _ = SatGrid.Rows.Add(sat.SatID, sat.SatName, sat.LO1Frequency, sat.LO2Frequency, sat.BandSwitchFreq, sat.Longitude, sat.SkewOffset);
            }
        }

        private void SaveSatellites(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("If you deleted any sattelite, \r\n" +
                "all channels and transponders that depend on that one will also be deleted!\r\n" +
                "This action cannot be reversed! and could make your entire Channel Config unusable!\r\n" +
                "\r\n" +
                "Do you still want to continue to save?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(dr == DialogResult.No)
            {
                return;
            }

            List<Satellite> NSat = new List<Satellite>();
            List<int> RemovedSatIds = new List<int>();

            for (int i = 0; i < SatGrid.Rows.Count - 1; i++)
            {
                Satellite sat = new Satellite();
                sat.SatID           = (int)SatGrid.Rows[i].Cells[0].Value;
                sat.SatName         = (string)SatGrid.Rows[i].Cells[1].Value;
                sat.LO1Frequency    = (int)SatGrid.Rows[i].Cells[2].Value;
                sat.LO2Frequency    = (int)SatGrid.Rows[i].Cells[3].Value;
                sat.BandSwitchFreq  = (int)SatGrid.Rows[i].Cells[4].Value;
                sat.Longitude       = (int)SatGrid.Rows[i].Cells[5].Value;
                sat.SkewOffset      = (int)SatGrid.Rows[i].Cells[6].Value;
                NSat.Add(sat);
            }

            for (int i = Form1.CurrentConfig.Satellites.Count - 1; i >= 0; i--)
            {
                Satellite oldSat = Form1.CurrentConfig.Satellites[i];

                bool stillExists = NSat.Any(s =>
                {
                    return s.SatID == oldSat.SatID;
                });
                if (!stillExists)
                {
                    RemovedSatIds.Add(oldSat.SatID);
                    Form1.CurrentConfig.Satellites.RemoveAt(i);
                }
            }

            foreach (Satellite nsat in NSat)
            {
                Satellite osat = Form1.CurrentConfig.Satellites
                    .FirstOrDefault(s =>
                    {
                        return s.SatID == nsat.SatID;
                    });

                if (Form1.CurrentConfig.Satellites != null)
                {
                    osat.SatName = nsat.SatName;
                    osat.LO1Frequency = nsat.LO1Frequency;
                    osat.LO2Frequency = nsat.LO2Frequency;
                    osat.BandSwitchFreq = nsat.BandSwitchFreq;
                    osat.Longitude = nsat.Longitude;
                    osat.SkewOffset = nsat.SkewOffset;
                }
                else
                {
                    Form1.CurrentConfig.Satellites.Add(nsat);
                }
            }

            for (int j = Form1.CurrentConfig.Transponders.Count - 1; j >= 0; j--)
            {
                Transponder tp = Form1.CurrentConfig.Transponders[j];

                if(RemovedSatIds.Contains(tp.SatID))
                {
                    Form1.CurrentConfig.Transponders.RemoveAt(j);
                }
            }

            //Toggle Reload for Transponders

            for(int k = Form1.CurrentConfig.Service.Count - 1; k >= 0; k--)
            {
                Service serv = Form1.CurrentConfig.Service[k];

                if(RemovedSatIds.Contains(serv.SatId))
                {
                    Form1.CurrentConfig.Service.RemoveAt(k);
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
