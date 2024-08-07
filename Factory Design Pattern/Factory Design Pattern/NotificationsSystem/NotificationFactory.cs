using System;

namespace Factory_Design_Pattern.NotificationsSystem
{
    //Factory Class to Produce the Products
    public static class NotificationFactory
    {
        public static INotificationSender CreateNotificationSender(string type)
        {
            switch (type.ToLower())
            {
                case "email":
                    return new EmailNotification();
                case "sms":
                    return new SMSNotification();
                case "push":
                    return new PushNotification();
                default:
                    throw new ArgumentException("Invalid notification type");
            }
        }
    }
}
