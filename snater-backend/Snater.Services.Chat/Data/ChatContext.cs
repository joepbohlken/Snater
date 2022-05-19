using Microsoft.EntityFrameworkCore;
using Snater.Services.Chats.Models;

namespace Snater.Services.Chats.Data
{
    public class ChatContext : DbContext
    {
        public ChatContext(DbContextOptions<ChatContext> options) : base(options)
        {

        }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message>()
                .HasOne(c => c.Chat)
                .WithMany(m => m.Messages)
                .HasForeignKey(c => c.ChatId);
        }
    }
}
