using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityTestQueryResponse.
    /// </summary>
    public class AlipaySecurityTestQueryResponse : AopResponse
    {
        /// <summary>
        /// 23
        /// </summary>
        [XmlElement("eeea")]
        public string Eeea { get; set; }
    }
}
