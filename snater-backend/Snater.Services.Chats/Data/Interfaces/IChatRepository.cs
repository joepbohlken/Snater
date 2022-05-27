using Microsoft.EntityFrameworkCore;
using Snater.Services.Chats.Models;
using Snater.Services.Chats.Models.DTO;

namespace Snater.Services.Chats.Data.Interfaces
{
    public interface IChatRepository
    {
        Task<List<Chat>> GetAllChats(Guid userId);
        Task<Chat> GetChatById(Guid chatId);
        Task<ChatDTO> CreateChat(ChatCreateRequest request);
        Task<Message> SendMessage(MessageCreateRequest request);
        Task<Message> EditMessage(MessageEditRequest request);
        Task<Message> DeleteMessage(Guid messageId);
    }
}
