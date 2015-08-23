using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zulu.BusinessService.Data;
using Zulu.BusinessService.Util;
using Zulu.BusinessService.Infrastructure;
using Zulu.BusinessService.Products;
using Zulu.BusinessService.Settings;

namespace Zulu.BusinessService.Sales
{
	public partial class SaleService : ISaleService
	{
		#region Fields

        /// <summary>
        /// Object context
        /// </summary>
        private readonly ZuluDataContext _context;


        #endregion

        #region Ctor

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="context">Object context</param>
		public SaleService(ZuluDataContext context)
        {
            this._context = context;
        }

        #endregion

		#region Sale

		/// <summary>
		/// Get the new voucher number
		/// </summary>
		/// <returns>The new voucher number.</returns>
		public string GetNewVoucherNumber()
		{
			string BaseVoucherNumber = ApplicationSetting.BaseVoucherNumber;
			var sale = _context.Sales.LastOrDefault(c => c.VoucherNumber.Contains(BaseVoucherNumber));
			int intReceiptNumber = 0;
			

			if (sale == null)
				return BaseVoucherNumber + "0001";

			string receiptNumber = sale.VoucherNumber.Substring(sale.VoucherNumber.Count() + 1);
			int.TryParse(receiptNumber, out intReceiptNumber);

			intReceiptNumber += intReceiptNumber;

			return BaseVoucherNumber + intReceiptNumber.ToString("0000");
		}

		/// <summary>
		/// Get sale by saleID
		/// </summary>
		/// <param name="saleID">The object of Sale Identifier</param>
		/// <returns>Sale object regarding to the sale Identifier</returns>
		public Sale GetSalebySaleID(int saleID)
		{
			return _context.Sales.FirstOrDefault(c => c.SaleID == saleID);
		}

		/// <summary>
		/// Get all sale
		/// </summary>
		/// <returns>All the record from Sale table</returns>
		public List<Sale> GetAllSale()
		{
			return _context.Sales.ToList();
		}

		/// <summary>
		/// Get all sale
		/// </summary>
		/// <param name="startDate">The start of for sale query</</param>
		/// <param name="endDate">The end of for sale query</param>
		/// <returns>All the record from Sale table</returns>
		public List<Sale> GetAllSale(DateTime startDate, DateTime endDate)
		{
			return _context.Sales.Where(c => c.CreatedOn >= startDate && c.CreatedOn <= endDate).ToList();
		}

		/// <summary>
		/// Save Sale Voucher
		/// </summary>
		/// <param name="sale">The object of Sale</param>
		public void SaveSaleVoucher(Sale sale)
		{
			Sale existingData = GetSalebySaleID(sale.SaleID);

			if (existingData == null)
			{
				sale.CreatedOn = DateTime.Now;
				sale.UpdatedOn = DateTime.Now;
				_context.Sales.AddObject(sale);
			}
			else
			{
				existingData.SaleID = sale.SaleID;
				existingData.VoucherNumber = sale.VoucherNumber;
				existingData.MemberID = sale.MemberID;
				existingData.SellerID = sale.SellerID;
				existingData.SaleSubTotalExcTax = sale.SaleSubTotalExcTax;
				existingData.SaleSubTotalIncTax = sale.SaleSubTotalIncTax;
				existingData.SaleTotalDiscount = sale.SaleTotalDiscount;
				existingData.TaxRate = sale.TaxRate;
				existingData.SaleTax = sale.SaleTax;
				existingData.SaleTotal = sale.SaleTotal;
				existingData.RefundedAmount = sale.RefundedAmount;
				existingData.CreatedOn = existingData.CreatedOn;
				existingData.SaleTotalQuantity = sale.SaleTotalQuantity;
				existingData.SaleStatus = sale.SaleStatus;
				existingData.UpdatedOn = DateTime.Now;

				if (!_context.IsAttached(existingData))
					_context.Sales.Attach(existingData);
			}
			_context.SaveChanges();
		}

