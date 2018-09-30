using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming
{
    public interface IPriceTable
    {
        double DiscountFor(double value);
    }
}
