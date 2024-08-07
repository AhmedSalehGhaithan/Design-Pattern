using System;

namespace CarsAbstractFactory.Example.CarTypes.Bugati
{
    public class SpecialBugati : IBugati
    {
        public void GetDetails()
        {
            Console.WriteLine("Special Bugati car details....");
        }
    }
}
