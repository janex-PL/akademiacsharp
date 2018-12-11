using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wykład_06a
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService orderService = new OrderService();
            orderService.addOrder("1234",DateTime.Now, "Koszulka", 1, 25.99);
            orderService.addOrder("3012",DateTime.Now, "Bluza", 2, 55.99);
            orderService.addOrder("1010",DateTime.Now, "Spodnie", 4, 10.99);
            orderService.fileLog.PrintAllOrders();

        }
    }
}
