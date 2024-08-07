using CarsAbstractFactory.Example.CarTypes.BMW;
using CarsAbstractFactory.Example.CarTypes.Bugati;
using CarsAbstractFactory.Example.CarTypes.Hunda;
using CarsAbstractFactory.Example.CarTypes.Mercides;
using CarsAbstractFactory.Example.CarTypes.RosRoise;
using CarsAbstractFactory.Example.CarTypes.TOYOTA;

namespace CarsAbstractFactory.Example.Factory
{
    internal class SportCarFactory : ICarFactory
    {
        public IBMW CreateBmwCar() => new SportBMW();
        public IBugati CreateBugatiCar() => new SportBugati();
        public IHunda CreateHundaCar() => new SportHunda();
        public IMercides CreateMwecidesCar() => new SportMwecides();
        public IRosRoise CreateRosRoiseCar() => new SportRosRoise();
        public IToyota CreateToyotaCar()=> new SportToyota();
    }
}
