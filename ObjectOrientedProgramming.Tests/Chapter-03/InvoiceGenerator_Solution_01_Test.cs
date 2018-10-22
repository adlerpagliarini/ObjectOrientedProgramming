using NUnit.Framework;
using ObjectOrientedProgramming.Solution_01;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming.Tests.Chapter_03
{
    [TestFixture]
    public class InvoiceGenerator_Solution_01_Test
    {
        private InvoiceGenerator _invoiceGenerator;
        [SetUp]
        public void Initialize()
        {
            var actions = new List<IActionAfterInvoiceGenerator>
            {
                new InvoiceDAO(),
                new SendEmail()
            };
            _invoiceGenerator = new InvoiceGenerator(actions);
        }

        [Test]
        public void GenerateInvoice_ValidateActions()
        {
            var bill = new Bill() { Title = "Celphone", Value = 50 };
            var invoice = _invoiceGenerator.GenerateInvoice(bill);

            Assert.AreEqual(new List<string>() { "InvoiceDAO", "SendEmail" }, invoice.Actions);
        }
    }
}
