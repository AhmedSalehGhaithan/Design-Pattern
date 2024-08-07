using System;
using System.Collections;
using System.Collections.Generic;

namespace Decorator_Design_Pattern.OrderExample    
{
    public class OrderProcessorQueuingDecorator : IOrderProcessor
    {
        public OrderProcessorQueuingDecorator(IOrderProcessor orderProcessor)
        {
            _orderProcessor = orderProcessor;
        }

        public IOrderProcessor _orderProcessor { get; }

        private Queue<Order> _orders = new Queue<Order>();

        public void Process(Order order)
        {
            _orders.Enqueue(order);
            Console.WriteLine("Order has been queued");
        }
    }
}
