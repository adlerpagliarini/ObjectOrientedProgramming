using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming
{
    public class PriceTable : IPriceTable
    {
        public double DiscountFor(double value)
        {
            if (value < 100) return value;

            return value * 0.9;
        }
    }
}
