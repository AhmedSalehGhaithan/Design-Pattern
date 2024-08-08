using BridgeDesignPattern.ColorExample;
using BridgeDesignPattern.LEDTVProject.Abstraction;
using BridgeDesignPattern.LEDTVProject.ConcreteAbstraction;
using BridgeDesignPattern.LEDTVProject.ConcreteImplementation;
using BridgeDesignPattern.RealTimeExample.Abstraction;
using BridgeDesignPattern.RealTimeExample.ConcreteAbstraction;
using BridgeDesignPattern.RealTimeExample.ConcreteImplementation;
using System;


namespace BridgeDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ColorExample();
            Console.ReadKey();
        }
        static void ColorExample()
        {
            // this example use both bridge and factory design patterns .
            // here below you can create any shape with any color
            // ,just call the static class ' CreateShapeColorStaticClass ' and type desired method 
            CreateShapeColorStaticClass.CreateBlueRectangle();
            CreateShapeColorStaticClass.CreateYellowSquare();
            CreateShapeColorStaticClass.CreateRedCircle();
        }
        static void RealTimeExample()
        {
            Console.WriteLine("Select the Message Type 1. For longmessage or 2. For shortmessage");
            int MessageType = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the message that you want to send");
            string Message = Console.ReadLine();

            if(MessageType == 1)
            {
                AbstractMessage longMessage = new LongMessage(new EmailMessageSender());
                longMessage.SendMessage(Message);
            }
            else
            {
                AbstractMessage shortMessage = new ShortMessage(new SmsMessageSender());
                shortMessage.SendMessage(Message);
            }

        }
        static void LEDTVProject()
        {
            // Except for the initialization phase, where an Abstraction object gets i.e. SonyRemoteControl or SamsungRemoteControl
            // linked with a specific Implementation object i.e. new SonyLedTv() or new SamsungLedTv(), 
            // the client code should only depend on the Abstraction class i.e. SonyRemoteControl or SamsungRemoteControl. 

            AbstractRemoteControl sonyRemoteControl = new SonyRemoteControl(new SonyLedTv());
            sonyRemoteControl.SwitchOn();
            sonyRemoteControl.SetChannel(4);
            sonyRemoteControl.SwitchOff();

            Console.WriteLine();

            AbstractRemoteControl samsungRemoteControl = new SamsungRemoteControl(new SamsungLedTv());
            samsungRemoteControl.SwitchOn();
            samsungRemoteControl.SetChannel(50);
            samsungRemoteControl.SwitchOff();

            Console.WriteLine();

            AbstractRemoteControl nokiaRemoteControl = new NokiaRemoteControl(new NokiaLedTv());
            nokiaRemoteControl.SwitchOn();
            nokiaRemoteControl.SetChannel(45);
            nokiaRemoteControl.SwitchOff();
        }
    }
}
