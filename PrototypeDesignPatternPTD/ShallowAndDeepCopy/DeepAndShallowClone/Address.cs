
public class Address
{
	public string address { get; set; }
	public Address GetClone()
	{
		return (Address)this.MemberwiseClone();
	}
}