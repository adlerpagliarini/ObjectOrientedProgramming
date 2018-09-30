using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming.Solution_01
{
    public class InvoiceGenerator
    {
        private readonly IList<IActionAfterInvoiceGenerator> _actions;

        public InvoiceGenerator(IList<IActionAfterInvoiceGenerator> actions)
        {
            _actions = actions;
        }

        public Invoice GenerateInvoice(Bill bill)
        {
            Invoice invoice = new Invoice(bill);

            foreach (var action in _actions)
                invoice.Actions.Add(action.Execute());

            return invoice;
        }
    }
}
