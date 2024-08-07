using System;
namespace CacheProxyDesignPattern.ExampleTwo
{
    public interface IProfilePictureService
    {
        byte[] GetProfilePicture(int userId);
    }
}
