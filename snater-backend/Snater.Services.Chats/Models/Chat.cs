using System.ComponentModel.DataAnnotations;

namespace Snater.Services.Chats.Models
{
    public class Chat
    {
        // test 8
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid CreatorId { get; set; }
        public List<Guid> Admins { get; set; }
        public List<Guid> Participants { get; set; }
        public List<Message> Messages { get; set; }
        public Message LastMessage { get; set; }
        public DateTime LastMessageTime { get; set; }
    }
}
