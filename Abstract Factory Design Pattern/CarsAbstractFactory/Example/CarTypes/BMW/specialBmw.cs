using System;

namespace CarsAbstractFactory.Example.CarTypes.BMW
{
    internal class specialBmw : IBMW
    {
        public void GetDetails()
        {
            Console.WriteLine("Special Bmw car details....");
        }
    }
}
