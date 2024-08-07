using System;
namespace Abstract_Factory_Design_Pattern.Example
{
    public class RegularCar: ICar
    {
        public void GetDetails()
        {
            Console.WriteLine("Fetching RegularCar Details..");
        }
    }
}
