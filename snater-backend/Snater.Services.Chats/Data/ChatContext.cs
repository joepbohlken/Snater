using Microsoft.EntityFrameworkCore;
using Snater.Services.Chats.Models;
using Snater.Services.Chats.Models.DTO;

namespace Snater.Services.Chats.Data
{
    public class ChatContext : DbContext
    {
        public DbSet<Chat> Chats { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<ChatUser> ChatUsers { get; set; }

        public ChatContext(DbContextOptions<ChatContext> options) : base(options)
        {

        }
        public ChatContext()
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message>()
                .HasOne(c => c.Chat)
                .WithMany(m => m.Messages)
                .HasForeignKey(c => c.ChatId);

            modelBuilder.Entity<ChatUser>()
                .HasOne(c => c.Chat)
                .WithMany(u => u.ChatUsers)
                .HasForeignKey(c => c.ChatId);
        }
    }
}
