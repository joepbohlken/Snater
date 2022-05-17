using Microsoft.EntityFrameworkCore;
using Snater.Services.Chats.Models;

namespace Snater.Services.Chats.Data.Interfaces
{
    public interface IChatRepository
    {
        Task<List<Chat>> GetChats(Guid chatId);

    }
}
