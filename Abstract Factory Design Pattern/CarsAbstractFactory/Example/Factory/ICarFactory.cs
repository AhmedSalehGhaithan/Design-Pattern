using CarsAbstractFactory.Example.CarTypes.BMW;
using CarsAbstractFactory.Example.CarTypes.Bugati;
using CarsAbstractFactory.Example.CarTypes.Hunda;
using CarsAbstractFactory.Example.CarTypes.Mercides;
using CarsAbstractFactory.Example.CarTypes.RosRoise;
using CarsAbstractFactory.Example.CarTypes.TOYOTA;

namespace CarsAbstractFactory.Example.Factory
{
    public interface ICarFactory
    {
        IBMW CreateBmwCar();
        IMercides CreateMwecidesCar();
        IHunda CreateHundaCar();
        IRosRoise CreateRosRoiseCar();
        IBugati CreateBugatiCar();
        IToyota CreateToyotaCar();
    }
}
