using System;
using System.Collections.Generic;
namespace MediatorDesignPattern.JobPortalProject
{
    public class JobPortal : IJobPortal
    {
        private Dictionary<string, Employer> _jobs = new Dictionary<string, Employer>();
        public void PostJob(Employer employer, string jobDescription)
        {
            _jobs[jobDescription] = employer;
            Console.WriteLine($"{employer.Name} posted a job: {jobDescription}");
        }
        public void Apply(JobSeeker seeker, string jobDescription)
        {
            if (_jobs.TryGetValue(jobDescription, out Employer employer))
            {
                Console.WriteLine($"{seeker.Name} applied for {employer.Name}'s job: {jobDescription}");
                employer.ReceiveApplication(seeker, jobDescription);
            }
        }
    }
}
