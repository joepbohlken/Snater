using Microsoft.EntityFrameworkCore;
using Snater.Services.Chats.Models;
using Snater.Services.Chats.Models.DTO;

namespace Snater.Services.Chats.Data.Interfaces
{
    public interface IChatRepository
    {
        Task<List<ChatDTO>> GetAllChats(Guid userId);
        Task<ChatDTO> GetChatById(Guid chatId);
        Task<ChatDTO> CreateChat(ChatCreateRequest request);
        Task<MessageDTO> SendMessage(MessageCreateRequest request);
        Task<MessageDTO> EditMessage(MessageEditRequest request);
        Task<MessageDTO> DeleteMessage(Guid messageId);
    }
}
