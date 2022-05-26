using System.ComponentModel.DataAnnotations;

namespace Snater.Services.Chats.Models.DTO
{
    public class ChatCreateRequest
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public Guid CreatorId { get; set; }

        [Required]
        public List<Guid> ChatUsers { get; set; }
    }
}
