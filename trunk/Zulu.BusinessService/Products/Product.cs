using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zulu.BusinessService.Infrastructure;
using Zulu.BusinessService.Products;

namespace Zulu.BusinessService.Data
{
	public partial class Product
	{
		#region CustomProperties

		public List<ProductVariant> productVariants
		{
			get
			{
				return IoC.Resolve<IProductService>().GetProductVariantsByProductID(this.ProductID);
			}
		}

		#endregion
	}
}
