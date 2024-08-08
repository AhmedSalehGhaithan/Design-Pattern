using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern_SDP.Core.DiscountStrategy
{
    public interface ICustomerDiscountStrategy
    {
        double CalculateDisCount(double totalPrice);

    }
}
