using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ViewModel;

namespace IService
{
    public interface IPromotionService
    {
        void Apply(ProductViewModel productViewModel);
    }
}
