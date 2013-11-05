using IService;
using ViewModel;

namespace Presenter
{
    public class ProductListPresenter
    {
        private IProductListView productListView;
        private IProductService productService;

        public ProductListPresenter(IProductListView productListView, IProductService productService)
        {
            this.productListView = productListView;
            this.productService = productService;
        }

        public void Display()
        {
            ProductListResponse productResponse = productService.GetAllProductsFor();
            if (productResponse.Success)
            {
                productListView.Display(productResponse.Products);
            }
            else
            {
                productListView.ErrorMessage = productResponse.Message;
            }
        }
    }
}
