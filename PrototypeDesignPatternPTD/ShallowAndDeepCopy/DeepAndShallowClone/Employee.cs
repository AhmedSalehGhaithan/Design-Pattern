using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ShallowAndDeepCopy.DeepAndShallowClone
{
    public class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public Address EmpAddress { get; set; }

        //Shallow Copy: This is useful when you want a quick copy of the object without needing to duplicate the objects it references.
        //It is also useful when you are sure that the referenced objects will not be modified or that these changes should be reflected in all copies.
        public Employee GetShallowCopy()
        {
            Employee employee = (Employee)this.MemberwiseClone();
            return employee;
        }

        //Deep Copy: This is used when you need complete independence between the copies,
        //such as when working with complex objects where changes to the copy should not affect the original object or vice versa.
        public Employee GetDeepCopy()
        {
            Employee employee = (Employee)this.MemberwiseClone();
            employee.EmpAddress = EmpAddress.GetClone();
            return employee;
        }
    }
}
