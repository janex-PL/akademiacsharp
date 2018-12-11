using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wykład_06a
{
    class OrderService
    {
        private List<Order> orderList;
        public FileLogger fileLog;

        public OrderService()
        {
            orderList = new List<Order>();
            fileLog = new FileLogger();
        }
        public void addOrder(string name, DateTime date, string item, int quantity, double price)
        {
            Order order = new Order(name, date, item, quantity, price);
            orderList.Add(order);
            fileLog.LogOrder($"Dnia {date} odnotowano zamówienie {name}, w którym zamówiono {item} w ilości {quantity} w cenie {price}zł za sztukę");
        }

    }
}
