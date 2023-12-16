using BackEndProject.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BackEndProject.Data
{
    public class APIDBContext : IdentityDbContext<User, Role, Guid>
    {
        public APIDBContext(DbContextOptions<APIDBContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);
            }

        // Note: The following properties are not needed as they are already defined in the base class.
        public override DbSet<User> Users { get; set; }
        public override DbSet<Role> Roles { get; set; }
        public DbSet<Dish> Dish { get; set; }

        public DbSet<Rating> Ratings { get; set; }
    }
}
