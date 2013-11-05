using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IService;
using ViewModel;

namespace Service.PromotionService
{
    public class ReturnPointService : IPromotionService
    {
        private decimal moneyRequire = 0.0m;
        private decimal returnRate  = 0.0m;

        public ReturnPointService(decimal moneyRequire, decimal returnRate)
        {
            this.moneyRequire = moneyRequire;
            this.returnRate   = returnRate;
        }

        #region IPromotionService Members

        public void Apply(ProductViewModel productViewModel)
        {
            decimal price = productViewModel.Price;
            if (price >= moneyRequire)
            {
                productViewModel.Point = Math.Floor(price * returnRate);
                productViewModel.SellingPrice = productViewModel.Price;
                productViewModel.Discount = 0m;
            }
        }

        #endregion
    }
}
