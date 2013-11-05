using System.Collections.Generic;
using ViewModel;

namespace IRepository
{
    public interface IProductRepository
    {
        IList<ProductViewModel> GetAllProducts();
    }
}
