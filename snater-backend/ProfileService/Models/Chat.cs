using System.ComponentModel.DataAnnotations;

namespace Snater.Services.Profile.Models
{
    public class Chat
    {
        [Key]
        public Guid Id { get; set; }
        public User User { get; set; }
        public string? LastMessage { get; set; }
        public DateTime LastMessageTime { get; set; }
    }
}
