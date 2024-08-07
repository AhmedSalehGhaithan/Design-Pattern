using System;
namespace CarsAbstractFactory.Example.CarTypes.BMW
{
    internal class SportBMW : IBMW
    {
        public void GetDetails()
        {
            Console.WriteLine("Sport Bmw car details....");
        }
    }
}
