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
    public partial class Recording : UserControl
    {
        public string Directory { get; set; }

        public Image Thumbnail
        {
            get
            {
                return ThumbnailBox.Image;
            }
            set
            {
                ThumbnailBox.Image = value;
            }
        }

        public string Title
        {
            get
            {
                return TitleLabel.Text;
            }
            set
            {
                TitleLabel.Text = value;
            }
        }

        public string DetailedText
        {
            get
            {
                return DetailedTextLabel.Text;
            }
            set
            {
                DetailedTextLabel.Text = value;
            }
        }

        public DateTime DateTime
        {
            get
            {
                return Convert.ToDateTime(DateLabel.Text);
            }
            set
            {
                DateLabel.Text = value.ToString("dd-MM-yyyy HH:mm:ss");
            }
        }

        public Recording()
        {
            InitializeComponent();
        }

        private void LoadAssets(object sender, EventArgs e)
        {
            PlayWithVLCButton.Image = new Bitmap(Image.FromFile("Assets\\VLCIcon.png"), new Size(40, 40));
            ConvertToMPEGButton.Image = new Bitmap(Image.FromFile("Assets\\ConvertFile.png"), new Size(40, 40));
        }

        private void PlayWithVLC(object sender, EventArgs e)
        {
            ProcessStartInfo vlc = new ProcessStartInfo
            {
                FileName = "VideoLAN\\vlc.exe",
                Arguments = $"\"{Directory}\\~aufnahme\\aufnahme00.trp\""
            };

            _ = Process.Start(vlc);
        }

        private void ConvertToMPEG(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "MPEG|*.mp4;*.mpeg";
            if(sfd.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            MPEGConvert(sfd.FileName);

            _ = MessageBox.Show("Your Recording has been converted!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void MPEGConvert(string output)
        {
            string dir = Directory + "\\~aufnahme";
            string ffmpeg = "FFMpeg\\bin\\ffmpeg.exe";

            List<string> TRPFiles = System.IO.Directory.GetFiles(dir, "*.trp").OrderBy(f =>
            {
                return f;
            }).ToList();

            string listFile = dir + "\\tmp_files.txt";

            StringBuilder sb = new StringBuilder();
            foreach (string file in TRPFiles)
            {
                _ = sb.AppendLine($"file '{file.Replace("'", "'\\''")}'");
            }

            File.WriteAllText(listFile, sb.ToString());

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = ffmpeg,
                Arguments = $"-f concat -safe 0 -i \"{listFile}\" -c copy \"{output}\""
            };

            using (Process process = Process.Start(psi))
            {
                process.WaitForExit();
            }

            File.Delete(listFile);
        }
    }
}
