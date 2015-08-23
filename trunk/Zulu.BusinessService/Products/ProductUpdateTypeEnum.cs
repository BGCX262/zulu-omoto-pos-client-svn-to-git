using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zulu.BusinessService.Products
{
	public enum ProductUpdateTypeEnum : int
	{
		/// <summary>
		/// Updated by Shop Owner
		/// </summary>
		UpdatedByShopOwner = 1,

		/// <summary>
		/// Updated by System
		/// </summary>
		UpdatedBySystem = 2,
	}
}
