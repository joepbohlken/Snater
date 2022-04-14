using Snater.Services.Profile.Enums;

namespace Snater.Services.Profile.Models.DTO
{
    public class GetChatResponse
    {
        public Guid Id { get; set; }
        public string? LastMessage { get; set; }
        public DateTime LastMessageTime { get; set; }
        public string? Username { get; set; }
        public UserStatus Status { get; set; }
    }
}
