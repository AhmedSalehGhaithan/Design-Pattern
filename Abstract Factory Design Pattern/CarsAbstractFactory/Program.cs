using CarsAbstractFactory.Example.StaticClass;
using CarsAbstractFactory.Example.Factory;
using System;
namespace CarsAbstractFactory
{
    public class Program
    {
        static void Main(string[] args)
        {
            ICarFactory carFactoryForSpecialCars = new SpecialCarFactory();
            CarCreator.CreateBmwCar(carFactoryForSpecialCars);
            CarCreator.CreateToyotaCar(carFactoryForSpecialCars);
            //------------------------------------------------
            ICarFactory carFactoryForSportCars = new SportCarFactory();
            CarCreator.CreateBugatiCar(carFactoryForSpecialCars);

            Console.ReadKey();
        }
    }
}
