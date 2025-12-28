using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Kathrein_ChanEdit
{
    [XmlRoot("Servicelist")]
    public class ServiceList
    {
        [XmlElement("Overview")]
        public Overview Overview { get; set; }

        [XmlElement("Satellite")]
        public List<Satellite> Satellites { get; set; }

        [XmlElement("Transponder")]
        public List<Transponder> Transponders { get; set; }

        [XmlElement("Service")]
        public List<Service> Service { get; set; }

        [XmlElement("Favorite")]
        public List<Favorite> Favorites { get; set; }

        public ServiceList()
        {
            Satellites     = new List<Satellite>();
            Transponders   = new List<Transponder>();
            Service        = new List<Service>();
            Favorites      = new List<Favorite>();
        }

        public void Save(string path)
        {
            try
            {
                using(FileStream FS = new FileStream(path, FileMode.Create, FileAccess.Write))
                {
                    XmlSerializer XS = new XmlSerializer(typeof(ServiceList));
                    XS.Serialize(FS, this);
                }
            }
            catch (Exception ex)
            {
                DialogResult dr = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                
                if(dr == DialogResult.Retry)
                {
                    Save(path);
                }
            }
        }

        public static ServiceList Load(string path)
        {
            try
            {
                using (FileStream FS = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    XmlSerializer XS = new XmlSerializer(typeof(ServiceList));
                    object obj = XS.Deserialize(FS);
                    ServiceList sl = (ServiceList)obj;
                    return sl;
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
                    return new ServiceList();
                }
            }
        }
    }

    public class Overview
    {
        [XmlElement("Version")]
        public string Version { get; set; }

        [XmlElement("Date")]
        public string Date { get; set; }

        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlElement("Author")]
        public string Author { get; set; }

        [XmlElement("Typ")]
        public string Typ { get; set; }

        [XmlElement("Country")]
        public string Country { get; set; }

    }

    public class Satellite
    {
        [XmlElement("SatId")]
        public int SatID { get; set; }

        [XmlElement("SatName")]
        public string SatName { get; set; }

        [XmlElement("LO1Frequency")]
        public int LO1Frequency { get; set; }

        [XmlElement("LO2Frequency")]
        public int LO2Frequency { get; set; }

        [XmlElement("BandSwitchFreq")]
        public int BandSwitchFreq { get; set; }

        [XmlElement("Longitude")]
        public int Longitude { get; set; }

        [XmlElement("SkewOffset")]
        public int SkewOffset { get; set; }
    }

    public class Transponder
    {
        [XmlElement("SatId")]
        public int SatID { get; set; }

        [XmlElement("Frequency")]
        public int Frequency { get; set; }

        [XmlElement("SymbolRate")]
        public int SymbolRate { get; set; }

        [XmlElement("Tsid")]
        public int Tsid { get; set; }

        [XmlElement("Oid")]
        public int Oid { get; set; }

        [XmlElement("Polarisation")]
        public string Polarisation { get; set; }

        [XmlElement("DvbType")]
        public string DvbType { get; set; }

        [XmlElement("Modulation")]
        public string Modulation { get; set; }
    }

    public class Service
    {
        [XmlElement("ChannelNo")]
        public int ChannelNo { get; set; }

        [XmlElement("ServiceName")]
        public string ServiceName { get; set; }

        [XmlElement("ServiceType")]
        public string ServiceType { get; set; }

        [XmlElement("Scrambled")]
        public bool Scrambled { get; set; }

        [XmlElement("SatId")]
        public int SatId { get; set; }

        [XmlElement("Frequency")]
        public int Frequency { get; set; }

        [XmlElement("Sid")]
        public int Sid { get; set; }

        [XmlElement("Tsid")]
        public int Tsid { get; set; }

        [XmlElement("Oid")]
        public int Oid { get; set; }

        [XmlElement("AudioPid")]
        public int AudioPid { get; set; }

        [XmlElement("VideoPid")]
        public int VideoPid { get; set; }

        [XmlElement("PcrPid")]
        public int PcrPid { get; set; }

        [XmlElement("ChildrenLock")]
        public bool ChildrenLock { get; set; }

        [XmlElement("Skip")]
        public bool Skip { get; set; }

        [XmlElement("HD")]
        public bool HD { get; set; }

        [XmlElement("FavoriteNo")]
        public int FavoriteNo { get; set; }

        public string GetIdent()
        {
            return $"#{ChannelNo,5} {(HD ? "HD" : "  ")} | {(Scrambled ? "$" : " ")} {ServiceName}";
        }

        public bool IsIdent(string ident)
        {
            return ident == GetIdent();
        }
    }

    public class Favorite
    {
        [XmlElement("FavoriteNo")]
        public int FavoriteNo { get; set; }

        [XmlElement("ServiceType")]
        public string ServiceType { get; set; }

        [XmlElement("FavoriteName")]
        public string FavoriteName { get; set; }
    }
}
