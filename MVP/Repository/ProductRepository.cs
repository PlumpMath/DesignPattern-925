using System;
using System.Collections.Generic;
using IRepository;
using ViewModel;

namespace Repository
{
    public class ProductRepository : IProductRepository
    {
        #region IProductRepository Members

        public IList<ProductViewModel> GetAllProducts()
        {
            return new List<ProductViewModel>()
            {
                new ProductViewModel(){ProductId = 1, ProductName="P1", BrandName="B1", Price=100},
                new ProductViewModel(){ProductId = 2, ProductName="P2", BrandName="B2", Price=200},
                new ProductViewModel(){ProductId = 3, ProductName="P3", BrandName="B3", Price=300},
                new ProductViewModel(){ProductId = 4, ProductName="P4", BrandName="B4", Price=400},
                new ProductViewModel(){ProductId = 5, ProductName="P5", BrandName="B5", Price=500}
            };
        }

        #endregion
    }
}
