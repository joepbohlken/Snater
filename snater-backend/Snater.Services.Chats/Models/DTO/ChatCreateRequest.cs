using System.ComponentModel.DataAnnotations;

namespace Snater.Services.Chats.Models.DTO
{
    public class ChatCreateRequest
    {
        [Required]
        public Guid Id = Guid.NewGuid();

        [Required]
        public string Name { get; set; } = "Chat";

        [Required]
        public Guid CreatorId { get; set; }
        
        [Required]
        public List<Guid> Admins { get; set; }

        [Required]
        public List<Guid> Participants { get; set; }

        public Chat MapToModel()
        {
            return new Chat
            {
                Id = Id,
                Name = Name,
                CreatorId = CreatorId,
                Admins = Admins,
                Participants = Participants,
            };
        }
    }
}
