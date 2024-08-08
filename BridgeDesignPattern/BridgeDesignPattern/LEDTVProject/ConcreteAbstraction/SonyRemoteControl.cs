using BridgeDesignPattern.LEDTVProject.Abstraction;
using BridgeDesignPattern.LEDTVProject.Implementer;

namespace BridgeDesignPattern.LEDTVProject.ConcreteAbstraction
{
    // This is going to be a concrete class which inherits from the Abstraction class i.e. AbstractRemoteControl. 
    // This Redefined Abstraction Class extends the interface defined by AbstractRemoteControl class.
    public class SonyRemoteControl : AbstractRemoteControl
    {
        public SonyRemoteControl(ILEDTV ledTv) => _ledTv = ledTv;
        public override void SwitchOn() =>_ledTv.SwitchOn();
        public override void SwitchOff() => _ledTv.SwitchOff();
        public override void SetChannel(int channelNumber) => _ledTv.SetChannel(channelNumber);
    }
}
