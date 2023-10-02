using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BloggingPlatformApplication.Models;

namespace BloggingPlatformApplication.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<BloggingPlatformApplication.Models.User> User { get; set; } = default!;
        public DbSet<BloggingPlatformApplication.Models.BlogPost> BlogPost { get; set; } = default!;

        internal User Users(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<BlogPost>().ToTable("BlogPost");
        }
    }
}