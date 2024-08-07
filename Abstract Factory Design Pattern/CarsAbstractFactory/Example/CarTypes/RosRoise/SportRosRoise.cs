using System;

namespace CarsAbstractFactory.Example.CarTypes.RosRoise
{
    internal class SportRosRoise : IRosRoise
    {
        public void GetDetails()
        {
            Console.WriteLine("Sport RosRoise car details....");
        }
    }
}
