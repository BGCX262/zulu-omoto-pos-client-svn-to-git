using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zulu.BusinessService.Data;

namespace Zulu.BusinessService.Sales
{
	public partial interface ISaleService
	{
		#region Sale

		/// <summary>
		/// Get the new voucher number
		/// </summary>
		/// <returns>The new voucher number.</returns>
		string GetNewVoucherNumber();

		/// <summary>
		/// Get sale by saleID
		/// </summary>
		/// <param name="saleID">The object of Sale Identifier</param>
		/// <returns>Sale object regarding to the sale Identifier</returns>
		Sale GetSalebySaleID(int saleID);

		/// <summary>
		/// Get all sale
		/// </summary>
		/// <returns>All the record from Sale table</returns>
		List<Sale> GetAllSale();

		/// <summary>
		/// Get all sale
		/// </summary>
		/// <param name="startDate">The start of for sale query</</param>
		/// <param name="endDate">The end of for sale query</param>
		/// <returns>All the record from Sale table</returns>
		List<Sale> GetAllSale(DateTime startDate, DateTime endDate);

		/// <summary>
		/// Get the new voucher number
		/// </summary>
		/// <param name="Sale">The object of Sale</param>
		void SaveSaleVoucher(Sale sale);
		
		/// <summary>
		/// Save Sale Voucher
		/// </summary>
		/// <param name="saleID">The Sale Identifier.</param>
		/// <param name="saleProductVariants">The Sale Product Variants.</param>
		void SaveSaleDetails(int saleID, List<SaleProductVariant> saleProductVariants);

		/// <summary>
		/// Save Sale Voucher
		/// </summary>
		/// <param name="saleID">The Sale Identifier.</param>
		/// <returns>The collection of Sale Product Variants</returns>
		List<SaleProductVariant> GetSaleProductVariantBySaleID(int saleID);

		#endregion
	}
}
