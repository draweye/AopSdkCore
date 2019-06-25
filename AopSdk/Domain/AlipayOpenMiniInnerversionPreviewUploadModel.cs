using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerversionPreviewUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerversionPreviewUploadModel : AopObject
    {
        /// <summary>
        /// 构建参数- JSAPI 权限文件, JSON 字符串
        /// </summary>
        [XmlElement("build_js_permission")]
        public string BuildJsPermission { get; set; }

        /// <summary>
        /// 构建参数-IDE 构建好的包地址
        /// </summary>
        [XmlElement("build_pkg_url")]
        public string BuildPkgUrl { get; set; }

        /// <summary>
        /// 一个端的标识，用于区分不同的客户端，每接入一个客户端，都需要向小程序应用中心申请bundelId入驻
        /// </summary>
        [XmlElement("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 业务扩展属性
        /// </summary>
        [XmlElement("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 上传调试版的接入租户类型。
        /// </summary>
        [XmlElement("inst_code")]
        public string InstCode { get; set; }

        /// <summary>
        /// 小程序主入口
        /// </summary>
        [XmlElement("main_url")]
        public string MainUrl { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 预览类型，目前分为“DEBUG(调试版)、TRIAL(试用版)”
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }
    }
}
