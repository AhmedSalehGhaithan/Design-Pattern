using System;
using System.Diagnostics;
namespace Decorator_Design_Pattern.OrderExample
{
    public class OrderProcessorProfilingDecorator : IOrderProcessor
    {
        public OrderProcessorProfilingDecorator( IOrderProcessor orderProcessor)
        {
            _orderProcessor = orderProcessor;
        }

        public IOrderProcessor _orderProcessor { get; }

        public void Process(Order order)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            _orderProcessor.Process(order);
            stopwatch.Stop();
            Console.WriteLine($"Order toke '{stopwatch.Elapsed.TotalMilliseconds}ms' To be processed");
        }
    }
}
