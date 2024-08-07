using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern.ExampleNumberOne
{
    // The Adaptee contains some functionality that is required by the client.
    // But this interface is not compatible with the client code.
    public class ThirdPartyBillingSystem
    {
        //ThirdPartyBillingSystem accepts employee's information as a List to process each employee's salary
        public void ProcessSalary(List<Employee> listEmployee)
        {
            foreach (Employee employee in listEmployee)
            {
                Console.WriteLine("Rs." + employee.Salary + " Salary Credited to " + employee.Name + " Account");
            }
        }
    }
}
