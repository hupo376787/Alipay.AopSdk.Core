using System.Collections.Generic;
using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayOpenPublicMenuBatchqueryResponse.
	/// </summary>
	public class AlipayOpenPublicMenuBatchqueryResponse : AopResponse
	{
		/// <summary>
		///     菜单数量，包括默认菜单和个性化菜单
		/// </summary>
		[XmlElement("count")]
		public string Count { get; set; }

		/// <summary>
		///     菜单列表
		/// </summary>
		[XmlArray("menus")]
		[XmlArrayItem("query_menu")]
		public List<QueryMenu> Menus { get; set; }
	}
}