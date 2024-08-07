using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern.ExampleNumberOne
{
    // This is the class that makes two incompatible interfaces or systems work together.
    // The Adapter makes the Adaptee's interface compatible with the Target's interface.
    public class EmployeeAdapter : ThirdPartyBillingSystem, ITarget
    {
        //The following will accept the employees in the form of string array
        //Then convert the employee string array to List of Employees
        //After conversation, it will call the Adaptee's Method to Process the Salaries
        public void ProcessCompanySalary(string[,] employeesArray)
        {
            string Id = null;
            string Name = null;
            string Designation = null;
            string Salary = null;
            List<Employee> listEmployee = new List<Employee>();
            for (int i = 0; i < employeesArray.GetLength(0); i++)
            {
                for (int j = 0; j < employeesArray.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        Id = employeesArray[i, j];
                    }
                    else if (j == 1)
                    {
                        Name = employeesArray[i, j];
                    }
                    else if (j == 2)
                    {
                        Designation = employeesArray[i, j];
                    }
                    else
                    {
                        Salary = employeesArray[i, j];
                    }
                }
                listEmployee.Add(new Employee(Convert.ToInt32(Id), Name, Designation, Convert.ToDecimal(Salary)));
            }
            Console.WriteLine("Adapter converted Array of Employee to List of Employee");
            Console.WriteLine("Then delegate to the ThirdPartyBillingSystem for processing the employee salary\n");
            ProcessSalary(listEmployee);
        }
    }
}
