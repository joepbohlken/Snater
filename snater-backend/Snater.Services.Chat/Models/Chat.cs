using System.ComponentModel.DataAnnotations;

namespace Snater.Services.Chats.Models
{
    public class Chat
    {
        // test 8
        [Key]
        public Guid Id { get; set; }
        // make string Users later
        public List<string> Participants { get; set; }
        public List<Message> Messages { get; set; }
        public Message LastMessage { get; set; }
        public DateTime LastMessageTime { get; set; }
    }
}
