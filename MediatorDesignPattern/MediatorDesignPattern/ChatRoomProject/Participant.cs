using System;

namespace MediatorDesignPattern.ChatRoomProject
{
    public class Participant
    {
        public string Name { get; set; }
        public IChatRoom chatRoom;
        public Participant(string name) => Name = name;
        public void Send(string to, string message) => chatRoom.Send(Name, to, message);// Use the chat room to send a message to another participant
        public void Receive(string from, string message) => Console.WriteLine($"{from} to {Name}: '{message}'");

    }
}