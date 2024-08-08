using BridgeDesignPattern.RealTimeExample.Abstraction;
using BridgeDesignPattern.RealTimeExample.Implementer;

namespace BridgeDesignPattern.RealTimeExample.ConcreteAbstraction
{
    public class LongMessage : AbstractMessage
    {
        public LongMessage(IMessageSender messageSender) => _messageSender = messageSender; 
        public override void SendMessage(string message) => _messageSender.SendMessage(message);
    }
}
