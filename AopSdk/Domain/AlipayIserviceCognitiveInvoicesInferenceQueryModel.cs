using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCognitiveInvoicesInferenceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCognitiveInvoicesInferenceQueryModel : AopObject
    {
        /// <summary>
        /// 图片base64加密后的内容
        /// </summary>
        [XmlElement("img_content")]
        public string ImgContent { get; set; }
    }
}
