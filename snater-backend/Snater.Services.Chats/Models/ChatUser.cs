using System.ComponentModel.DataAnnotations;

namespace Snater.Services.Chats.Models.DTO
{
    public class ChatUser
    {

        [Key]
        public Guid UserId { get; set; }
        public Guid ChatId { get; set; }
        public Chat? Chat { get; set; } = null;
        public Guid Id { get; }
        public ChatUser(Guid id, Guid userId)
        {
            Id = id;
            UserId = userId;
        }
    }
}
