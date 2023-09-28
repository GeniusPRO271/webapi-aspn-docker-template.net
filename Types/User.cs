namespace BackEndProject.Types;

public class User
{
    public string Id { get; set; }
    
    public string Name { get; set;}
    
    public string Password { get; set; }
    public string PhoneNumber { get; set; }
    
    public string[] Addresses { get; set; }
    
    public string Address { get; set; }
    
    public string Email { get; set; }

    public User(string name, string password,string phoneNumber, string address, string email)
    {
        this.Id = Guid.NewGuid().ToString();
        this.Name = name;
        this.Password = password;
        this.PhoneNumber = phoneNumber;
        this.Addresses = new []{address};
        this.Address = address;
        this.Email = email;
    }
    
}