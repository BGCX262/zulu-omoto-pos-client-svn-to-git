using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zulu.BusinessService.Data;
using Zulu.BusinessService.Logs;
using Zulu.BusinessService.Infrastructure;

namespace Zulu.BusinessService.Products
{
	public partial class ProductService	: IProductService
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
		public ProductService(ZuluDataContext context)
        {
            this._context = context;
        }

		public ProductService()
		{
			
		}

        #endregion

		#region ProductVariant

		public ProductVariant GetProductVariantByID(int productVariantID)
		{
			return _context.ProductVariants.FirstOrDefault(c => c.ProductVariantID == productVariantID);
		}

		public ProductVariant GetProductVariantByBarCode(string barCode)
		{
			if (string.IsNullOrEmpty(barCode))
				return null;

			return _context.ProductVariants.FirstOrDefault(c => c.BarCode == barCode);
		}

		public List<ProductVariant> GetProductVariantsByProductID(int productID)
		{
			return _context.ProductVariants.Where(c => c.ProductID == productID).ToList();
		}

		public List<ProductVariant> GetAllProductVariants()
		{
			return _context.ProductVariants.ToList();
		}

		public void SaveProductVariant(ProductVariant productVariant)
		{
			ProductVariant existingData = GetProductVariantByID(productVariant.ProductVariantID);
			

			if (existingData == null)
			{
				productVariant.CreatedOn = DateTime.Now;
				productVariant.UpdatedOn = DateTime.Now;
				_context.ProductVariants.AddObject(productVariant);
			}
			else
			{
				existingData.ProductID = productVariant.ProductID;
				existingData.Name = productVariant.Name;
				existingData.BarCode = productVariant.BarCode;
				existingData.RestrictedUnder18 = productVariant.RestrictedUnder18;
				existingData.StockQuantity = productVariant.StockQuantity;
				existingData.DisplayStockQuantity = productVariant.DisplayStockQuantity;
				existingData.MinimumStockQuantity = productVariant.MinimumStockQuantity;
				existingData.NotifyForQuantityBelow = productVariant.NotifyForQuantityBelow;
				existingData.BuyingPrice = productVariant.BuyingPrice;
				existingData.PictureID = productVariant.PictureID;
				existingData.CreatedOn = existingData.CreatedOn;
				existingData.UpdatedOn = DateTime.Now;
				existingData.SellingPrice = productVariant.SellingPrice;

				if (!_context.IsAttached(existingData))
					_context.ProductVariants.Attach(existingData);
			}
			_context.SaveChanges();
		}

		public void DeleteProductVariant(int productVariantID)
		{
			if (productVariantID == 0)
				return;

			ProductVariant productVariant = GetProductVariantByID(productVariantID);
			if (productVariant == null)
				return;

			if (!_context.IsAttached(productVariant))
				_context.ProductVariants.Attach(productVariant);

			_context.DeleteObject(productVariant);
			_context.SaveChanges();
		}

		public void DeactivateProductVariant(int productVariantID)
		{
			if (productVariantID == 0)
				return;

			ProductVariant productVariant = GetProductVariantByID(productVariantID);
			if (productVariant == null)
				return;

			productVariant.IsActive = false;
			productVariant.UpdatedOn = DateTime.Now;

			if (!_context.IsAttached(productVariant))
				_context.ProductVariants.Attach(productVariant);

			_context.SaveChanges();
		}

		private void DeleteProductVariantsByProductID(int productID)
		{
			List<ProductVariant> productVariants = GetProductVariantsByProductID(productID);

			foreach (ProductVariant productVariant in productVariants)
			{
				if (!_context.IsAttached(productVariant))
					_context.ProductVariants.Attach(productVariant);

				_context.DeleteObject(productVariant);
			}
			_context.SaveChanges();
		}

		#endregion

		#region Product

		public Product GetProductByID(int productID)
		{
			return _context.Products.FirstOrDefault(c => c.ProductID == productID);
		}

		public List<Product> GetAllProduct()
		{
			return _context.Products.ToList();
		}

