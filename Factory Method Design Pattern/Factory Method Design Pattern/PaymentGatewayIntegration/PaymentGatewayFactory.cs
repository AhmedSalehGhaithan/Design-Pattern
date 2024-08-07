namespace Payment_Gateway_Integration.PaymentGatewayIntegration
{
    public interface IPaymentGatewayFactory
    {
         IPaymentGateway CreatePaymentGateway();
    }
}
