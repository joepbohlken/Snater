using System.ComponentModel.DataAnnotations;

namespace Snater.Services.Chats.Models.DTO
{
    public class ChatUser
    {

        [Key]
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid ChatId { get; set; }
        public Chat? Chat { get; set; } = null;

        public ChatUser()
        {

        }
        public ChatUser(Guid chatId, Guid userId)
        {
            ChatId = chatId;
            UserId = userId;
        }
    }
}
