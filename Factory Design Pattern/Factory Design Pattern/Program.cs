using Factory_Design_Pattern.CreditCardExample;
using Factory_Design_Pattern.DocumentConversionSystem;
using Factory_Design_Pattern.LoggingSystem;
using Factory_Design_Pattern.NotificationsSystem;
using Factory_Design_Pattern.PaymentGatewayIntegration;
using Factory_Design_Pattern.UIThemeSystem;
using System;
namespace Factory_Design_Pattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            NumberOne();
            Console.ReadLine();
        }

        public static void NumberOne()
        {
            ICreditCard cardDetails = CreditCardFactory.GetCreditCard(CreditCardEnum.MoneyBack);
            //ICreditCard cardDetails = CreditCardFactory.GetCreditCard(CreditCardEnum.Platinum);

            if (cardDetails != null)
            {
                Console.WriteLine("CardType : " + cardDetails.GetCardType());
                Console.WriteLine("CreditLimit : " + cardDetails.GetCreditLimit());
                Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
        }
        public static void NumberTwo()
        {
            int gatewayName = 0;
            do
            {


                Console.WriteLine("Select the payment gateway (PayPal, Stripe, CreditCard,Exit): ");
                gatewayName = int.Parse(Console.ReadLine());
                try
                {
                    if(gatewayName <=3)
                    {
                        IPaymentGateway paymentGateway = PaymentGatewayFactory.CreatePaymentGateway(gatewayName);
                        paymentGateway.ProcessPayment(100.00M);  // Example amount
                    }
                    
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (gatewayName != 4);

        }
        public static void NumberThree()
        {
            Console.WriteLine("Enter the content to convert:");
            string content = Console.ReadLine();
            Console.WriteLine("Select the target format (DOCX, PDF, TXT):");
            int format = int.Parse(Console.ReadLine());
            try
            {
                IDocumentConverter converter = DocumentConverterFactory.CreateDocumentConverter(format);
                string convertedContent = converter.Convert(content);
                Console.WriteLine($"Converted content ({converter.TargetExtension}): {convertedContent}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public static void NumberFour()
        {
            ILogger logger;
            logger = LoggerFactory.CreateLogger("console");
            logger.Log("This is a console log!");
            logger = LoggerFactory.CreateLogger("file");
            logger.Log("This message is written to a file.");
        }
        public static void NumberFive()
        {
            INotificationSender notificationSender;
            notificationSender = NotificationFactory.CreateNotificationSender("email");
            notificationSender.SendNotification("This is an email notification!");
            notificationSender = NotificationFactory.CreateNotificationSender("sms");
            notificationSender.SendNotification("This is an SMS notification!");
            notificationSender = NotificationFactory.CreateNotificationSender("push");
            notificationSender.SendNotification("This is a push notification!");
        }
        public static void NumberSix()
        {
            Console.WriteLine("Select the UI theme (Dark, Light, Blue): ");
            int themeName = int.Parse(Console.ReadLine());
            try
            {
                ITheme theme = ThemeFactory.CreateTheme(themeName);
                theme.ApplyTheme();   // Applying the selected UI theme
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
