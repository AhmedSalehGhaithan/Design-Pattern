namespace Decorator_Design_Pattern.CarExample
{
    public abstract class CarDecorator : ICar
    {
        protected ICar _car;
        public CarDecorator(ICar car) => _car = car;
        public virtual ICar ManufactureCar() => _car.ManufactureCar();
    }
}
