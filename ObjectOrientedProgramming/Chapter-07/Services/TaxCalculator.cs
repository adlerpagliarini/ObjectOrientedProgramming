using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming.Chapter_07.Services
{
    public class TaxCalculator : ITaxCalculator
    {
        public double CalculteTax(ITaxable taxableItems)
        {
            double total = 0;
            foreach (Item item in taxableItems.ItemsToBeTaxable)
                if (item.Value > 1000)
                    total += item.Value * 0.02;
                else
                    total += item.Value * 0.01;

            return total;
        }        
    }
}