		/// <summary>
		/// Save Sale Voucher
		/// </summary>
		/// <param name="saleID">The Sale Identifier.</param>
		/// <param name="saleProductVariants">The Sale Product Variants.</param>
		public void SaveSaleDetails(int saleID, List<SaleProductVariant> saleProductVariants)
		{
			var existingSaleProductVariants = GetSaleProductVariantBySaleID(saleID);

			if (existingSaleProductVariants != null || existingSaleProductVariants.Count > 0)
			{
				foreach (var existingProductVariant in existingSaleProductVariants)
				{
					var saleProductVariant = saleProductVariants.FirstOrDefault(c => c.SaleProductVariantID == existingProductVariant.SaleProductVariantID);

					if (saleProductVariant.Quantity != existingProductVariant.Quantity)
						UpdateSaleProductVariantQuantity(saleProductVariant.SaleProductVariantID, (int)saleProductVariant.Quantity);
					
					saleProductVariants.Remove(saleProductVariant);
				}
			}

			foreach (var saleProductVariant in saleProductVariants)
			{
				_context.SaleProductVariants.AddObject(saleProductVariant);
			}
			_context.SaveChanges();
		}

		/// <summary>
		/// Get Sale Product Variant By sale product variant identifier
		/// </summary>
		/// <param name="saleProductVariantID">The Sale Product Variant Identifier.</param>
		/// <returns>The object of Sale Product Variant</returns>
		public SaleProductVariant GetSaleProductVariantByID(int saleProductVariantID)
		{
			return _context.SaleProductVariants.FirstOrDefault(c => c.SaleProductVariantID == saleProductVariantID);
		}

		/// <summary>
		/// Save Sale Voucher
		/// </summary>
		/// <param name="saleID">The Sale Identifier.</param>
		/// <returns>The collection of Sale Product Variants</returns>
		public List<SaleProductVariant> GetSaleProductVariantBySaleID(int saleID)
		{
			return _context.SaleProductVariants.Where(c => c.SaleID == saleID).ToList();
		}


		/// <summary>
		/// Save Sale Voucher
		/// </summary>
		/// <param name="saleID">The Sale Identifier.</param>
		/// <returns>The collection of Sale Product Variants</returns>
		private void UpdateSaleProductVariantQuantity(int saleProductVariantID, int quantity)
		{
			var SaleProductVariant = GetSaleProductVariantByID(saleProductVariantID);

			if(SaleProductVariant != null)
				throw new ArgumentNullException("Sale");

			SaleProductVariant.Quantity = quantity;

			if (!_context.IsAttached(SaleProductVariant))
				_context.SaleProductVariants.Attach(SaleProductVariant);

			_context.SaveChanges();
		}



		public Sale CreateSale(string VoucherNumber, string barcode)
		{
			Sale sale = new Sale();
			if (ZuluHelper.CheckStringIsEmptyOrNull(VoucherNumber))
			{
				ProductVariant productVariant = GetSaleProductVariant(barcode);
				
				if (productVariant == null)
					return null;


				
			}
			else 
			{
				//TODO Retrieve order and Add ProductVariant in that order
			}

			return null;
		}

		private Sale CreateSale(ProductVariant productVariant)
		{



			return null;
		}

		private Sale Save(Sale sale, List<SaleProductVariant> saleProductVariants)
		{
			int saleID = 0;

			foreach (var saleProductVariant in saleProductVariants)
			{
				SaleProductVariant spVariant = new SaleProductVariant();
				//productunitid.CreatedOn = DateTime.Now;

				//TODO Reduce the stock from product variant

				//TODO Save product Variants


				_context.SaleProductVariants.AddObject(spVariant);
			}

			_context.SaveChanges();




			return null;
		}


		public Sale AddQuantity(string barcode, int quantity)
		{
			throw new NotImplementedException();
		}

		public Sale AddMember(string memberID)
		{
			throw new NotImplementedException();
		}

		public void SalePending(string voucherNumber)
		{
			throw new NotImplementedException();
		}

		public Sale ReActivatePending(string voucherNumber)
		{
			throw new NotImplementedException();
		}

		public void Purchase(string voucherNumber)
		{
			throw new NotImplementedException();
		}

		public void Refund(string voucherNumber, int productVariantID)
		{
			throw new NotImplementedException();
		}

		private ProductVariant GetSaleProductVariant(string barCode)
		{
			if (string.IsNullOrEmpty(barCode))
				return null;

			ProductVariant ProductVariant = new ProductVariant();

			if (ZuluContext.Current.ProductVariants == null)
				ZuluContext.Current.ProductVariants = new List<ProductVariant>();
			else
				ProductVariant = ZuluContext.Current.ProductVariants.FirstOrDefault(c => c.BarCode == barCode);

			if (ProductVariant == null)
			{
				ProductVariant = IoC.Resolve<IProductService>().GetProductVariantByBarCode(barCode);
				ZuluContext.Current.ProductVariants.Add(ProductVariant);
			}
			return ProductVariant;
		}

		#endregion


	
	}
}
