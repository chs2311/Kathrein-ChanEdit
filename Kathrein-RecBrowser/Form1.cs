using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kathrein_RecBrowser
{
    public partial class Form1 : Form
    {
        List<RecordingInfo> RecIdents = new List<RecordingInfo>();

        public Form1()
        {
            InitializeComponent();
        }

        public static Process CreateRecThumbnail(string trpFile)
        {
            string file = "FFMpeg\\bin\\ffmpeg.exe";
            string args = $"-i \"{trpFile}\" -vf \"thumbnail,scale=100:100\" -frames:v 1 \"{trpFile}_Thumb.png\"";

            ProcessStartInfo ffmpeg = new ProcessStartInfo
            {
                FileName = file,
                Arguments = args,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            return Process.Start(ffmpeg);
        }

        public void LoadFromDisk()
        {
            panel1.Controls.Clear();
            RecIdents.Clear();
            string drive = (string)DiskDriveSelector.SelectedItem;

            string[] dirs = Directory.GetDirectories($"{drive}kathrein\\video");

            List<Process> processes = new List<Process>();
            foreach (string dir in dirs)
            {
                if (!File.Exists(dir + "\\~aufnahme\\aufnahme00.trp_Thumb.png"))
                {
                    DriveValidLabel.Text = $"Loading Thumbnail for \"{dir}\"";

                    Process p = CreateRecThumbnail(dir + "\\~aufnahme\\aufnahme00.trp");
                    processes.Add(p);
                }
            }

            foreach (Process p in processes)
            {
                p.WaitForExit();
            }

            foreach (string dir in dirs)
            {
                RecordingInfo info = RecordingInfo.Load(dir + "\\info.xml");
                RecIdents.Add(info);

                Recording rec = new Recording();
                rec.Dock = DockStyle.Top;
                rec.Directory = dir;
                rec.Title = info.Title;
                rec.DetailedText = info.DetailedText;
                rec.DateTime = info.Start;

                try
                {
                    rec.Thumbnail = Image.FromFile(dir + "\\~aufnahme\\aufnahme00.trp_Thumb.png");
                }
                catch { }

                panel1.Controls.Add(rec);
                DriveValidLabel.Text = $"{RecIdents.Count} Recordings";
            }
        }

        private void DriveChanged(object sender, EventArgs e)
        {
            try
            {
                DriveValidLabel.Text = "Drive valid";
                LoadFromDisk();
            }
            catch
            {
                DriveValidLabel.Text = "Drive invalid";
            }
        }

        private void ConvertAll(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string dir = fbd.SelectedPath;

            foreach (Control c in panel1.Controls)
            {
                Recording rec = c as Recording;
                string filename = Path.GetFileName(rec.Directory) + ".mp4";
                rec.MPEGConvert(Path.Combine(dir, filename));
            }
        }
    }
}
