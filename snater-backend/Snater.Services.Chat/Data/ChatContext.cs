using System.Data.Entity;
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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chat>()
                .HasRequired<Message>(c => c.Messages)
                .WithMany(m => m.ChatId)
                .HasForeignKey<int>(c => c.MessageId)
        }
    }
}
