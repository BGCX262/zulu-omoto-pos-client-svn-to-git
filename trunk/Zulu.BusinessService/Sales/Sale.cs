using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zulu.BusinessService.Infrastructure;
using Zulu.BusinessService.Sales;

namespace Zulu.BusinessService.Data
{
	public partial class Sale
	{
		#region CustomProperties

		/// <summary>
		/// Gets the Member Object by Using Member Identifier 
		/// </summary>
		public User Member
		{
			get
			{
				return IoC.Resolve<IUserService>().GetUserByID((int)this.MemberID);
			}
		}

		/// <summary>
		/// Gets the Member Object by Using Seller Identifier 
		/// </summary>
		public User Seller
		{
			get
			{
				return IoC.Resolve<IUserService>().GetUserByID((int)this.SellerID);
			}
		}

		/// <summary>
		/// Gets the collection of Product Variants Using Sale Identifier
		/// </summary>
		public List<SaleProductVariant> SaleProductVariants
		{
			get 
			{
				return IoC.Resolve<ISaleService>().GetSaleProductVariantBySaleID(this.SaleID);
			}
		}

		#endregion
	}
}
