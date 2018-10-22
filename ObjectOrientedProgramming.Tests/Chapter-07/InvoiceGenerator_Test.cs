using Moq;
using NUnit.Framework;
using ObjectOrientedProgramming.Chapter_07.Services;

namespace ObjectOrientedProgramming.Tests.Chapter_07
{
    [TestFixture]
    public class InvoiceGenerator_Test
    {
        [Test]
        public void GenereteInvoice_ShouldCalculateTaxesForItems()
        {
            var invoiceGenerator = new InvoiceGenerator();
            var result = invoiceGenerator.GenerateInvoice().Value;

            Assert.AreEqual(0.3, result, 0.0001);

        }


    }
}
