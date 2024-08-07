using System;
using System.Collections.Generic;

namespace CacheProxyDesignPattern.ExampleTwo
{
    public class CachedProfilePictureService : IProfilePictureService
    {
        private readonly IProfilePictureService _service;
        private readonly Dictionary<int, byte[]> _cache = new Dictionary<int, byte[]>();

        public CachedProfilePictureService(IProfilePictureService service)
        {
            _service = service;
        }
        public byte[] GetProfilePicture(int userId)
        {
            if(_cache.ContainsKey(userId))
            {
                Console.WriteLine($"Returning cached profile picture for user {userId}");
                return _cache[userId];
            }

            var picture = _service.GetProfilePicture(userId);
            _cache[userId] = picture;
            return picture;
        }
    }
}
