using System;

namespace CarsAbstractFactory.Example.CarTypes.TOYOTA
{
    public class SportToyota : IToyota
    {
        public void GetDetails()
        {
            Console.WriteLine("Sport TOYOTA car details....");
        }
    }
}
