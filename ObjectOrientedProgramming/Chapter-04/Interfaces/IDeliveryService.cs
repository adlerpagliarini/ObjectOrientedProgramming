using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming
{
    public interface IDeliveryService
    {
        double GetDeliveryPriceToLocation(Locations location);
    }
}
