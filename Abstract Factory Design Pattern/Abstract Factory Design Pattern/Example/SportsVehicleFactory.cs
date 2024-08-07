using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Design_Pattern.Example
{
    public class SportsVehicleFactory : IVehicleFactory
    {
        public IBike CreateBike()
        {
            return new SportBike();
        }
        public ICar CreateCar()
        {
            return new SportCar();
        }
    }
}
