using Microsoft.EntityFrameworkCore;
using TaskTrackingSystem.Models.TaskTrackingSystem.Models;
using TaskTrackingSystem.Models;

namespace TaskTrackingSystem.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<TaskCard> TaskCards { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
