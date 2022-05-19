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
        public Chat? Chat { get; set; } = null;

        [Required(AllowEmptyStrings = false)]
        public string MessageContent { get; set; }

        [Required]
        public DateTime SendTime = DateTime.Now;

        [Required]
        public DateTime? ReseiveTime = null;

        [Required]
        public DateTime? ReadTime = null;

        [Required]
        public MessageStatus MessageStatus = MessageStatus.NotSend;

        public Message MapToModel()
        {
            return new Message
            {
                MessageId = MessageId,
                ChatId = ChatId,
                Chat = Chat,
                MessageContent = MessageContent,
                SendTime = SendTime,
                ReceiveTime = ReseiveTime,
                ReadTime = ReadTime,
                MessageStatus = MessageStatus,
            };
        }
    }
}
