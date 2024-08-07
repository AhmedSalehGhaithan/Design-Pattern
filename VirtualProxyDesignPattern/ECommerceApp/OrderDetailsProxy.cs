using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualProxyDesignPattern.ECommerceApp
{
    // Proxy class for lazy initialization of OrderDetails
    public class OrderDetailsProxy : IOrderDetails
    {
        private OrderDetails _orderDetails;
        private readonly Order _order;

        public OrderDetailsProxy(Order order)
        {
            _order = order;
        }

        public void DisplayDetails()
        {
            if (_orderDetails == null)
            {
                Console.WriteLine("Initializing OrderDetails in proxy.");
                _orderDetails = new OrderDetails(_order);
            }
            _orderDetails.DisplayDetails();
        }
    }
}
