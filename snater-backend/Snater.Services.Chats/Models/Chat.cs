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
        public List<Guid> Admins { get; set; }
        public List<ChatUser> ChatUsers { get; set; }
        public List<Message>? Messages { get; set; } = null;
        public Message? LastMessage { get; set; } = null;
        public DateTime? LastMessageTime { get; set; } = null;

        public Chat(Guid id, string name, Guid creatorId, List<ChatUser> chatUsers)
        {
            Id = id;
            Name = name;
            CreatorId = creatorId;
            ChatUsers = chatUsers;
        }
    }
}
