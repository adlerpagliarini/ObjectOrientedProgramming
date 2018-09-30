using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectOrientedProgramming
{
    public class Purchase
    {
        public ICollection<ProductItem> ProductItens { get; set; }
        public Locations Location { get; set; }
        public double TotalPrice { get {
                return GetPurchaseTotalPrice();
            }}

        public Purchase()
        {
            ProductItens = new HashSet<ProductItem>();
        }

        private double GetPurchaseTotalPrice()
        {
            return ProductItens.Aggregate(0.0, (acc, productItem) => acc + productItem.GetTotalValue);
        }
    }
}
