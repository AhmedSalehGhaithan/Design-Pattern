using System;
namespace MediatorDesignPattern.FacebookGroupProject
{
    //Concrete Colleague
    //These are the classes that communicate with each other via the mediator
    public class ConcreteUser : Users
    {
        //Parameterized Constructor is required to set the base class Name Property
        public ConcreteUser(string name) : base(name)
        {
        }
        //Overriding the Receive Method
        //This method is going to use by the Mediator to send the message to each member of the group
        public override void Receive(string message)
        {
            Console.WriteLine($"{this.Name} Receive Message : {message}");
        }

        //This method is used to send the message to the Mediator by a user
        public override void Send(string message)
        {
            Console.WriteLine($"{this.Name} Sending Message : {message}");
            //Mediator refers to the IFacebookGroupMediator instance associated with the ConcreteUser
            Mediator.SendMessage(message, this);
        }
    }
}
