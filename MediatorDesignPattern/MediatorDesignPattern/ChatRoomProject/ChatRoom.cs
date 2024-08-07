using System.Collections.Generic;

namespace MediatorDesignPattern.ChatRoomProject
{
    public class ChatRoom : IChatRoom
    {
        private Dictionary<string ,Participant> _participants = new Dictionary<string ,Participant>();
        public void Register(Participant participant)
        {
            // Check if the participant is already registered
            if (!_participants.ContainsValue(participant))
            {
                // Add the participant to the dictionary
                _participants[participant.Name] = participant;
                // Set the participant's ChatRoom property to this ChatRoom instance
                participant.chatRoom = this;
            }
        }

        public void Send(string from, string to, string message)
        {
            // Find the recipient participant by name
            Participant participant = _participants[to]; 
            if (participant != null) // Check if the recipient exists
            {
                // Call the Receive method on the recipient to deliver the message
                participant.Receive(from, message); 
            }
        }
    }
}
