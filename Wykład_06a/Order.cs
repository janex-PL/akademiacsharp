using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wykład_06a
{
    public class Order
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Item { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public Order(string name, DateTime date, string item, int quantity, double price)
        {
            Date = date;
            Name = name;
            Item = item;
            Quantity = quantity;
            Price = price;
        }
    }
}
