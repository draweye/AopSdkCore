using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditPeContractUserhistoryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditPeContractUserhistoryQueryModel : AopObject
    {
        /// <summary>
        /// 活动名
        /// </summary>
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 场景类目
        /// </summary>
        [XmlElement("category")]
        public string Category { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }
    }
}
