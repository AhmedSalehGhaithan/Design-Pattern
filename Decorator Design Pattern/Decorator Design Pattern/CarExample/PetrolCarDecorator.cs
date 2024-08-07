using System;

namespace Decorator_Design_Pattern.CarExample
{
    public class PetrolCarDecorator : CarDecorator
    {
        public PetrolCarDecorator(ICar _car) : base(_car)
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
                bMWCar.Engine = "Petrol Engine";
                Console.WriteLine($"PetrolCarDecorator added Petrol Engine to the Car : {car}");
            }
        }
    }
}
