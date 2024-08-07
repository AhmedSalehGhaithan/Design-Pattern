using System;

namespace Notification_System.NotificationSystem
{
    // Concrete Products
    public class EmailNotifier : INotifier
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Sending Email: {message}");
            // Actual email sending logic goes here...
        }
    }
}
