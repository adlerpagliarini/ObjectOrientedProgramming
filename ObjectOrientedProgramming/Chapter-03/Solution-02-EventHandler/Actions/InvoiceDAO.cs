using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming.Solution_02
{
    public class InvoiceDAO
    {
        public void Execute(object source, InvoiceGeneratorEventArgs e)
        {
            e.Invoice.Actions.Add("InvoiceDAO");
        }
    }
}
