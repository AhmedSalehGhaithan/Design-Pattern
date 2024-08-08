using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern_SDP.Core.DiscountStrategy
{
    internal class GoldCustomerDiscountStrategy : ICustomerDiscountStrategy
    {
        public double CalculateDisCount(double totalPrice)
        {
            return totalPrice >= 10000 ? 0.1 : 0;
        }
    }
}
