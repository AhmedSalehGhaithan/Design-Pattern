using System;
namespace RemoteProxyDesignPattern.ExampleThree
{
    //Subject Interface:
    //This is the common interface that both the real subject and the proxy will implement.
    public interface IBookInventory
    {
        int GetAvailableCopies(string isbn);
    }
}
