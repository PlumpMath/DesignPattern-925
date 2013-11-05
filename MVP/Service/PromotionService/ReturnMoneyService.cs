using System;
using IService;
using ViewModel;

namespace Service.PromotionService
{
    public class ReturnMoneyService : IPromotionService
    {
        private decimal moneyRequire = 0.0m;
        private decimal moneyReturn  = 0.0m;

        public ReturnMoneyService(decimal moneyRequire, decimal moneyReturn)
        {
            this.moneyRequire = moneyRequire;
            this.moneyReturn  = moneyReturn;
        }

        #region IPromoteService Members

        public void Apply(ProductViewModel productViewModel)
        {
            decimal price = productViewModel.Price;
            if (price >= moneyRequire)
            {
                productViewModel.SellingPrice = price - Math.Floor(price / moneyRequire) * moneyReturn;
                productViewModel.Discount = Math.Round(productViewModel.SellingPrice / productViewModel.Price, 2);
                productViewModel.Point = 0m;
            }
        }

        #endregion
    }
}
