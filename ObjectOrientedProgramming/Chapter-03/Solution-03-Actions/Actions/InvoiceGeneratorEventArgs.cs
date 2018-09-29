using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming.Solution_03
{
    public class InvoiceGeneratorEventArgs : EventArgs
    {
        public Invoice Invoice { get; set; }
    }
}
