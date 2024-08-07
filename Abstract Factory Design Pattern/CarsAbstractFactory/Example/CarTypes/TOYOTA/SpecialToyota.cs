using System;

namespace CarsAbstractFactory.Example.CarTypes.TOYOTA
{
    public class SpecialToyota : IToyota
    {
        public void GetDetails()
        {
            Console.WriteLine("Special TOYOTA car details....");
        }
    }
}
