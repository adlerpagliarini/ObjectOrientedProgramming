using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ObjectOrientedProgramming.Chapter_05
{
    public class PurchaseInvoice
    {
        private double Value { get; set; }
        private List<double> Values { get; set; }

        public double GetValueWithoutTax()
        {
            return Value;
        }

        public double CalculateTaxValue()
        {
            if (Value >= 10000)
                return Value * 0.8;
            return Value * 0.9;
        }

        //exposing private list property and ensuring that it wont be modified
        public ReadOnlyCollection<double> GetListOfValues()
        {
            return Values.AsReadOnly();
        }

        public PurchaseInvoice(double value)
        {
            Value = value;
            Values = new List<double>();
        }


    }
}
