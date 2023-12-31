﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BloggingPlatformApplication.Models;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Reflection.Emit;

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
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>()
                .HasData(
                new User
                {
                    Id = 1,
                    Username = "Yumacorn",
                    Email = "ReachRyanMui@gmail.com",
                    BlogPosts = { }
                },
                new User
                {
                    Id = 2,
                    Username = "HoldenPirate",
                    Email = "james_holden@theexpanse.com",
                    BlogPosts = { }
                },
                new User
                {
                    Id = 3,
                    Username = "Zorro",
                    Email = "FirstMate@thousandsunny.com",
                    BlogPosts = { }
                }
                );
            modelBuilder.Entity<BlogPost>()
                .HasData(
                 new BlogPost
                 {
                     Id = 1,
                     Title = "The World's Greatest Showman",
                     Content = "Starring Hugh Jackman and Zac Efron",
                     Created = System.DateTime.Now,
                     LastUpdated = System.DateTime.Now,
                     UserId = 1
                 },
                 new BlogPost
                 {
                     Id = 2,
                     Title = "From Now On",
                     Content = "A biographical of the nonsensical and whimsical",
                     Created = System.DateTime.Now,
                     LastUpdated = System.DateTime.Now,
                     UserId = 1
                 },
                 new BlogPost
                 {
                     Id = 3,
                     Title = "Terraforming Mars",
                     Content = "Home is where the Red Planet is",
                     Created = System.DateTime.Now,
                     LastUpdated = System.DateTime.Now,
                     UserId = 2
                 },
                 new BlogPost
                 {
                     Id = 4,
                     Title = "Don't trust the Detective",
                     Content = "A series of unfortunate events in space",
                     Created = System.DateTime.Now,
                     LastUpdated = System.DateTime.Now,
                     UserId = 2
                 },
                 new BlogPost
                 {
                     Id = 5,
                     Title = "How to hone your Swordsman Skills",
                     Content = "A quick guide to 1,000,000 berry bounties",
                     Created = System.DateTime.Now,
                     LastUpdated = System.DateTime.Now,
                     UserId = 3
                 }
                );
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //@TODO: Implement OnModelCreating Related Seed Data

        //modelBuilder.Entity<User>()
        //    .HasNoKey()
        //    .HasData(
        //    new User
        //    {
        //        Id = 1,
        //        Username = "Yumacorn",
        //        Email = "ReachRyanMui@gmail.com",
        //        BlogPosts = { }
        //    }
        //);
        //modelBuilder.Entity<User>()
        //    .HasKey("Id");

        //modelBuilder.Entity<BlogPost>().HasData(
        //  new BlogPost
        //  {
        //      Id = 1,
        //      UserId = 1,
        //      Title = "Unstoppable Corn",
        //      Content = "Stay tuned for next week"
        //  });
        //modelBuilder.Entity<BlogPost>()
        //    .HasKey("Id");

        //@TODO: Identify issue - InvalidOperationException: The entity type 'IdentityUserLogin<string>' requires a primary key to be defined.
        //modelBuilder.Entity(
        //"BloggingPlatformApplication.User", u =>
        //{
        //    u.Property<int>("Id")
        //        .ValueGeneratedOnAdd()
        //        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

        //    u.Property<string>("Username")
        //        .IsRequired();

        //    u.Property<string>("Email")
        //        .IsRequired();

        //    u.HasKey("Id");

        //    u.ToTable("Users");

        //    u.HasData(
        //        new { Id = 1,
        //            Username = "Yumacorn",
        //            Email = "ReachRyanMui@gmail.com"
        //        }
        //    );
        //});


        //}
    }
}