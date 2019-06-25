using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityTestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityTestQueryModel : AopObject
    {
        /// <summary>
        /// 纬度1231
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }
    }
}
