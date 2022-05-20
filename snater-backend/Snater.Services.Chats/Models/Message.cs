using System.ComponentModel.DataAnnotations;
using Snater.Services.Chats.Enums;
using Snater.Services.Chats.Models.DTO;

namespace Snater.Services.Chats.Models
{
    public class Message
    {
        [Key]
        public Guid Id { get; set; }
        public Guid ChatId { get;set; }
        public Chat? Chat { get; set; }
        public Guid SenderId { get; set; }
        public string Content { get; set; }
        public DateTime SendTime { get; set; }
        public DateTime? ReceiveTime { get; set; }
        public DateTime? ReadTime { get; set; }
        public MessageStatus Status { get; set; }
    }
}
