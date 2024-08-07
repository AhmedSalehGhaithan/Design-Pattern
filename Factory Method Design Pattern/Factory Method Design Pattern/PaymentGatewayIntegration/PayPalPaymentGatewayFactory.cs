namespace Payment_Gateway_Integration.PaymentGatewayIntegration
{
    internal class PayPalPaymentGatewayFactory : IPaymentGatewayFactory
    {
        public IPaymentGateway CreatePaymentGateway()
        {
            return new PayPalPaymentGateway();
        }
    }
}
