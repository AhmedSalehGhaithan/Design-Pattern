using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern_SDP.SDP
{
    public class CustomerDataReader
    {
        public IEnumerable<Customer> GetCustomer()
        {
            return new[]
            {
                new Customer
                {
                    Id = 1,
                    Name = "Ahmed ghaithan",
                    Category = CustomerCategory.Gold
                },
                new Customer
                {
                    Id= 2,
                    Name = "Mohamed gasser",
                    Category = CustomerCategory.Silver
                }
            };
        }
    }
}
