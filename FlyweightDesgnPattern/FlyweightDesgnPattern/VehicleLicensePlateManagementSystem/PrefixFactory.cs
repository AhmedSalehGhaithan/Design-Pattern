using System.Collections.Generic;

namespace FlyweightDesignPattern.VehicleLicensePlateManagementSystem
{
    // Flyweight Factory
    public class PrefixFactory
    {
        private readonly Dictionary<string, LicensePlatePrefix> _prefixes = new Dictionary<string, LicensePlatePrefix>();
        public LicensePlatePrefix GetPrefix(string stateOrRegion)
        {
            if (!_prefixes.ContainsKey(stateOrRegion))
            {
                _prefixes[stateOrRegion] = new LicensePlatePrefix(stateOrRegion);
            }
            return _prefixes[stateOrRegion];
        }
    }
}
