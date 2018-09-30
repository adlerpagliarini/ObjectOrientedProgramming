using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming.Tests
{
    [TestFixture]
    public class PriceCalculator_Test
    {
        [Test]
        public void Calculate_ShouldCalculateDiscountAndDelivery()
        {
            Mock<IDeliveryService> deliveryService = new Mock<IDeliveryService>();
            Mock<IPriceTable> priceTable = new Mock<IPriceTable>();

            deliveryService.Setup(m => m.GetDeliveryPriceToLocation(It.IsAny<Locations>())).Returns(10);
            priceTable.Setup(m => m.DiscountFor(It.IsAny<double>())).Returns(10);
            var priceCalculator = new PriceCalculator(priceTable.Object, deliveryService.Object);

            var product = new Product() { Title = "Product", Value = 10 };
            var productItem = new ProductItem() { Amount = 10, Product = product };
            var purchase = new Purchase();
            purchase.Location = Locations.NORTH;
            purchase.ProductItens.Add(productItem);

            var result = priceCalculator.Calculate(purchase);

            Assert.AreEqual(100.0, result);

        }


    }
}
