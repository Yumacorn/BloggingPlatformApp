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
    }
}