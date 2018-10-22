using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming.Chapter_07.Services
{
    public class InvoiceGenerator : IInvoiceGenerator
    {
        private ITaxCalculator _taxCalculator => new TaxCalculator();

        public Invoice GenerateInvoice()
        {
            ITaxable itemsToBeTaxable = new Taxable(new Invoice().ItemsToBeTaxable);
            var result = _taxCalculator.CalculteTax(itemsToBeTaxable);
            return new Invoice() { Value = result };
        }
    }
}
