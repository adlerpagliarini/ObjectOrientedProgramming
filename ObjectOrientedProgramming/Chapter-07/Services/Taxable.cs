using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming.Chapter_07.Services
{
    /* Creating a simple way to pass parameters for TaxCalculator */
    public class Taxable : ITaxable
    {
        public List<Item> ItemsToBeTaxable { get; }
        public Taxable(List<Item> itemsToBeTaxable)
        {
            ItemsToBeTaxable = itemsToBeTaxable;
        }
    }
}
