using ObjectOrientedProgramming.Chapter_07.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming.Chapter_07
{
    public class Invoice : ITaxable
    {
        /* JustForExemplify */
        public Invoice(Client client, List<Item> itens, List<Discount> discounts, Address delivery, Address billing, PaymentType paymentType, double value)
        { /*...*/ }
        public Client Client { get; set; }
        public List<Discount> Discounts { get; set; }
        public Address Delivery { get; set; }
        public Address Billing { get; set; }
        public PaymentType PaymentType { get; set; }
        public double Value { get; set; }
        /* JustForExemplify */

        public List<Item> Items { get; set; }
        public Invoice()
        {
            Items = new List<Item>
            {
                new Item(){ Value = 10 },
                new Item(){ Value = 20 }
            };
        }
        public List<Item> ItemsToBeTaxable => Items;

    }
}
