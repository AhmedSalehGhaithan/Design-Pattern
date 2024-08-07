namespace MediatorDesignPattern.TaxiDispatchSystem
{
    public interface IDispatchSystem
    {
        void RegisterDriver(Driver driver);
        void RequestRide(Passenger passenger, string destination);
        void RideAccepted(Driver driver, Passenger passenger);
    }
}
