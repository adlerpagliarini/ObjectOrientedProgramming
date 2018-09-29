using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming.Solution_03
{
    public class InvoiceGenerator
    {

        public Action<Invoice> OnInvoiceGenerated;

        public Invoice GenerateInvoice(Bill bill)
        {
            Invoice invoice = new Invoice(bill);

            OnInvoiceGenerated(invoice);

            return invoice;
        }
    }
}
