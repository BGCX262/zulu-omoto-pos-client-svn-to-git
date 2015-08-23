using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zulu.BusinessService.Data;

namespace Zulu.BusinessService.Products
{
	public partial interface IProductService
	{
		#region ProductVariant

		ProductVariant GetProductVariantByID(int productVariantID);

		List<ProductVariant> GetProductVariantsByProductID(int productID);

		List<ProductVariant> GetAllProductVariants();

		void SaveProductVariant(ProductVariant productVariant);

		void DeleteProductVariant(int productVariantID);

		void DeactivateProductVariant(int productVariantID);

		ProductVariant GetProductVariantByBarCode(string barCode);

		#endregion

		#region Product

		Product GetProductByID(int productID);

		List<Product> GetAllProduct();

		void SaveProduct(Product product);

		void DeleteProduct(int productID);

		void MarkProductDeleted(int productID);

		#endregion

		#region ProductUnit

		List<ProductUnit> GetAllProductUnit();

		void SaveProductUnit(ProductUnit productunit);

		#endregion

		#region Category

		Category GetCategoryByID(int categoryID);

		List<Category> GetAllCategories();

		List<Category> GetAllCategories(bool isActive);

		void SaveCategory(Category category);

		void DeleteCategory(int categoryID);

		void DeactiveCategory(int categoryID);

		#endregion

		#region Manufacturer

		Manufacturer GetManufacturerByID(int manufacturerID);

		List<Manufacturer> GetAllManufacturer();

		void SaveManufacturer(Manufacturer manufacturer);

		void DeleteManufacturer(int manufacturerID);

		void DeactivateManufacturer(int manufacturerID);

		List<Manufacturer> GetAllManufacturer(bool isActive);

		#endregion

		//#region ProductCategoryMapping

		//void SaveProductCategoryMapping(ProductCategoryMapping productCategoryMapping);

		//void DeleteProductCategoryMapping(int productCategoryID);

		//#endregion

		//#region ProductManufacturerMapping

		//void SaveProductManufacturerMapping(ProductManufacturerMapping productManufacturerMapping);

		//void DeleteProductManufacturerMapping(int productManufacturerID);

		//#endregion
	}
}
