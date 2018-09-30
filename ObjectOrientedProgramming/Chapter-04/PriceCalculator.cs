using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming
{
    public class PriceCalculator
    {
        protected readonly IPriceTable _priceTable;
        protected readonly IDeliveryService _deliveryService;

        public PriceCalculator(IPriceTable priceTable, IDeliveryService deliveryService)
        {
            _priceTable = priceTable;
            _deliveryService = deliveryService;
        }

        public double Calculate(Purchase purchase)
        {
            double discount = _priceTable.DiscountFor(purchase.TotalPrice);
            double deliveryPrice = _deliveryService.GetDeliveryPriceToLocation(purchase.Location);

            return purchase.TotalPrice - discount + deliveryPrice;
        }
    }
}
