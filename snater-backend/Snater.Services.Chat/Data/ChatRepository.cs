using Snater.Services.Chats.Data.Interfaces;
using Snater.Services.Chats.Models;
using Microsoft.EntityFrameworkCore;

namespace Snater.Services.Chats.Data
{
    public class ChatRepository : IChatRepository
    {

        private readonly ChatContext _chatContext;

        public ChatRepository(ChatContext chatContext)
        {
            _chatContext = chatContext;
        }
        public async Task<List<Chat>> GetChats(Guid chatId)
        {
            var retrievedChats = await _chatContext.Chats.Where(c => c.Id == chatId).ToListAsync();
            return retrievedChats;
        }

        public async Task<>
    }
}
