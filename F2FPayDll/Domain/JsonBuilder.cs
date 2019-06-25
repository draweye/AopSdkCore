using System;


namespace Com.Alipay.Domain
{

    /// <summary>
    /// Class1 的摘要说明
    /// </summary>
    public abstract class JsonBuilder
    {

        // 验证bizContent对象
        public abstract bool Validate();

        // 将bizContent对象转换为json字符串
        public string BuildJson()
        {
            try
            {
                return Newtonsoft.Json.JsonConvert.SerializeObject(this);
            }
            catch (Exception ex)
            {

                throw new Exception("JSONHelper.ObjectToJSON(): " + ex.Message);
            }
        }
    }
}