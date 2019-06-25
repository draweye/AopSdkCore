using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MachineType Data Structure.
    /// </summary>
    [Serializable]
    public class MachineType : AopObject
    {
        /// <summary>
        /// 视觉货柜机型ID
        /// </summary>
        [XmlElement("machine_type_id")]
        public string MachineTypeId { get; set; }

        /// <summary>
        /// 机型信息备注说明
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 机型状态 (1:生效，0:下线)
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }
    }
}
