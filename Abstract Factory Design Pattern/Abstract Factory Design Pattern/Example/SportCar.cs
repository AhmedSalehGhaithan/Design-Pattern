using System;
namespace Abstract_Factory_Design_Pattern.Example
{
    public class SportCar : ICar
    {
        public void GetDetails()
        {
            Console.WriteLine("Fetching SportsCar Details..");
        }
    }
}
