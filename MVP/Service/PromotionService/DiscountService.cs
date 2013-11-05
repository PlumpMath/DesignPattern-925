using IService;
using ViewModel;

namespace Service.PromotionService
{
    public class DiscountService : IPromotionService
    {
        private decimal discount;

        public DiscountService()
        {
            this.discount = 0.8m;
        }

        public DiscountService(decimal discount)
        {
            this.discount = discount;
        }

        #region IPromoteService Members

        public void Apply(ProductViewModel productViewModel)
        {
            productViewModel.Discount = this.discount;
            productViewModel.SellingPrice = productViewModel.Price * this.discount;
            productViewModel.Point = 0m;
        }

        #endregion
    }
}
