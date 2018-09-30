using NUnit.Framework;
using ObjectOrientedProgramming.Solution_03;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming.Tests
{
    [TestFixture]
    public class InvoiceGenerator_Solution_03_Test
    {
        private InvoiceGenerator _invoiceGenerator;
        [SetUp]
        public void Initialize()
        {
            _invoiceGenerator = new InvoiceGenerator();
            _invoiceGenerator.OnInvoiceGenerated = new InvoiceDAO().Execute;
            _invoiceGenerator.OnInvoiceGenerated += new SendEmail().Execute;
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
