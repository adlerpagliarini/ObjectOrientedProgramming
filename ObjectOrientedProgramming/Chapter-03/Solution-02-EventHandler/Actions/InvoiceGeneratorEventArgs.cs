using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming.Solution_02
{
    public class InvoiceGeneratorEventArgs : EventArgs
    {
        public Invoice Invoice { get; set; }
    }
}