        public List<Product> GetAllUnDeletedProduct(bool isDeleted)
        {
            return _context.Products.Where(c => c.Deleted == isDeleted).ToList();
        }

		public void SaveProduct(Product product)
		{
			Product existingData = GetProductByID(product.ProductID);

			if (existingData == null)
			{
				product.CreatedOn = DateTime.Now;
				product.UpdatedOn = DateTime.Now;
				_context.Products.AddObject(product);
			}
			else
			{
				existingData.Name = product.Name;
				existingData.Description = product.Description;
				existingData.IsActive = product.IsActive;
				existingData.Deleted = product.Deleted;
				existingData.CreatedOn = existingData.CreatedOn;
				existingData.UpdatedOn = DateTime.Now;
				existingData.UpdatedMethod = product.UpdatedMethod;
				existingData.ProductUnitID = product.ProductUnitID;

				if (!_context.IsAttached(existingData))
					_context.Products.Attach(existingData);
			}
			_context.SaveChanges();
		}

		public void DeleteProduct(int productID)
		{
			if (productID == 0)
				return;

			Product product = GetProductByID(productID);
			if (product == null)
				return;

			if (!_context.IsAttached(product))
				_context.Products.Attach(product);

			DeleteProductVariantsByProductID(productID);

			_context.DeleteObject(product);
			_context.SaveChanges();
		}

		public void MarkProductDeleted(int productID)
		{
			if (productID == 0)
				return;

			Product product = GetProductByID(productID);
			if (product == null)
				return;

			product.Deleted = true;
			product.UpdatedOn = DateTime.Now;

			if (!_context.IsAttached(product))
				_context.Products.Attach(product);

			_context.SaveChanges();
		}

		#endregion

        #region ProductUnit

        public ProductUnit GetProductUnitByID(int productunitID)
        {
            return _context.ProductUnits.FirstOrDefault(c => c.ProductUnitID == productunitID);
        }

        public List<ProductUnit> GetAllProductUnit()
        {
            return _context.ProductUnits.ToList();
        }

        public void SaveProductUnit(ProductUnit productunit)
        {
            ProductUnit existingData = GetProductUnitByID(productunit.ProductUnitID);

            if (existingData == null)
                _context.ProductUnits.AddObject(productunit);
            else
            {
                existingData.Name = productunit.Name;
                existingData.Description = productunit.Description;
				existingData.IsActive = productunit.IsActive;
                existingData.ProductUnitID = productunit.ProductUnitID;

                if (!_context.IsAttached(existingData))
                    _context.ProductUnits.Attach(existingData);
            }
            _context.SaveChanges();
        }
        #endregion

		#region Category

		public Category GetCategoryByID(int categoryID)
		{
			return _context.Categories.FirstOrDefault(c => c.CategoryID == categoryID);
		}

		public List<Category> GetAllCategories()
		{
			return _context.Categories.ToList();
		}

		public List<Category> GetAllCategories(bool isActive)
		{
			return _context.Categories.Where(c => c.IsActive == isActive).ToList();
		}

		public void SaveCategory(Category category)
		{
			Category existingData = GetCategoryByID(category.CategoryID);
			

			if (existingData == null)
			{
				category.CreatedOn = DateTime.Now;
				category.UpdatedOn = DateTime.Now;
				_context.Categories.AddObject(category);
			}
			else
			{
				existingData.Name = category.Name;
				existingData.Description = category.Description;
				existingData.PictureID = category.PictureID;
				existingData.IsActive = category.IsActive;
				existingData.CreatedOn = existingData.CreatedOn;
				existingData.UpdatedOn = DateTime.Now;

				if (!_context.IsAttached(existingData))
					_context.Categories.Attach(existingData);
			}
			_context.SaveChanges();
		}

		public void DeleteCategory(int categoryID)
		{
			if (categoryID == 0)
				return;

			Category category = GetCategoryByID(categoryID);
			if (category == null)
				return;

			if (!_context.IsAttached(category))
				_context.Categories.Attach(category);
			_context.DeleteObject(category);
			_context.SaveChanges();
		}

