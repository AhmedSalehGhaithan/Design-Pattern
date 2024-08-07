using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualProxyDesignPattern.ECommerceApp
{
    public class OrderDetails : IOrderDetails
    {
        private readonly Order _order;

        public OrderDetails(Order order)
        {
            _order = order;
            Console.WriteLine("OrderDetails initialized.");
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Order ID: {_order.OrderId}");
            Console.WriteLine("Products in this order:");

            foreach (var product in _order.Products)
            {
                Console.WriteLine(product);
            }
        }
    }
}
