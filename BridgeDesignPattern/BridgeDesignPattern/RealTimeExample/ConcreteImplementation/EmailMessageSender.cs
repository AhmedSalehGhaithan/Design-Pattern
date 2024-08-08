using BridgeDesignPattern.RealTimeExample.Implementer;
using System;
namespace BridgeDesignPattern.RealTimeExample.ConcreteImplementation
{
    public class EmailMessageSender : IMessageSender
    {
        public void SendMessage(string Message)
            => Console.WriteLine("'" + Message + "'   : This Message has been sent using Email");
    }
}
