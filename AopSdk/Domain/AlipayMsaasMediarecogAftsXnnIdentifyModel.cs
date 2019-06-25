using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMsaasMediarecogAftsXnnIdentifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMsaasMediarecogAftsXnnIdentifyModel : AopObject
    {
        /// <summary>
        /// 算法业务标识id，调用对应算法前请联系接口负责人获取
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 入参图片信息，
        /// </summary>
        [XmlArray("image_info_list")]
        [XmlArrayItem("image_info")]
        public List<ImageInfo> ImageInfoList { get; set; }

        /// <summary>
        /// 算法入参，json字符串
        /// </summary>
        [XmlElement("params")]
        public string Params { get; set; }

        /// <summary>
        /// 分类算法传入Common_Classify  检测算法传入Common_Detect
        /// </summary>
        [XmlElement("request_type")]
        public string RequestType { get; set; }
    }
}
