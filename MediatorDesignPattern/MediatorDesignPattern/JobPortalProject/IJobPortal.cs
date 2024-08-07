namespace MediatorDesignPattern.JobPortalProject
{
    // Mediator
    public interface IJobPortal
    {
        void PostJob(Employer employer, string jobDescription);
        void Apply(JobSeeker seeker, string jobDescription);
    }
}
