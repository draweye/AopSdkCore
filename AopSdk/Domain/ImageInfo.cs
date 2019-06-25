using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ImageInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ImageInfo : AopObject
    {
        /// <summary>
        /// 图片aftsId或者url
        /// </summary>
        [XmlElement("image")]
        public string Image { get; set; }

        /// <summary>
        /// 传入图片类型，ID表示aftsId，URL表示图片url地址
        /// </summary>
        [XmlElement("image_type")]
        public string ImageType { get; set; }
    }
}
