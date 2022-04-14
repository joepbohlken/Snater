using Microsoft.EntityFrameworkCore;
using Snater.Services.Profile.Data.Interfaces;
using Snater.Services.Profile.Models;

namespace Snater.Services.Profile.Data
{
    public class ProfileRepository : IProfileRepository
    {
        private readonly ProfileContext _profileContext;

        public ProfileRepository(ProfileContext profileContext)
        {
            _profileContext = profileContext;
        }
        public async Task<List<Chat>> GetChats(Guid userId)
        {
            var retrievedChats = await _profileContext.Chats.Include(u => u.User).Where(c => c.User.Id == userId).ToListAsync();
            return retrievedChats;
        }
    }
}
