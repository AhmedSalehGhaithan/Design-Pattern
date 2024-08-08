using StrategyDesignPattern_SDP.Core;
using StrategyDesignPattern_SDP.Core.DiscountStrategy;
using StrategyDesignPattern_SDP.SDP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern_SDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dataReader = new CustomerDataReader();
            var customers = dataReader.GetCustomer();

            while (true)
            {
                Console.WriteLine("Customer List : [1].Ahmed ghaithan  [2].Mohamed gasser" );

                Console.Write("Enter customer Id : ");
                var customerId = int.Parse( Console.ReadLine() );

                Console.Write("Enter item Quantity : ");
                var ItemQuantity = int.Parse(Console.ReadLine() );

                Console.WriteLine("Enter the unit price : ");
                var unitPrice = int.Parse( Console.ReadLine() );

                var customer = customers.First(x =>x.Id == customerId);

                ICustomerDiscountStrategy customerDiscountStrategy = null;
                if(customer.Category == CustomerCategory.Silver)
                    customerDiscountStrategy = new SilverCustomerDiscountStrategy();
                else if (customer.Category == CustomerCategory.Gold)
                    customerDiscountStrategy = new GoldCustomerDiscountStrategy();
                var invoiceManager = new InvoiceManager();

                invoiceManager.SetDiscountStrategy(customerDiscountStrategy);

                var invoice = invoiceManager.CreateInvoice(customer, ItemQuantity, unitPrice);

                Console.WriteLine($"Invoice created for Customer '{customer.Name}' with Net Price '${invoice.NetPrice}'");
                Console.WriteLine("Press another key to create another invoice");
                Console.ReadKey();
                Console.WriteLine("-------------------------------------");
            }
        }
    }
}
