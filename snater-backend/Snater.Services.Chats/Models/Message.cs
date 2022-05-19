using Snater.Services.Chats.Enums;

namespace Snater.Services.Chats.Models
{
    public class Message
    {
        public Guid MessageId { get; set; }
        public Guid ChatId { get;set; }
        public Chat? Chat { get; set; }
        public string MessageContent { get; set; }
        public DateTime SendTime { get; set; }
        public DateTime? ReceiveTime { get; set; }
        public DateTime? ReadTime { get; set; }
        public MessageStatus MessageStatus { get; set; }
    }
}