		public void DeactiveCategory(int categoryID)
		{
			if (categoryID == 0)
				return;

			Category category = GetCategoryByID(categoryID);
			if (category == null)
				return;

			category.IsActive = false;
			category.UpdatedOn = DateTime.Now;

			if (!_context.IsAttached(category))
				_context.Categories.Attach(category);

			_context.SaveChanges();
		}

		#endregion

		#region Manufacturer

		public Manufacturer GetManufacturerByID(int manufacturerID)
		{
			return _context.Manufacturers.FirstOrDefault(c => c.ManufacturerID == manufacturerID);
		}

		public List<Manufacturer> GetAllManufacturer()
		{
			return _context.Manufacturers.ToList();
		}

		public List<Manufacturer> GetAllManufacturer(bool isActive)
		{
			return _context.Manufacturers.Where(c => c.IsActive == isActive).ToList();
		}

		public void SaveManufacturer(Manufacturer manufacturer)
		{
			Manufacturer existingData = GetManufacturerByID(manufacturer.ManufacturerID);


			if (existingData == null)
			{
				manufacturer.CreatedOn = DateTime.Now;
				manufacturer.UpdatedOn = DateTime.Now;
				_context.Manufacturers.AddObject(manufacturer);
			}
			else
			{
				existingData.Name = manufacturer.Name;
				existingData.Description = manufacturer.Description;
				existingData.PictureID = manufacturer.PictureID;
				existingData.IsActive = manufacturer.IsActive;
				existingData.CreatedOn = existingData.CreatedOn;
				existingData.UpdatedOn = DateTime.Now;

				if (!_context.IsAttached(existingData))
					_context.Manufacturers.Attach(existingData);
			}
			_context.SaveChanges();
		}

		public void DeleteManufacturer(int manufacturerID)
		{
			if (manufacturerID == 0)
				return;

			Manufacturer manufacturer = GetManufacturerByID(manufacturerID);
			if (manufacturer == null)
				return;

			if (!_context.IsAttached(manufacturer))
				_context.Manufacturers.Attach(manufacturer);
			_context.DeleteObject(manufacturer);
			_context.SaveChanges();
		}

		public void DeactivateManufacturer(int manufacturerID)
		{
			if (manufacturerID == 0)
				return;

			Manufacturer manufacturer = GetManufacturerByID(manufacturerID);
			if (manufacturer == null)
				return;

			manufacturer.IsActive = false;
			manufacturer.UpdatedOn = DateTime.Now;

			if (!_context.IsAttached(manufacturer))
				_context.Manufacturers.Attach(manufacturer);

			_context.SaveChanges();
		}

		#endregion

		//#region ProductCategoryMapping

		//public void SaveProductCategoryMapping(ProductCategoryMapping productCategoryMapping)
		//{
		//    _context.ProductCategoryMappings.AddObject(productCategoryMapping);
		//    _context.SaveChanges();
		//}

		//public void DeleteProductCategoryMapping(int productCategoryID)
		//{
		//    if (productCategoryID == 0)
		//        return;

		//    ProductCategoryMapping productCategoryMapping = new ProductCategoryMapping();

		//    productCategoryMapping = _context.ProductCategoryMappings.FirstOrDefault(c => c.ProductCategoryID == productCategoryID);

		//    if (!_context.IsAttached(productCategoryMapping))
		//        _context.ProductCategoryMappings.Attach(productCategoryMapping);

		//    _context.DeleteObject(productCategoryMapping);
		//    _context.SaveChanges();
		//}

