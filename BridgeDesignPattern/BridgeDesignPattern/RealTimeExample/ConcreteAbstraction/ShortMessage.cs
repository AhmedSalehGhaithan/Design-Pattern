using BridgeDesignPattern.RealTimeExample.Abstraction;
using BridgeDesignPattern.RealTimeExample.Implementer;
using System;

namespace BridgeDesignPattern.RealTimeExample.ConcreteAbstraction
{
    public class ShortMessage : AbstractMessage
    {
        //The constructor expected an argument of type object which implements the IMessageSender interface
        public ShortMessage(IMessageSender messageSender) => _messageSender = messageSender;

        public override void SendMessage(string message)
        {
            if(message.Length <= 10)
                _messageSender.SendMessage(message);
            else
                Console.WriteLine("Unable to send the message as length > 10 characters");
        }
    }
}
