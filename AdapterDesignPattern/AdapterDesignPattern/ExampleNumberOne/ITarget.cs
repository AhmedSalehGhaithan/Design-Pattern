using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern.ExampleNumberOne
{
    // The ITarget defines the domain-specific interface used by the client code.
    // This interface needs to be implemented by the Adapter.
    // The client can only see this interface i.e. the class which implements the ITarget interface.
    public interface ITarget
    {
        
        void ProcessCompanySalary(string[,] employeesArray);
    }
}
