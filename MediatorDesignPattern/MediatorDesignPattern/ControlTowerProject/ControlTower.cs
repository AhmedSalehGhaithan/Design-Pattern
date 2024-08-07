using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern.ControlTowerProject
{
    public class ControlTower : IControlTower
    {
        private List<Runway> _availableRunWays = new List<Runway>();

        public void RegisterRunway(Runway runway) => _availableRunWays.Add(runway);
        // Add the runway back to the list of available runways
        public void ReleaseRunway(Runway runway) => _availableRunWays.Add(runway);

        public bool RequestLandingPermission(Airplane airplane)
        {
            // Check if there are any available runways
            if (_availableRunWays.Any()) 
            {
                // Get the first available runway
                var assignedRunway = _availableRunWays.First();
                // Remove the assigned runway from the list of available runways
                _availableRunWays.Remove(assignedRunway);
                // Assign the runway to the airplane
                airplane.AssignRunway(assignedRunway);
                // Return true indicating landing permission is granted
                return true; 
            }
            return false; // Return false if no runways are available
        }

    }
}
