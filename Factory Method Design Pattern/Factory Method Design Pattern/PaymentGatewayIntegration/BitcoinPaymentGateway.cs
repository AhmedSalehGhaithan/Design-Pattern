using System;

namespace Payment_Gateway_Integration.PaymentGatewayIntegration
{
    public class BitcoinPaymentGateway : IPaymentGateway
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing Bitcoin payment of amount: ${amount}");
        }
    }
}
