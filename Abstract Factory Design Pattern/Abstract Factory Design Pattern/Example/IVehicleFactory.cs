namespace Abstract_Factory_Design_Pattern.Example
{
    internal interface IVehicleFactory
    {
        //can create regular bike and sport bike
        IBike CreateBike();
        // can create regular car and sport car
        ICar CreateCar();
    }
}
