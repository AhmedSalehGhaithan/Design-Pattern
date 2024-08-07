namespace MediatorDesignPattern.FacebookGroupProject
{
    //Mediator Interface
    //This is going to be an Interface that defines operations 
    //which can be called by colleague objects for communication.
    public interface IFacebookGroupMediator
    {
        void SendMessage(string message,Users user);
        void RegisterUser(Users user);
    }
}
