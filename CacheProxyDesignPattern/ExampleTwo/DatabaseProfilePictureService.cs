using System;

namespace CacheProxyDesignPattern.ExampleTwo
{
    public class DatabaseProfilePictureService : IProfilePictureService
    {
        public byte[] GetProfilePicture(int userId)
        {
            Console.WriteLine($"Fetching profile picture for user {userId} from database...");
            // Simulating database fetch with a byte array.
            // Simplified representation of a user's image.
            byte[] barray = new byte[1000];
            return barray;
        }
    }
}
