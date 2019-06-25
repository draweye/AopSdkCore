using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditPeContractInfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditPeContractInfoQueryModel : AopObject
    {
        /// <summary>
        /// 活动名称，由芝麻分配
        /// </summary>
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 场景类目
        /// </summary>
        [XmlElement("category")]
        public string Category { get; set; }

        /// <summary>
        /// 电子合约号
        /// </summary>
        [XmlElement("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 支付宝ID
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }
    }
}
