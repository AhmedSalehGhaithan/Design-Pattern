using System;

namespace FirewallProxyDesignPattern.SubjectProject
{
    public class RealSubject : ISubject
    {
        public void Request()
        {
            Console.WriteLine("RealSubject: Handling Request.");
        }
    }
}
