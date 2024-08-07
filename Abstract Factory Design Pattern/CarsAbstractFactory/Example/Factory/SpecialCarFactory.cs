using CarsAbstractFactory.Example.CarTypes.BMW;
using CarsAbstractFactory.Example.CarTypes.Bugati;
using CarsAbstractFactory.Example.CarTypes.Hunda;
using CarsAbstractFactory.Example.CarTypes.Mercides;
using CarsAbstractFactory.Example.CarTypes.RosRoise;
using CarsAbstractFactory.Example.CarTypes.TOYOTA;

namespace CarsAbstractFactory.Example.Factory
{
    public class SpecialCarFactory : ICarFactory
    {
        public IBMW CreateBmwCar() => new specialBmw();
        public IBugati CreateBugatiCar() => new SpecialBugati();
        public IHunda CreateHundaCar()=> new SpecialHunda();
        public IMercides CreateMwecidesCar() => new SpecialMwecides();
        public IRosRoise CreateRosRoiseCar() => new SpecialRosRoise();
        public IToyota CreateToyotaCar() => new SpecialToyota();
    }
}
