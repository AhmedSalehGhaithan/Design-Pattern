using System.Collections.Generic;
using System.Linq;

namespace MediatorDesignPattern.TaxiDispatchSystem
{
    public class TaxiDispatch : IDispatchSystem
    {
        private List<Driver> _availableDrivers = new List<Driver>();
        private Dictionary<Passenger, string> _waitingPassengers = new Dictionary<Passenger, string>();
        public void RegisterDriver(Driver driver)
        {
            if (!_availableDrivers.Contains(driver))
            {
                _availableDrivers.Add(driver);
                driver.SetMediator(this);
            }
        }
        public void RequestRide(Passenger passenger, string destination)
        {
            if (_availableDrivers.Any())
            {
                var driver = _availableDrivers.First();
                _waitingPassengers[passenger] = destination;
                driver.NotifyRideRequest(passenger, destination);
            }
        }
        public void RideAccepted(Driver driver, Passenger passenger)
        {
            if (_waitingPassengers.ContainsKey(passenger))
            {
                _availableDrivers.Remove(driver);
                _waitingPassengers.Remove(passenger);
                passenger.NotifyRideAccepted(driver);
            }
        }
    }
}
