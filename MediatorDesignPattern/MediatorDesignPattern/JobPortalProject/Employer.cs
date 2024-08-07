using System;
namespace MediatorDesignPattern.JobPortalProject
{
    // Colleague
    public class Employer
    {
        public string Name { get; private set; }
        private IJobPortal _portal;
        public Employer(string name, IJobPortal portal)
        {
            Name = name;
            _portal = portal;
        }
        public void PostJob(string description)
        {
            _portal.PostJob(this, description);
        }
        public void ReceiveApplication(JobSeeker seeker, string jobDescription)
        {
            Console.WriteLine($"Received an application from {seeker.Name} for job: {jobDescription}");
        }
    }
}
