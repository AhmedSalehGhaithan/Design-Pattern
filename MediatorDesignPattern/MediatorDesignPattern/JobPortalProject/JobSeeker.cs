namespace MediatorDesignPattern.JobPortalProject
{
    public class JobSeeker
    {
        public string Name { get; private set; }
        private IJobPortal _portal;
        public JobSeeker(string name, IJobPortal portal)
        {
            Name = name;
            _portal = portal;
        }
        public void Apply(string jobDescription)
        {
            _portal.Apply(this, jobDescription);
        }
    }
}
