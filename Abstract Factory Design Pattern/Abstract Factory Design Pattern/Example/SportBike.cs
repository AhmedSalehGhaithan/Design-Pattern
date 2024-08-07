using System;
namespace Abstract_Factory_Design_Pattern.Example
{
    public class SportBike : IBike
    {
        public void GetDetails()
        {
            Console.WriteLine("Fetching SportsBike Details..");
        }
    }
}
