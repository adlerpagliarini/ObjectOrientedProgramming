using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming.Chapter_07
{
    public class TaxXYZ : IInvoiceGenerator, ITaxCalculator
    {
        public double CalculteTax(ITaxable taxableItems)
        {
            throw new NotImplementedException();
        }

        public Invoice GenerateInvoice()
        {
            throw new NotImplementedException();
        }
    }
}
