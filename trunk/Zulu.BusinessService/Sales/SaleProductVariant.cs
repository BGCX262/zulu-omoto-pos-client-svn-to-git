using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zulu.BusinessService.Infrastructure;
using Zulu.BusinessService.Sales;
using Zulu.BusinessService.Products;

namespace Zulu.BusinessService.Data
{
	public partial class SaleProductVariant
	{
		#region CustomProperties

		/// <summary>
		/// Gets the Sale voucher 
		/// </summary>
		public Sale Sale
		{
			get
			{
				return IoC.Resolve<ISaleService>().GetSalebySaleID((int)this.SaleID);
			}
		}

		/// <summary>
		/// Gets the Product variant by barcode
		/// </summary>
		public ProductVariant ProductVariant
		{
			get
			{
				return IoC.Resolve<IProductService>().GetProductVariantByBarCode(this.ProductVariantBarCode);
			}
		}


		#endregion
	}
}
