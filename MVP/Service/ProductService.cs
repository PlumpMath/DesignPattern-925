using System;
using System.Collections.Generic;
using IService;
using ViewModel;
using IRepository;

namespace Service
{
    public class ProductService : IProductService
    {
        IProductRepository repository = null;
        IPromotionService promotionService = null;

        public ProductService(IProductRepository repository, IPromotionService promotionService)
        {
            this.repository = repository;
            this.promotionService = promotionService;
        }

        #region IProductService Members

        public ProductListResponse GetAllProductsFor()
        {
            ProductListResponse productListResponse = new ProductListResponse();
            try
            {
                IList<ProductViewModel> products = repository.GetAllProducts();
                foreach (var product in products)
                {
                    promotionService.Apply(product);
                }

                productListResponse.Products = products;
                productListResponse.Success = true;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                // Log the exception...
                productListResponse.Success = false;
                // Return a friendly error message
                productListResponse.Message = "Check that your database is in the correct place.";
            }
            catch (Exception ex)
            {
                // Log the exception...
                productListResponse.Success = false;
                // Return a friendly error message
                productListResponse.Message = "An error occured";
            }

            return productListResponse;
        }

        #endregion
    }
}
