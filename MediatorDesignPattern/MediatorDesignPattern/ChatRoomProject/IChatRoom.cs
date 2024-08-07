namespace MediatorDesignPattern.ChatRoomProject
{
    public interface IChatRoom
    {
        void Register(Participant participant);
        void Send(string from, string to, string message);
    }
}
