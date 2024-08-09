using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightDesignPattern.VehicleLicensePlateManagementSystem
{
    // Flyweight: LicensePlatePrefix holds the shared properties
    public class LicensePlatePrefix
    {
        public string StateOrRegion { get; }
        public LicensePlatePrefix(string stateOrRegion)
        {
            StateOrRegion = stateOrRegion;
        }
        public void DisplayPrefix()
        {
            Console.WriteLine($"Prefix: {StateOrRegion}");
        }
    }
}
