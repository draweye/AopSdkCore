using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TaxBillContent Data Structure.
    /// </summary>
    [Serializable]
    public class TaxBillContent : AopObject
    {
        /// <summary>
        /// 校验码
        /// </summary>
        [XmlElement("anti_fake_code")]
        public string AntiFakeCode { get; set; }

        /// <summary>
        /// 总金额
        /// </summary>
        [XmlElement("einv_amount")]
        public string EinvAmount { get; set; }

        /// <summary>
        /// 发票代码
        /// </summary>
        [XmlElement("einv_code")]
        public string EinvCode { get; set; }

        /// <summary>
        /// 开票日期
        /// </summary>
        [XmlElement("einv_date")]
        public string EinvDate { get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [XmlElement("einv_no")]
        public string EinvNo { get; set; }

        /// <summary>
        /// 卖方名称
        /// </summary>
        [XmlElement("payee_name")]
        public string PayeeName { get; set; }

        /// <summary>
        /// 卖方纳税人识别号
        /// </summary>
        [XmlElement("payee_register_no")]
        public string PayeeRegisterNo { get; set; }

        /// <summary>
        /// 买方名称
        /// </summary>
        [XmlElement("payer_name")]
        public string PayerName { get; set; }

        /// <summary>
        /// 买方纳税人识别号
        /// </summary>
        [XmlElement("payer_register_no")]
        public string PayerRegisterNo { get; set; }

        /// <summary>
        /// 税额
        /// </summary>
        [XmlElement("tax_amount")]
        public string TaxAmount { get; set; }

        /// <summary>
        /// 不含税金额
        /// </summary>
        [XmlElement("without_tax_amount")]
        public string WithoutTaxAmount { get; set; }
    }
}
