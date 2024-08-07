using System;

namespace MediatorDesignPattern.ControlTowerProject
{
    public class Airplane
    {
        private readonly IControlTower _controlTower;
        public string _FlightNumber { get; }

        public Airplane(string flightNumber, IControlTower controlTower)
        {
            _controlTower = controlTower;
            _FlightNumber = flightNumber;
        }

        public void RequestLanding()
        {
            if (_controlTower.RequestLandingPermission(this))
                Console.WriteLine($"Airplane {_FlightNumber} is landing.");
            else
                Console.WriteLine($"Airplane {_FlightNumber} is waiting for an available runway.");
        }
        public void AssignRunway(Runway runway)
        {
            Console.WriteLine($"Airplane {_FlightNumber} assigned to runway {runway.Id}.");
        }
    }
}