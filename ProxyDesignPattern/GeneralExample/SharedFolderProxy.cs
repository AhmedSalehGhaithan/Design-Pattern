using System;

namespace ProxyDesignPattern.GeneralExample
{
    public class SharedFolderProxy : ISharedFolder
    {
        private ISharedFolder _sharedFolder;
        private Employee _employee;

        public SharedFolderProxy(Employee employee)
        {
            _employee = employee;
        }
        public void PerformRWOperations()
        {
            if(_employee.Role.ToUpper() == "CEO" || _employee.Role.ToUpper() == "MANAGER")
            {
                _sharedFolder = new SharedFolder();
                Console.WriteLine("Shared Folder Proxy makes call to the RealFolder 'PerformRWOperations' method");
                _sharedFolder.PerformRWOperations();
            }
            else
            {
                Console.WriteLine("Shared Folder proxy says 'You don't have permission to access this folder'");
            }
        }
    }
}