using System;
using System.Collections.Generic;

namespace FlyweightDesignPattern.VehicleLicensePlateManagementSystem
{
    // Client
    class LicensePlateSystem
    {
        private readonly List<LicensePlate> _plates = new List<LicensePlate>();
        private readonly PrefixFactory _prefixFactory = new PrefixFactory();
        public void RegisterVehicle(string stateOrRegion, int uniqueNumber)
        {
            var prefix = _prefixFactory.GetPrefix(stateOrRegion);
            _plates.Add(new LicensePlate(uniqueNumber, prefix));
        }
        public void DisplayAllPlates()
        {
            foreach (var plate in _plates)
            {
                plate.DisplayPlate();
                Console.WriteLine("-----");
            }
        }
    }
}
