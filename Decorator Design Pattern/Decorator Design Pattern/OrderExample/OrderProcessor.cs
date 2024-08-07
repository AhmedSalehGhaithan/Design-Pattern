using System;
using System.Linq;
using System.Threading;

namespace Decorator_Design_Pattern.OrderExample
{
    public class OrderProcessor : IOrderProcessor
    {
        public virtual void Process(Order order)
        {
            if (order.Lines.Count() == 0)
                throw new Exception("Order is empty");

            Random random = new Random();
            Thread.Sleep(random.Next(1000, 3000));
            Console.WriteLine("Order has been processed");
        }
    }
}
