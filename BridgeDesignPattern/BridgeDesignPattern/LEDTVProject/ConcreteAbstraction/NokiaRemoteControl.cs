using BridgeDesignPattern.LEDTVProject.Abstraction;
using BridgeDesignPattern.LEDTVProject.Implementer;

namespace BridgeDesignPattern.LEDTVProject.ConcreteAbstraction
{
    public class NokiaRemoteControl : AbstractRemoteControl
    {
        public NokiaRemoteControl(ILEDTV ledTv) => _ledTv = ledTv;
        public override void SwitchOn() => _ledTv.SwitchOn();
        public override void SwitchOff() => _ledTv.SwitchOff();
        public override void SetChannel(int channelNumber) => _ledTv.SetChannel(channelNumber);
    }
}
