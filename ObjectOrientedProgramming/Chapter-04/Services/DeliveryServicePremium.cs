using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming
{
    public class DeliveryServicePremium : IDeliveryService
    {
        public double GetDeliveryPriceToLocation(Locations location)
        {
            if (location.ToString() == Locations.NORTH.ToString())
                return 20;

            if (location.ToString() == Locations.EAST.ToString())
                return 30;

            if (location.ToString() == Locations.SOUTH.ToString())
                return 40;

            if (location.ToString() == Locations.WEST.ToString())
                return 50;

            throw new NotImplementedException();
        }
    }
}
