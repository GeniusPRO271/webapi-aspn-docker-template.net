using BackEndProject.Data.Models;
using Microsoft.AspNetCore.Identity;

namespace BackEndProject.Data.Models
{
    public class Role : IdentityRole<Guid>, IBaseEntity
    {
        public DateTime CreateDateTime { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
