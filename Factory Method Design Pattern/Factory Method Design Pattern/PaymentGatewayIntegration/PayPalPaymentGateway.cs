using System;
namespace Payment_Gateway_Integration.PaymentGatewayIntegration
{
    public class PayPalPaymentGateway : IPaymentGateway
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing PayPal payment of amount: ${amount}");
        }
    }
}
