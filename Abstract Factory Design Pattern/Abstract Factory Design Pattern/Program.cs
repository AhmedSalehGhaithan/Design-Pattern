using Abstract_Factory_Design_Pattern.Example;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            IVehicleFactory regularVehicleFactory = new RegularVehicleFactory();
            IBike regularBike = regularVehicleFactory.CreateBike();
            regularBike.GetDetails();
            
            ICar regularCar = regularVehicleFactory.CreateCar();
            regularCar.GetDetails();
           
            IVehicleFactory sportsVehicleFactory = new SportsVehicleFactory();
            IBike sportsBike = sportsVehicleFactory.CreateBike();
            sportsBike.GetDetails();
            
            ICar sportsCar = sportsVehicleFactory.CreateCar();
            sportsCar.GetDetails();

            Console.ReadKey();
        }
    }
}
