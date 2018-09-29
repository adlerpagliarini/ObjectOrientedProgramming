using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming.Solution_02
{
    public class InvoiceGenerator
    {

        public event EventHandler<InvoiceGeneratorEventArgs> InvoiceGeneratorEventArgs;
       
        public Invoice GenerateInvoice(Bill bill)
        {
            Invoice invoice = new Invoice(bill);

            OnInvoiceGenerated(invoice);

            return invoice;
        }

        private void OnInvoiceGenerated(Invoice invoice)
        {
            InvoiceGeneratorEventArgs(this, new InvoiceGeneratorEventArgs() { Invoice = invoice });
        }
    }
}
