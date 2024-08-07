using System;

namespace FirewallProxyDesignPattern.MediaServiceProject
{
    public class MediaService : IMediaService
    {
        public void Play(string contentId)
        {
            // Logic to stream the actual content
            Console.WriteLine($"Streaming content with ID: {contentId}");
        }
    }
}
