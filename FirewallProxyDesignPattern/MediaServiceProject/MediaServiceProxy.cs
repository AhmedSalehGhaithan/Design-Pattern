using System;
using System.Collections.Generic;

namespace FirewallProxyDesignPattern.MediaServiceProject
{
    public class MediaServiceProxy : IMediaService
    {
        private MediaService _mediaService;
        private string _subscriptionType;
        private string _userCountry;

        private List<string> _premiumContent = new List<string> { "content2", "content3" };
        private List<string> _geoRestrictedContent = new List<string> { "content3" };
        public MediaServiceProxy(string subscriptionType, string userCountry)
        {
            _subscriptionType = subscriptionType;
            _userCountry = userCountry;
        }
        // Determines if the user is allowed to access the requested content based on subscription type and geographical restrictions.
        // - If the user has a "Free" subscription and the content is premium, access is denied.
        // - If the content is geo-restricted and the user's country is not "US", access is denied.
        // - Otherwise, access is granted.
        private bool CanAccessContent(string contentId)
        {
            if (_subscriptionType == "Free" && _premiumContent.Contains(contentId))return false;
            if(_geoRestrictedContent.Contains(contentId) && _userCountry == "UK")  return false;
            return true;
        }
        public void Play(string contentId)
        {
            if (CanAccessContent(contentId))
            {
                if (_mediaService == null)
                {
                    _mediaService = new MediaService();
                }
                _mediaService.Play(contentId);
            }
            else
            {
                Console.WriteLine("Access denied to the requested content.");
            }
        }
    }
}
