using System;

namespace Decorator_Design_Pattern.CarExample
{
    public class DieselCarDecorator : CarDecorator
    {
        public DieselCarDecorator(ICar car) : base(car)
        {
        }
        public override ICar ManufactureCar()
        {
           _car.ManufactureCar();
            AddEngine(_car);
            return _car;
        }
        public void AddEngine(ICar car)
        {
            if(car is BMWCar bMWCar)
            {
                bMWCar.Engine = "Diesel Engine";
                Console.WriteLine($"DieselCarDecorator added Petrol Engine to the Car : {car}");
            }

        }
    }
}
