namespace RemoteProxyDesignPattern.ExampleThree
{
    //Real Subject (remote system):
    //Although you typically wouldn't have direct access to the real subject in a remote proxy setup, 
    //for the sake of understanding, let's visualize the real system:
    // This represents the actual remote inventory system
    public class RemoteBookInventory : IBookInventory
    {
        public int GetAvailableCopies(string isbn)
        {
            // Logic to retrieve book information from a remote database
            // For simplicity, let's assume a hardcoded value.
            return 10;
        }
    }
}
