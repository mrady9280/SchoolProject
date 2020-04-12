using Microsoft.EntityFrameworkCore;
using School.Identity.API.Models;

namespace School.Identity.API.Data
{
    public class IdentityContext : DbContext
    {
        public IdentityContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Application>().HasMany(a => a.UserRoles).WithOne(u => u.Application).HasForeignKey(f => f.ApplicationId);
            modelBuilder.Entity<User>().HasMany(u => u.UserRoles).WithOne(x => x.User).HasForeignKey(f => f.UserId);
            modelBuilder.Entity<Role>().HasMany(u => u.UserRoles).WithOne(x => x.Role).HasForeignKey(f => f.RoleId);
            base.OnModelCreating(modelBuilder);
        }
    }
}