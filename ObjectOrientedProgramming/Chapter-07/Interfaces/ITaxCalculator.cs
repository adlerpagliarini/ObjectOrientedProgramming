using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming.Chapter_07
{
    public interface ITaxCalculator
    {
        double CalculteTax(ITaxable taxableItems);
    }
}
