using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Presenter;
using Service;
using Repository;
using Service.PromotionService;
using IService;
using IRepository;
using ViewModel;

namespace WebAppTest
{
    public partial class _Default : System.Web.UI.Page, IProductListView
    {
        private ProductListPresenter presenter = null;
        private IProductService productService = null;
        private IPromotionService promotionService = null;
        private IProductRepository productRepository = null;

        protected void Page_Init(object sender, EventArgs e)
        {
            productRepository = new ProductRepository();
            promotionService = new DiscountService();
            RePresent();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            presenter.Display();
        }

        protected void OnDiscountClick(object sender, EventArgs e)
        {
            promotionService = new DiscountService(decimal.Parse(tbDiscount.Text));
            RePresent();
        }

        protected void OnReturnClick(object sender, EventArgs e)
        {
            promotionService = new ReturnMoneyService(decimal.Parse(tbReturnCondition.Text), decimal.Parse(tbReturn.Text));
            RePresent();
        }

        protected void OnPointClick(object sender, EventArgs e)
        {
            promotionService = new ReturnPointService(decimal.Parse(tbPointCondition.Text), decimal.Parse(tbPoint.Text));
            RePresent();
        }

        private void RePresent()
        {
            productService = new ProductService(productRepository, promotionService);
            presenter = new ProductListPresenter(this, productService);
            presenter.Display();
        }

        public void Display(IList<ProductViewModel> Products)
        {
            rpt.DataSource = Products;
            rpt.DataBind();
        }

        public string ErrorMessage
        {
            set { lblErrorMessage.Text = String.Format("<p><strong>Error</strong><br/>{0}<p/>", value); }
        }
    }
}