		//public List<Product> GetAllProductByCategory(int categoryID, bool getDeleted)
		//{
		//    if (!getDeleted)
		//    {
		//        var query = from product in _context.Products
		//                    join productCategory in _context.ProductCategoryMappings on
		//                    product.ProductID equals productCategory.ProductID
		//                    where productCategory.ProductCategoryID == categoryID
		//                    orderby product.Name
		//                    select product;
		//        return query.ToList();
		//    }
		//    else
		//    {
		//        var query = from product in _context.Products
		//                    join productCategory in _context.ProductCategoryMappings on
		//                    product.ProductID equals productCategory.ProductID
		//                    join category in _context.Categories on
		//                    productCategory.CategoryID equals category.CategoryID
		//                    where productCategory.ProductCategoryID == categoryID &&
		//                    category.Deleted != true && product.Deleted != true
		//                    orderby product.Name
		//                    select product;
		//        return query.ToList();
		//    }
		//}
		

		//#endregion

		//#region ProductManufacturerMapping

		//public void SaveProductManufacturerMapping(ProductManufacturerMapping productManufacturerMapping)
		//{
		//    _context.ProductManufacturerMappings.AddObject(productManufacturerMapping);
		//    _context.SaveChanges();
		//}

		//public void DeleteProductManufacturerMapping(int productManufacturerID)
		//{
		//    if (productManufacturerID == 0)
		//        return;

		//    ProductManufacturerMapping productManufacturerMapping = new ProductManufacturerMapping();

		//    productManufacturerMapping = _context.ProductManufacturerMappings.FirstOrDefault(c => c.ProductManufacturerID == productManufacturerID);

		//    if (!_context.IsAttached(productManufacturerMapping))
		//        _context.ProductManufacturerMappings.Attach(productManufacturerMapping);

		//    _context.DeleteObject(productManufacturerMapping);
		//    _context.SaveChanges();
		//}

		//public List<Product> GetAllProductByManufacturer(int manufacturerID, bool getDeleted)
		//{
		//    if (!getDeleted)
		//    {
		//        var query = from product in _context.Products
		//                    join productManufacturer in _context.ProductManufacturerMappings on
		//                    product.ProductID equals productManufacturer.ProductID
		//                    where productManufacturer.ManufacturerID == manufacturerID
		//                    orderby product.Name
		//                    select product;
		//        return query.ToList();

		//    }
		//    else
		//    {
		//        var query = from product in _context.Products
		//                    join productManufacturer in _context.ProductManufacturerMappings on
		//                    product.ProductID equals productManufacturer.ProductID
		//                    join manufacturer in _context.Manufacturers on
		//                    productManufacturer.ManufacturerID equals manufacturer.ManufacturerID
		//                    where productManufacturer.ManufacturerID == manufacturerID &&
		//                    manufacturer.Deleted != true && product.Deleted != true
		//                    orderby product.Name
		//                    select product;
		//        return query.ToList();
		//    }
		//}

		//public List<Product> GetAllProductByManufacturerAndCategory(int manufacturerID, int categoryID, bool getDeleted)
		//{

		//    if (!getDeleted)
		//    {
		//        var query = from product in _context.Products
		//                    join productCategory in _context.ProductCategoryMappings on
		//                    product.ProductID equals productCategory.ProductID
		//                    join productManufacturer in _context.ProductManufacturerMappings on
		//                    product.ProductID equals productManufacturer.ProductID
		//                    where productCategory.ProductCategoryID == categoryID &&
		//                    productManufacturer.ManufacturerID == manufacturerID
		//                    select product;
		//        return query.ToList();
		//    }
		//    else
		//    {
		//        var query = from product in _context.Products
		//                    join productCategory in _context.ProductCategoryMappings on
		//                    product.ProductID equals productCategory.ProductID
		//                    join productManufacturer in _context.ProductManufacturerMappings on
		//                    product.ProductID equals productManufacturer.ProductID
		//                    join category in _context.Categories on
		//                    productCategory.CategoryID equals category.CategoryID
		//                    join manufacturer in _context.Manufacturers on
		//                    productManufacturer.ManufacturerID equals manufacturer.ManufacturerID
		//                    where productCategory.ProductCategoryID == categoryID &&
		//                    productManufacturer.ManufacturerID == manufacturerID &&
		//                    category.Deleted != true && product.Deleted != true	&& manufacturer.Deleted != true
		//                    select product;
		//        return query.ToList();
		//    }
		//}

		//#endregion
	}
}
