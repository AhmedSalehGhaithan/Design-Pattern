using BridgeDesignPattern.RealTimeExample.Implementer;
using System;
namespace BridgeDesignPattern.RealTimeExample.ConcreteImplementation
{
    public class SmsMessageSender : IMessageSender
    {
        public void SendMessage(string Message)
            => Console.WriteLine("'" + Message + "'   : This Message has been sent using SMS");
    }
}
