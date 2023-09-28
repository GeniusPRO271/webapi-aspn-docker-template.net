using BackEndProject.Types;
using Microsoft.EntityFrameworkCore;

namespace BackEndProject.Data;

public class APIDBcontext : DbContext
{
    public APIDBcontext(DbContextOptions<APIDBcontext> options) : base(options)
    {
        
    }
    public DbSet<User> Users { get; set; }
}