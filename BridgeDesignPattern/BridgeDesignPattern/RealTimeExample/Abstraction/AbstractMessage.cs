using BridgeDesignPattern.RealTimeExample.Implementer;

namespace BridgeDesignPattern.RealTimeExample.Abstraction
{
    public abstract class AbstractMessage
    {
        protected IMessageSender _messageSender;
        public abstract void SendMessage(string message);
    }
}
