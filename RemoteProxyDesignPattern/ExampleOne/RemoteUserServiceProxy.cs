namespace RemoteProxyDesignPattern.ExampleOne
{
    public class RemoteUserServiceProxy : IUserService
    {
        public string GetUserName(int userId)
        {
            // Simulate a remote call to the real service
            return RemoteMethodCall(userId);
        }

        private string RemoteMethodCall(int userId)
        {
            // In a real-world scenario, this would involve networking code
            // that communicates with the remote service.
            // For simplicity, we'll simulate a remote call here.
            RealUserService remoteService = new RealUserService();
            return remoteService.GetUserName(userId);
        }
    }
}
