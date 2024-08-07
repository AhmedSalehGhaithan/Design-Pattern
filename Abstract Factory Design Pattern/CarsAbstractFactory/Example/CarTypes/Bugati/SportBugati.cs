using System;

namespace CarsAbstractFactory.Example.CarTypes.Bugati
{
    public class SportBugati : IBugati
    {
        public void GetDetails()
        {
            Console.WriteLine("Sport Bugati car details....");
        }
    }
}
