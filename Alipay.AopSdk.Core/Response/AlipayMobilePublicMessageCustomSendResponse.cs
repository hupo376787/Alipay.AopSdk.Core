using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMobilePublicMessageCustomSendResponse.
	/// </summary>
	public class AlipayMobilePublicMessageCustomSendResponse : AopResponse
	{
		/// <summary>
		///     结果码
		/// </summary>
		[XmlElement("code")]
		public string Code { get; set; }

		/// <summary>
		///     结果描述
		/// </summary>
		[XmlElement("msg")]
		public string Msg { get; set; }
	}
}