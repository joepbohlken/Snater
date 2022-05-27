using System.ComponentModel.DataAnnotations;
using Snater.Services.Chats.Enums;

namespace Snater.Services.Chats.Models.DTO
{
    public class MessageCreateRequest
    {
        [Required]
        public Guid MessageId = Guid.NewGuid();

        [Required]
        public Guid ChatId { get; set; }

        [Required]
        public Guid SenderId { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string MessageContent { get; set; }

        [Required]
        public DateTime SendTime = DateTime.Now;

        public Message MapToModel()
        {
            return new Message
            {
                Id = MessageId,
                ChatId = ChatId,
                SenderId = SenderId,
                Content = MessageContent,
                SendTime = SendTime,
            };
        }
    }
}
