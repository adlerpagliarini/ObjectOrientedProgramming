using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming.Chapter_05
{
    public class Example
    {
        public Example()
        {
            var invoice = new PurchaseInvoice(10000);

            if(invoice.GetValueWithoutTax() > 10000)
                Console.WriteLine("//do CalculateTaxValue");
            else
                Console.WriteLine("//do other CalculateTaxValue");

            //the right way to use Encapsulation is using TELL don't ask
            invoice.CalculateTaxValue();

            //exposing private list property and ensuring that it wont be modified
            //invoice.GetListOfValues().Add(1);

        }
    }
}
