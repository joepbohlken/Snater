using Microsoft.EntityFrameworkCore;
using Snater.Services.Profile.Models;

namespace Snater.Services.Profile.Data
{
    public class ProfileContext : DbContext
    {
        public ProfileContext(DbContextOptions<ProfileContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed Users
            Guid userId0 = Guid.NewGuid();
            User user0 = new User()
            {
                Id = userId0,
                Username = "Henk",
                Status = Enums.UserStatus.DontDisturb
            };
            
            modelBuilder.Entity<User>().HasData(
                user0);

            Guid userId1 = Guid.NewGuid();
            modelBuilder.Entity<User>().HasData(
                new User { Id = userId1, Username = "Pieter", Status = Enums.UserStatus.DontDisturb });

            Guid userId2 = Guid.NewGuid();
            modelBuilder.Entity<User>().HasData(
                new User { Id = userId2, Username = "Klaas", Status = Enums.UserStatus.DontDisturb });

            Guid userId3 = Guid.NewGuid();
            modelBuilder.Entity<User>().HasData(
                new User { Id = userId3, Username = "Vaas", Status = Enums.UserStatus.DontDisturb });

            Guid userId4 = Guid.NewGuid();
            modelBuilder.Entity<User>().HasData(
                new User { Id = userId4, Username = "Peter", Status = Enums.UserStatus.DontDisturb });

            Guid userId5 = Guid.NewGuid();
            modelBuilder.Entity<User>().HasData(
                new User { Id = userId5, Username = "Pannenkoek", Status = Enums.UserStatus.DontDisturb });

            Guid userId6 = Guid.NewGuid();
            modelBuilder.Entity<User>().HasData(
                new User { Id = userId6, Username = "Daniel", Status = Enums.UserStatus.DontDisturb });

            // Seed Chats
            Guid chatId0 = Guid.NewGuid();
            modelBuilder.Entity<User>().HasData(
                new Chat { Id = chatId0, User = , LastMessage });
        }
        public DbSet<Chat> Chats { get; set; }
    }

}
