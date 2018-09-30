using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming
{
    public class ProductItem
    {
        public Product Product { get; set; }
        public int Amount { get; set; }

        public double GetTotalValue { get { return Product.Value * Amount; } }
    }
}
