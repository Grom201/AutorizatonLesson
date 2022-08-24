using Microsoft.EntityFrameworkCore;

namespace AutorizatonLesson.Models
{
    public class UserContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public UserContext(DbContextOptions<UserContext> options)
            : base(options)
        {
           // Database.EnsureDeleted();
            Database.EnsureCreated();
        }
    }
}
