using FirewallProxyDesignPattern.DocumentProject;
using FirewallProxyDesignPattern.MediaServiceProject;
using FirewallProxyDesignPattern.SubjectProject;
using System;

namespace FirewallProxyDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DocumentProject();
            Console.ReadKey();
        }

        static void SubjectProject()
        {
            ISubject proxy = new FirewallProxy();
            proxy.Request();
        }
        static void MediaServiceProject()
        {
            IMediaService user1 = new MediaServiceProxy("Free","US");
            user1.Play("content1");
            user1.Play("content2");

            IMediaService user2 = new MediaServiceProxy("Premium", "UK");
            user2.Play("content3");
        }
        static void DocumentProject()
        {
            IDocument publicDocument = new DocumentProxy("This is a public document.", "Public", "Employee");
            Console.WriteLine(publicDocument.ReadContent()); // This will print the content
            
            IDocument confidentialDocument = new DocumentProxy("This is a confidential document.", "Confidential", "Employee");
            Console.WriteLine(confidentialDocument.ReadContent()); // This will print "Access Denied!"
            
            IDocument topSecretDocument = new DocumentProxy("This is a top-secret document.", "Top-Secret", "Executive");
            Console.WriteLine(topSecretDocument.ReadContent()); // This will print the content

        }
    }
}
