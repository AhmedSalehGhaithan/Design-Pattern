using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern.PaymentGatewayIntegration
{
    public static class PaymentGatewayFactory
    {
        public static IPaymentGateway CreatePaymentGateway(int gatewayName)
        {
            switch (gatewayName)
            {
                case 1:
                    return new PayPalGateway();
                case 2:
                    return new StripeGateway();
                case 3:
                    return new CreditCardGateway();
                default:
                    throw new ArgumentException("Invalid payment gateway specified");
            }
        }
    }
}
