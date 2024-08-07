using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern.PaymentGatewayIntegration
{
    public interface IPaymentGateway
    {
        void ProcessPayment(decimal amount);
    }
}
