using Snater.Services.Chats.Enums;

namespace Snater.Services.Chats.Models
{
    public class Message
    {
        public Guid MessageId { get; set; }
        public Chat ChatId { get;set; }
        public string MessageContent { get; set; }
        public MessageStatus messageStatus { get; set; }
    }
}
