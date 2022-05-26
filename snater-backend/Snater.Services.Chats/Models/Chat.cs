using System.ComponentModel.DataAnnotations;
using Snater.Services.Chats.Models.DTO;

namespace Snater.Services.Chats.Models
{
    public class Chat
    {
        // test 8
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid CreatorId { get; set; }
        public List<ChatUser> ChatUsers { get; set; } = new List<ChatUser>();
        public List<Message>? Messages { get; set; } = new List<Message>();

        public Chat()
        {

        }
        public Chat(string name, Guid creatorId)
        {
            Id = Guid.NewGuid();
            Name = name;
            CreatorId = creatorId;
        }
    }
}
