using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace ViewModel
{
    public class ProductViewModel : Product
    {
        public decimal Discount { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal Point { get; set; }
    }
}
