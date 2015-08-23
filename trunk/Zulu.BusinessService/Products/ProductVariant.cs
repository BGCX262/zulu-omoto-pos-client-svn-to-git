using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zulu.BusinessService.Infrastructure;
using Zulu.BusinessService.Products;

namespace Zulu.BusinessService.Data
{
	public partial class ProductVariant
	{
		#region Custom Properties

		public Product product
		{
			get
			{
				int productID = 0;
				int.TryParse(this.ProductID.ToString(), out productID);
				
				if (productID == 0)
					return null;

				return IoC.Resolve<IProductService>().GetProductByID(productID);
			}
		}

		public string ProductName
		{
			get 
			{
				if (product != null)
					return product.Name;
				return string.Empty;
			}
		}

		#endregion
	}
}
