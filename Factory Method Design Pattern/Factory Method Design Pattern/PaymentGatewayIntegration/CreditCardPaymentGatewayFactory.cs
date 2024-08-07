namespace Payment_Gateway_Integration.PaymentGatewayIntegration
{
    public class CreditCardPaymentGatewayFactory : IPaymentGatewayFactory
    {
        public IPaymentGateway CreatePaymentGateway()
        {
            return new CreditCardPaymentGateway();
        }
    }
}
