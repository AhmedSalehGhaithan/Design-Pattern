namespace ProxyDesignPattern.GeneralExample
{
    public class Employee
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public Employee(string userName,string password,string role)
        {
            UserName = userName;
            Password = password;
            Role = role;
        }
    }
}
