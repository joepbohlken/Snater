using System.ComponentModel.DataAnnotations;
using Snater.Services.Chats.Enums;

namespace Snater.Services.Chats.Models.DTO
{
    public class MessageEditRequest
    {
        [Required]
        public Guid MessageId { get; set; }

        [Required]
        public string MessageContent {get; set; }
    }
}
