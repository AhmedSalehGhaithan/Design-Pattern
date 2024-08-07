using System.Collections.Generic;

namespace MediatorDesignPattern.FacebookGroupProject
{
    // Concrete Mediator
    // This is going to be a class implementing the communication operations of the Mediator Interface.
    public class ConcreteFacebookGroupMediator : IFacebookGroupMediator
    {
        //The following variable is going to hold the list of objects to whom we want to communicate
        private List<Users> _users = new List<Users>();

        //The following method simply registers the user with Mediator
        public void RegisterUser(Users user)
        {
            //Adding the user
            _users.Add(user);
            //Registering the user with Mediator
            //sets the Mediator property of the Users object to the current instance of the ConcreteFacebookGroupMediator
            //By setting user.Mediator = this;, you are essentially telling the Users object which mediator it should use to send and receive messages.
            //After this line is executed, the Users object has a reference to the ConcreteFacebookGroupMediator, allowing it to use the mediator to send messages to other users.
            user.Mediator = this;
        }
        //The following method is going to send the message in the group i.e. to the group users
        public void SendMessage(string message, Users user)
        {
            foreach(Users u in _users)
            {
                //Message should not be received by the user sending it
                if(u != user)
                {
                    u.Receive(message);
                }
                    
            }
        }
    }
}
