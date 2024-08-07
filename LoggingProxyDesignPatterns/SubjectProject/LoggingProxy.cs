using System;
namespace LoggingProxyDesignPattern.SubjectProject
{
    public class LoggingProxy : ISubject
    {
        private readonly Subject _realSubject;
        private readonly ILogger _logger;
        public void PerformOperation()
        {
            throw new System.NotImplementedException();
        }
    }
}
