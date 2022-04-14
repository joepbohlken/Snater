using Snater.Services.Profile.Models;

namespace Snater.Services.Profile.Data.Interfaces
{
    public interface IProfileRepository
    {
        Task<List<Chat>> GetChats(Guid userId);

    }
}
