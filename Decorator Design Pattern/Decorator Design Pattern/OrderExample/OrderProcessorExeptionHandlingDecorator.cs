using System;

namespace Decorator_Design_Pattern.OrderExample
{
    public class OrderProcessorExeptionHandlingDecorator : IOrderProcessor
    {
        public OrderProcessorExeptionHandlingDecorator(IOrderProcessor orderProcessor)
        {
            _orderProcessor = orderProcessor;
        }
        public IOrderProcessor _orderProcessor { get; }
        public void Process(Order order)
        {
            try
            {
                _orderProcessor.Process(order);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
