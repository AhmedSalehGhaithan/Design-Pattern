using System;
using System.Collections.Generic;

namespace FirewallProxyDesignPattern.SubjectProject
{
    public class FirewallProxy : ISubject
    {
        private RealSubject _realSubject;
        private List<string> _bannedSites;

        public FirewallProxy()
        {
            _bannedSites = new List<string> { "badsite.com", "malicious.com" };
        }

        private bool IsRequestValid()
        {
            // Just for the sake of this example, let's imagine we are checking a website domain.
            string siteBeingAccessed = "badsite.com"; // Hardcoded for the sake of example. This can be dynamic.

            return !_bannedSites.Contains(siteBeingAccessed);
        }
        public void Request()
        {
            if(IsRequestValid())
            {
                if(_realSubject == null)
                {
                    _realSubject = new RealSubject();
                }
                _realSubject.Request();
            }
            else
            {
                Console.WriteLine("FirewallProxy: Access Denied!");
            }
        }
    }
}
