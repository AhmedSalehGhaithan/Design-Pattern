using System;

namespace MediatorDesignPattern.TaxiDispatchSystem
{
    public class Passenger
    {
        public string Name { get; }
        private IDispatchSystem _mediator;
        public Passenger(string name, IDispatchSystem mediator)
        {
            Name = name;
            _mediator = mediator;
        }
        public void RequestRide(string destination)
        {
            _mediator.RequestRide(this, destination);
        }
        public void NotifyRideAccepted(Driver driver)
        {
            Console.WriteLine($"{Name}'s ride request has been accepted by {driver.Name}.");
        }
    }
}
