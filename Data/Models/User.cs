using Microsoft.AspNetCore.Identity;

namespace BackEndProject.Data.Models;

public class User : IdentityUser<Guid>, IBaseEntity
{
    public string Name { get; set; }
    public DateTime BirthDate { get; set; }
    public DateTime CreateDateTime { get; set; }
    public DateTime ModifyDateTime { get; set; }
    public DateTime? DeleteDate { get; set; }
}