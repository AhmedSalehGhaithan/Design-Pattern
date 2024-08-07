using ProxyDesignPattern.GeneralExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Client passing employee with Role Developer to FolderProxy");
            Employee employee1 = new Employee("Ahmed","Ah123SD","Developer");

            SharedFolderProxy folderProxy = new SharedFolderProxy(employee1);
            folderProxy.PerformRWOperations();

            Console.WriteLine();

            Console.WriteLine("Client passing employee with Role Manager to FolderProxy");
            Employee employee2 = new Employee("Mohamed", "ref21@cds", "Manager");

            SharedFolderProxy folderProxy2 = new SharedFolderProxy(employee2);
            folderProxy2.PerformRWOperations();

            Console.ReadKey();  

        }
    }
}
