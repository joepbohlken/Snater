using System.ComponentModel.DataAnnotations;

namespace Snater.Services.Chats.Models
{
    public class Chat
    {
        // test 8
        [Key]
        public Guid ChatId { get; set; }
        public List<string> Participants { get; set; }
        public List<Message> Messages { get; set; }
        public Message LastMessage { get; set; }
        public DateTime LastMessageTime { get; set; }
    }
}
