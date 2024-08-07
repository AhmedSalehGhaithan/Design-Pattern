using System;

namespace CarsAbstractFactory.Example.CarTypes.Hunda
{
    public class SportHunda : IHunda
    {
        public void GetDetails()
        {
            Console.WriteLine("Sport Hunda car details....");
        }
    }
}
