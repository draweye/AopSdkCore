using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VerifiedInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VerifiedInfo : AopObject
    {
        /// <summary>
        /// 用户申请订单号回传。  Unique Application No.
        /// </summary>
        [XmlElement("application_no")]
        public string ApplicationNo { get; set; }

        /// <summary>
        /// 审核记录。  Note.
        /// </summary>
        [XmlElement("note")]
        public string Note { get; set; }

        /// <summary>
        /// 审核备注。  Remark.
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 审核状态：通过/拒绝。  Status of application：Verified/Rejected.
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 审核负责单位。  Name of user who do verify.
        /// </summary>
        [XmlElement("verified_by")]
        public string VerifiedBy { get; set; }

        /// <summary>
        /// 审核时间。  DateTime of verified or rejected.
        /// </summary>
        [XmlElement("verify_date_time")]
        public string VerifyDateTime { get; set; }
    }
}
