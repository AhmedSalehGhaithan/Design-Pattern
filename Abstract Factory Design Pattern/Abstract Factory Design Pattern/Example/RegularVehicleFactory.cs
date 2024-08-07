using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Design_Pattern.Example
{
    internal class RegularVehicleFactory : IVehicleFactory
    {
        public IBike CreateBike()
        {
            return new RegularBike();
        }
        public ICar CreateCar()
        {
            return new RegularCar();
        }
    }
}
