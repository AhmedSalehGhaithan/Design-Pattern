using System;

namespace MediatorDesignPattern.TaxiDispatchSystem
{
    // Colleagues
    public class Driver
    {
        public string Name { get; }
        private IDispatchSystem _mediator;
        public Driver(string name)
        {
            Name = name;
        }
        public void SetMediator(IDispatchSystem mediator)
        {
            _mediator = mediator;
        }
        public void NotifyRideRequest(Passenger passenger, string destination)
        {
            Console.WriteLine($"{Name} received ride request from {passenger.Name} to {destination}.");
            // When the driver accepts the ride
            _mediator.RideAccepted(this, passenger);
        }
    }
}
