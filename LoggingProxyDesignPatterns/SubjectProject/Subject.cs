using System;

namespace LoggingProxyDesignPattern.SubjectProject
{
    public class Subject : ISubject
    {
        public void PerformOperation()
        {
            Console.WriteLine("Operation performed by RealSubject");
        }
    }
}
