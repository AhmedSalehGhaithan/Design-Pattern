namespace BridgeDesignPattern.RealTimeExample.Implementer
{
    // This is going to be an interface that acts as a bridge between the Abstraction Layer and Implementation Layer
    // The following Implementor Interface defines the operations for all implementation classes.
    // It doesn't have to match the Abstraction's interface. 
    // In fact, the two interfaces can be entirely different. 
    public interface IMessageSender
    {
        void SendMessage(string Message);
    }
}
