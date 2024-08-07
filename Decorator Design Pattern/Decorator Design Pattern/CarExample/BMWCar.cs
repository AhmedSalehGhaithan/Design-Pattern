namespace Decorator_Design_Pattern.CarExample
{
    public class BMWCar : ICar
    {
        private string CarName = "BMW";
        public string CarBody { get; set; }
        public string CarDoor { get; set; }
        public string CarWheels { get; set; }
        public string CarGlass { get; set; }
        public string Engine {  get; set; }
        public ICar ManufactureCar()
        {
            CarBody = "carbon fiber material";
            CarDoor = "4 car doors";
            CarGlass = "6 car glasses";
            CarWheels = "4 car wheels";
            return this;
        }

        public override string ToString()
        {
            return "BMWCar [CarName=" + CarName + ", CarBody=" + CarBody + ", CarDoor=" + CarDoor + ", CarWheels="
                            + CarWheels + ", CarGlass=" + CarGlass + ", Engine = " + Engine + "]";
        }
    }
}
