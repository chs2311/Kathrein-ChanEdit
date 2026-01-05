using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Kathrein_RecBrowser
{
    [XmlRoot("recording")]
    public class RecordingInfo
    {
        [XmlElement("Audio")]
        public int Audio { get; set; }
        [XmlElement("BlackWhite")]
        public bool BlackWhite { get; set; }
        [XmlElement("ChildrenLock")]
        public bool ChildrenLock { get; set; }
        [XmlElement("DetailedText")]
        public string DetailedText { get; set; }
        [XmlElement("End")]
        public DateTime End { get; set; }
        [XmlElement("F16to9")]
        public bool F16to9 { get; set; }
        [XmlElement("FSK")]
        public int FSK { get; set; }
        [XmlElement("Format")]
        public int Format { get; set; }
        [XmlElement("HD")]
        public bool HD { get; set; }
        [XmlElement("HDPlus")]
        public bool HDplus { get; set; }
        [XmlElement("KathreinTopic")]
        public int KathreinTopic { get; set; }
        [XmlElement("ListText")]
        public string ListText { get; set; }
        [XmlElement("PlayPosition")]
        public DateTime PlayPosition { get; set; }
        [XmlElement("ServiceName")]
        public string ServiceName { get; set; }
        [XmlElement("ServiceType")]
        public int ServiceType { get; set; }
        [XmlElement("Start")]
        public DateTime Start { get; set; }
        [XmlElement("Subtitle")]
        public int Subtitle { get; set; }
        [XmlElement("Tip")]
        public bool Tip { get; set; }
        [XmlElement("Title")]
        public string Title { get; set; }
        [XmlElement("Year")]
        public string Year { get; set; }

        public static RecordingInfo Load(string path)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(RecordingInfo));

                using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    XmlTextReader reader = new XmlTextReader(fs);
                    reader.Namespaces = false;

                    return (RecordingInfo)serializer.Deserialize(reader);
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
                    return new RecordingInfo();
                }
            }
        }
    }
}
