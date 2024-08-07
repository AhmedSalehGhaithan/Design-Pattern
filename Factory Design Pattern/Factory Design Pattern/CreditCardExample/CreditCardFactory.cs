using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern.CreditCardExample
{
    public class CreditCardFactory
    {
        public static ICreditCard GetCreditCard(CreditCardEnum creditCard)
        {
            ICreditCard credit = null;

            if(creditCard == CreditCardEnum.MoneyBack)
                credit = new MoneyBack();
            else if(creditCard == CreditCardEnum.Titanium)
                credit = new Titanium();
            else if(creditCard == CreditCardEnum.Platinum)
                credit = new Platinum();

            return credit;
        }
    }
}
