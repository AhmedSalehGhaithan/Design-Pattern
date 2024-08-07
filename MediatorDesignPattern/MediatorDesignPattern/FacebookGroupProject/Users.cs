namespace MediatorDesignPattern.FacebookGroupProject
{
    public abstract class Users
    {
        //This Property holds the name of the user
        protected string Name;
        //This Property is going to set and get the Mediator Instance
        //This Property value is going to be set when we register a user with the Mediator
        public IFacebookGroupMediator Mediator { get; set; }
        public Users(string name) => this.Name = name;
        //The following Methods are going to be Implemented by the Concrete Colleague
        public abstract void Send(string message);
        public abstract void Receive(string message);
    }
}
