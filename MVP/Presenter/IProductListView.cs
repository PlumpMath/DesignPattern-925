using System.Collections.Generic;
using ViewModel;

namespace Presenter
{
    public interface IProductListView
    {
        void Display(IList<ProductViewModel> Products);
        string ErrorMessage { set; }
    }
}
