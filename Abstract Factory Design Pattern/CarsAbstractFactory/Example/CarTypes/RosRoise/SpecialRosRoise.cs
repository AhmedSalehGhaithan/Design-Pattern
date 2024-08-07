using System;

namespace CarsAbstractFactory.Example.CarTypes.RosRoise
{
    public class SpecialRosRoise : IRosRoise
    {
        public void GetDetails()
        {
            Console.WriteLine("Special RosRoise car details....");
        }
    }
}
