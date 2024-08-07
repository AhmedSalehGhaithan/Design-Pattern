using System;

namespace Factory_Design_Pattern.NotificationsSystem
{
    public class SMSNotification : INotificationSender
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Sending SMS notification: {message}");
            // Logic to send SMS here...
        }
    }
}
