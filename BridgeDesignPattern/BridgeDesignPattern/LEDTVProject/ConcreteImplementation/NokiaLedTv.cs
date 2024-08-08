using BridgeDesignPattern.LEDTVProject.Implementer;
using System;

namespace BridgeDesignPattern.LEDTVProject.ConcreteImplementation
{
    public class NokiaLedTv : ILEDTV
    {
        public void SwitchOn() 
            => Console.WriteLine("Turning ON : Nokia TV");
        public void SwitchOff() 
            => Console.WriteLine("Turning OFF : Nokia TV");
        public void SetChannel(int channelNumber) 
            => Console.WriteLine("Setting channel Number " + channelNumber + " on Nokia TV");
    }
}
