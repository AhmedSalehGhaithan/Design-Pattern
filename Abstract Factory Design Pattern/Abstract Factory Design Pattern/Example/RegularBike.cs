using System;
namespace Abstract_Factory_Design_Pattern.Example
{
    internal class RegularBike  :IBike
    {
        public void GetDetails()
        {
            Console.WriteLine("Fetching RegularBike Details..");
        }
    }
}
