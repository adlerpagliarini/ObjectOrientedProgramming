using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming
{
    public class Invoice
    {
        public Bill Bill { get; private set; }
        public double TaxValue
        {
            get => Bill.Value * 0.1;
        }

        public List<string> Actions { get; set; }

        public Invoice(Bill bill)
        {
            Bill = bill;
            Actions = new List<string>();
        }
    }
}
