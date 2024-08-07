using System;

namespace Factory_Design_Pattern.NotificationsSystem
{
    public class PushNotification : INotificationSender
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Sending PUSH notification: {message}");
            // Logic to send push notification here...
        }
    }
}
