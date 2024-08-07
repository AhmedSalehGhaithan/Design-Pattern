using System;

namespace Factory_Design_Pattern.NotificationsSystem
{
    //Concrete Implementations for the Products
    public class EmailNotification : INotificationSender
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Sending EMAIL notification: {message}");
            // Logic to send email here...
        }
    }
}
