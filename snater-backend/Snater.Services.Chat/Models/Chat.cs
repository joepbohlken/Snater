using System.ComponentModel.DataAnnotations;

namespace Snater.Services.Chat.Models
{
    public class Chat
    {
        // test 8
        [Key]
        public Guid Id { get; set; }
        //public User User { get; set; }
        public string? LastMessage { get; set; }
        public DateTime LastMessageTime { get; set; }
    }
}
