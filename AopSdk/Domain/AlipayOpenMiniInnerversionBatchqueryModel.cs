using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerversionBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerversionBatchqueryModel : AopObject
    {
        /// <summary>
        /// 小程序ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 小程序版本号
        /// </summary>
        [XmlArray("version_list")]
        [XmlArrayItem("mini_app_version_query_info")]
        public List<MiniAppVersionQueryInfo> VersionList { get; set; }
    }
}
