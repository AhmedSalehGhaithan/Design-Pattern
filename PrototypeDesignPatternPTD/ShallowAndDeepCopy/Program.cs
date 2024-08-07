using ShallowAndDeepCopy.DeepAndShallowClone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShallowAndDeepCopy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee
            {
                Name = "Anurag",
                Department = "IT",
                EmpAddress = new Address() { address = "BBSR" }
            };

            Employee emp2 = emp1.GetDeepCopy();
            emp2.Name = "Pranaya";
            emp2.EmpAddress.address = "Mumbai";
            Console.WriteLine("Using Deep Copy");
            Console.WriteLine($" Emplpyee 1: Name: {emp1.Name}, Address: {emp1.EmpAddress.address}");
            Console.WriteLine($" Emplpyee 2: Name: {emp2.Name}, Address: {emp2.EmpAddress.address}");

            Employee emp3 = new Employee
            {
                Name = "Sambit",
                Department = "HR",
                EmpAddress = new Address() { address = "Delhi" }
            };

            Employee emp4 = emp3.GetShallowCopy();

            emp4.Name = "Hina";
            emp4.EmpAddress.address = "Hyderabad";
            Console.WriteLine("\nUsing Shallow Copy");
            Console.WriteLine($" Emplpyee 3: Name: {emp3.Name}, Address: {emp3.EmpAddress.address}");
            Console.WriteLine($" Emplpyee 4: Name: {emp4.Name}, Address: {emp4.EmpAddress.address}");

            Console.Read();
        }
    }
}
