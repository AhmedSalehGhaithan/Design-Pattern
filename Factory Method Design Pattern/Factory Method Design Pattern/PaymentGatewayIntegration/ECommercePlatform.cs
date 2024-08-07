namespace Payment_Gateway_Integration.PaymentGatewayIntegration
{
    public class ECommercePlatform
    {
        public void Checkout(IPaymentGatewayFactory factory,decimal amount)
        {
            IPaymentGateway paymentGateway = factory.CreatePaymentGateway();
            paymentGateway.ProcessPayment(amount);
        }
    }
}
