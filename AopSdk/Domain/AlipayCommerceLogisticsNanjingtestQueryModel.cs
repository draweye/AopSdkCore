using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsNanjingtestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLogisticsNanjingtestQueryModel : AopObject
    {
        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户信息
        /// </summary>
        [XmlElement("user_info")]
        public UserInfoFromNJ UserInfo { get; set; }
    }
}
