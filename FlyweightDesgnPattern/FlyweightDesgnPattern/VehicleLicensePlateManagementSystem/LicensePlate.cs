using System;

namespace FlyweightDesignPattern.VehicleLicensePlateManagementSystem
{
    // The ConcreteFlyweight class with external states.
    public class LicensePlate
    {
        private readonly LicensePlatePrefix _prefix;
        public int UniqueNumber { get; }
        public LicensePlate(int uniqueNumber, LicensePlatePrefix prefix)
        {
            UniqueNumber = uniqueNumber;
            _prefix = prefix;
        }
        public void DisplayPlate()
        {
            _prefix.DisplayPrefix();
            Console.WriteLine($"Unique Number: {UniqueNumber}");
        }
    }
}
