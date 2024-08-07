namespace Payment_Gateway_Integration.PaymentGatewayIntegration
{
    internal class BitcoinPaymentGatewayFactory : IPaymentGatewayFactory
    {
        public IPaymentGateway CreatePaymentGateway()
        {
            return new BitcoinPaymentGateway();
        }
    }
}
