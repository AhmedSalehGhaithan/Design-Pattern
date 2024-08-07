using CarExamplePrototype.CarExample;
using Event_Management_Company.ConferenceScheduleExample;
using PrototypeDesignPatternPTD.ExampleNumberOne;

using System;
namespace PrototypeDesignPatternPTD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // call any example here
            Console.ReadKey();
        }
        
        static void EventManagementCompany()
        {
            // Standard conference schedule template
            ConferenceSchedule standardSchedule = new ConferenceSchedule
            {
                Sessions = { "Welcome Note", "Tech Trends", "Networking Session" },
                Speakers = { "Host", "Tech Guru", "All Participants" }
            };
            Console.WriteLine("Standard Schedule:");
            standardSchedule.DisplaySchedule();
            // A client wants a similar schedule but with an added "Innovation Talk".
            ConferenceSchedule customSchedule = (ConferenceSchedule)standardSchedule.Clone();
            customSchedule.Sessions.Insert(2, "Innovation Talk");
            customSchedule.Speakers.Insert(2, "Innovation Expert");
            Console.WriteLine("Custom Schedule for Client A:");
            customSchedule.DisplaySchedule();
        }
        static void CarExample()
        {
            // Create an initial car configuration
            Car prototypeCar = new Car
            {
                Model = "Sedan",
                Color = "Blue",
                Engine = "V6",
                Sunroof = true
            };
            Console.WriteLine("Original Car Configuration:");
            Console.WriteLine(prototypeCar);
            // Now clone the prototype and make modifications for a new configuration
            Car clonedCar = (Car)prototypeCar.Clone();
            clonedCar.Color = "Red";
            clonedCar.Sunroof = false;
            Console.WriteLine("\nCloned and Modified Car Configuration:");
            Console.WriteLine(clonedCar);
        }
       
        static void ExampleNumberOne()
        {
            // Creating an Instance of Permanent Employee Class
            Employee emp1 = new PermanentEmployee()
            {
                Name = "Anurag",
                Department = "IT",
                Type = "Permanent",
                Salary = 100000
            };
            //Creating a Clone of the above Permanent Employee
            Employee emp2 = emp1.GetClone();
            // Changing the Name and Department Property Value of emp2 instance, 
            // will not change the Name and Department Property Value of the emp1 instance
            emp2.Name = "Pranaya";
            emp2.Department = "HR";
            emp1.ShowDetails();
            emp2.ShowDetails();
            // Creating an Instance of Temporary Employee Class
            Employee emp3 = new TemporaryEmployee()
            {
                Name = "Preety",
                Department = "HR",
                Type = "Temporary",
                FixedAmount = 200000
            };
            //Creating a Clone of the above Temporary Employee
            Employee emp4 = emp3.GetClone();
            // Changing the Name and Department Property Value of emp4 instance, 
            // will not change the Name and Department Property Value of the emp3 instance
            emp4.Name = "Priyanka";
            emp4.Department = "Sales";
            emp3.ShowDetails();
            emp4.ShowDetails();

            
        }
    }

}
