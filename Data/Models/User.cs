using Microsoft.AspNetCore.Identity;

namespace BackEndProject.Data.Models;

public class User : IdentityUser<Guid>, IBaseEntity

{
    public string FullName { get; set; }

    public string Gender { get; set; }

    public string Phone { get; set; }

    public string Email { get; set; }

    public string Address { get; set; }

    public ICollection<Rating> Ratings {get;set;}
    public DateTime BirthDate { get; set; }
    public DateTime CreateDateTime { get; set; }
    public DateTime ModifyDateTime { get; set; }
    public DateTime? DeleteDate { get; set; }
}