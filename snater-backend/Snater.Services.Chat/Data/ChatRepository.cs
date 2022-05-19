using Snater.Services.Chats.Data.Interfaces;
using Snater.Services.Chats.Models;
using Microsoft.EntityFrameworkCore;
using Snater.Services.Chats.Models.DTO;

namespace Snater.Services.Chats.Data
{
    public class ChatRepository : IChatRepository
    {

        private readonly ChatContext _chatContext;

        public ChatRepository(ChatContext chatContext)
        {
            _chatContext = chatContext;
        }
        public async Task<List<Chat>> GetAllChats()
        {
            var retrievedChats = await _chatContext.Chats.ToListAsync();
            return retrievedChats;
        }

        public async Task<Chat> GetChatById(Guid chatId)
        {
            var retrievedChat = await _chatContext.Chats.SingleAsync(c => c.ChatId == chatId);
            return retrievedChat;
        }

        public async Task<Message> SendMessage(Message request)
        {
            var message = await _chatContext.Messages.AddAsync(request);
            await _chatContext.SaveChangesAsync();
            return message.Entity;
        }
    }
}
