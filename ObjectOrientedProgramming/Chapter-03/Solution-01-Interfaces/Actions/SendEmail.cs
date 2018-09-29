using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming.Solution_01
{
    public class SendEmail : IActionAfterInvoiceGenerator
    {
        public string Execute()
        {
            return "SendEmail";
        }
    }
}
