using Snater.Services.Profile.Models.DTO;

namespace Snater.Services.Profile.Services.Interfaces
{
    public interface IProfileService
    {
        Task<GetChatsResponse> GetChats(Guid userId);
    }
}
