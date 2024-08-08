using StrategyDesignPattern_SDP.Core.DiscountStrategy;
using StrategyDesignPattern_SDP.SDP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern_SDP.Core
{
    public class InvoiceManager
    {
        private ICustomerDiscountStrategy _customerDiscountStrategy;
        public void SetDiscountStrategy(ICustomerDiscountStrategy strategy)
        {
            _customerDiscountStrategy = strategy;
        }
        public Invoice CreateInvoice(Customer customer,double quantity,double unitPrice)
        {
            var Invoice = new Invoice
            {
                Customer = customer,
                Lines = new[]
                   {
                        new InvoiceLine { Quantity = quantity, UnitPrice = unitPrice }
                   }
            };
            Invoice.DiscountPercentage = _customerDiscountStrategy.CalculateDisCount(quantity);
            return Invoice;
        }
    }
}
