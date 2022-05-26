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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chat>()
                .HasMany(m => m.Messages)
                .WithOne(c => c.Chat);

            modelBuilder.Entity<ChatUser>()
                .HasOne(c => c.Chat)
                .WithMany(u => u.ChatUsers)
                .HasForeignKey(c => c.ChatId);
        }
    }
}
