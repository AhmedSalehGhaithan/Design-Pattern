using CarsAbstractFactory.Example.CarTypes.BMW;
using CarsAbstractFactory.Example.CarTypes.Bugati;
using CarsAbstractFactory.Example.CarTypes.Hunda;
using CarsAbstractFactory.Example.CarTypes.Mercides;
using CarsAbstractFactory.Example.CarTypes.RosRoise;
using CarsAbstractFactory.Example.CarTypes.TOYOTA;
using CarsAbstractFactory.Example.Factory;
namespace CarsAbstractFactory.Example.StaticClass
{
    public static class CarCreator
    {
        public static void CreateBmwCar(ICarFactory carFactory)
        {
            IBMW bMWCar = carFactory.CreateBmwCar();
            bMWCar.GetDetails();
        }

        public static void CreateMercidesCar(ICarFactory carFactoryForSpecialAndSportCars)
        {
            IMercides mercides = carFactoryForSpecialAndSportCars.CreateMwecidesCar();
            mercides.GetDetails();
        }

        public static void CreateHundaCar(ICarFactory carFactoryForSpecialAndSportCars)
        {
            IHunda hundaCar = carFactoryForSpecialAndSportCars.CreateHundaCar();
            hundaCar.GetDetails();
        }

        public static void CreateBugatiCar(ICarFactory carFactoryForSpecialAndSportCars)
        {
            IBugati bugatiCar = carFactoryForSpecialAndSportCars.CreateBugatiCar();
            bugatiCar.GetDetails();
        }
        public static void CreateRosRoiseCar(ICarFactory carFactoryForSpecialAndSportCars)
        {
            IRosRoise roseRoise = carFactoryForSpecialAndSportCars.CreateRosRoiseCar();
            roseRoise.GetDetails();
        }

        public static void CreateToyotaCar(ICarFactory carFactoryForSpecialAndSportCars)
        {
            IToyota ToyotaCar = carFactoryForSpecialAndSportCars.CreateToyotaCar();
            ToyotaCar.GetDetails();
        }
    }
}
