using Snater.Services.Profile.Data.Interfaces;
using Snater.Services.Profile.Models.DTO;
using Snater.Services.Profile.Services.Interfaces;

namespace Snater.Services.Profile.Services
{
    public class ProfileService : IProfileService
    {
        private readonly IProfileRepository _profileRepository;

        public ProfileService(IProfileRepository profileRepository)
        {
            _profileRepository = profileRepository;
        }
        public async Task<GetChatsResponse> GetChats(Guid userId)
        {
            var chats = await _profileRepository.GetChats(userId);

            var chatResponse = new List<GetChatResponse>();

            foreach (var chat in chats)
            {
                chatResponse.Add(new GetChatResponse()
                {
                    Id = chat.Id,
                    LastMessage = chat.LastMessage,
                    LastMessageTime = chat.LastMessageTime,
                    Status = chat.User.Status,
                    Username = chat.User.Username
                });
            }

            var chatsResponse = new GetChatsResponse()
            {
                Chats = chatResponse
            };
            return chatsResponse;
        }
    }
}
