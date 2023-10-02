using BloggingPlatformApplication.Models;
using System;
using System.Diagnostics;
using System.Linq;

namespace BloggingPlatformApplication.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any Users.
            if (context.User.Any())
            {
                return;   // DB has been seeded
            }

            var users = new User[]
            {
            new User{Username="Yumacorn",Email="ReachRyanMui@gmail.com",BlogPosts={ } },
            new User{Username="Rojelio",Email="Titan@gmail.com",BlogPosts={ } },
            new User{Username="Georgia",Email="MirrorverseG@gmail.com",BlogPosts={ } }
            };
            foreach (User u in users)
            {
                context.User.Add(u);
            }
            context.SaveChanges();

        }
    }
}
