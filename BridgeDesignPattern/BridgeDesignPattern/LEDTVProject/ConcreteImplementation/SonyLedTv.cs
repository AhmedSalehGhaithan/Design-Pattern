using BridgeDesignPattern.LEDTVProject.Implementer;
using System;
namespace BridgeDesignPattern.LEDTVProject.ConcreteImplementation
{
    // Each Concrete Implementation corresponds to a specific platform
    // This is going to be a class and should implement the Implementation interface
    public class SonyLedTv : ILEDTV
    {
        public void SwitchOn()
           => Console.WriteLine("Turning ON : Sony TV");
        public void SwitchOff()
            => Console.WriteLine("Turning OFF : Sony TV");
        public void SetChannel(int channelNumber)
            => Console.WriteLine("Setting channel Number " + channelNumber + " on Sony TV");
        
    }
}
