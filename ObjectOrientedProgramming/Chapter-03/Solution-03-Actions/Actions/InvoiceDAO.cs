using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming.Solution_03
{
    public class InvoiceDAO
    {
        public void Execute(Invoice invoice)
        {
            invoice.Actions.Add("InvoiceDAO");
        }
    }
}
