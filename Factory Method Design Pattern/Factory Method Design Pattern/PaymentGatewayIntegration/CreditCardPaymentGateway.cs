using System;

namespace Payment_Gateway_Integration.PaymentGatewayIntegration
{
    public class CreditCardPaymentGateway : IPaymentGateway
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment of amount: ${amount}");
        }
    }
}
