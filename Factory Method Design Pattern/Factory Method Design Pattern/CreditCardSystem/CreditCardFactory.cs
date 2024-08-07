using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Design_Pattern.CreditCardSystem
{
    // The CreditCardFactory Creator class declares the factory method 
    // that is going to return an object of a Product class. 
    // The CreditCardFactory subclasses usually provide the implementation of the MakeProduct method.
    public abstract class CreditCardFactory
    {
        protected abstract CreditCard MakeProduct();
        // Also note that The Creator's primary responsibility is not creating products. 
        // Usually, it contains some core business logic that relies on Product objects, returned by the factory method. 
        public CreditCard CreateProduct()
        {
            //Call the MakeProduct which will create and return the appropriate object 
            CreditCard creditCard = this.MakeProduct();
            //Return the Object to the Client
            return creditCard;
        }
    }
}
