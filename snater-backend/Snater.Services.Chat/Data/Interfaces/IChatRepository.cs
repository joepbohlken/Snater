using Microsoft.EntityFrameworkCore;
using Snater.Services.Chats.Models;
using Snater.Services.Chats.Models.DTO;

namespace Snater.Services.Chats.Data.Interfaces
{
    public interface IChatRepository
    {
        Task<List<Chat>> GetAllChats();
        Task<Chat> GetChatById(Guid chatId);
        Task<Message> SendMessage(Message request);
    }
}
