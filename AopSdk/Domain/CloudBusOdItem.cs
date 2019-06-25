using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CloudBusOdItem Data Structure.
    /// </summary>
    [Serializable]
    public class CloudBusOdItem : AopObject
    {
        /// <summary>
        /// 实际公交od值
        /// </summary>
        [XmlElement("bus_od")]
        public long BusOd { get; set; }

        /// <summary>
        /// geo hash
        /// </summary>
        [XmlElement("dest_geohash")]
        public string DestGeohash { get; set; }

        /// <summary>
        /// 潜在od值
        /// </summary>
        [XmlElement("od")]
        public long Od { get; set; }
    }
}
