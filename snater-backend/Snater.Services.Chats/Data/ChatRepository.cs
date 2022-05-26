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


        public async Task<List<Chat>> GetAllChats(Guid userId)
        {
            var retrievedChats = await _chatContext.ChatUsers.Include(c => c.Chat).Where(u => u.UserId == userId).ToListAsync();

            List<Chat> result = new List<Chat>();
            foreach(ChatUser chatUser in retrievedChats)
            {
                result.Add(chatUser.Chat);
            }

            return result;
        }

        public async Task<Chat> GetChatById(Guid chatId)
        {
            var retrievedChat = await _chatContext.Chats.SingleAsync(c => c.Id == chatId);
            return retrievedChat;
        }

        public async Task<Chat> CreateChat(ChatCreateRequest request)
        {
            //Chat chat = new Chat(request.Id, request.Name, request.CreatorId);
            //ChatUser chatUsers = new ChatUser() { ChatId = chat.Id, UserId = chat.CreatorId };

            //await _chatContext.AddAsync(chat);
            //await _chatContext.AddAsync(chatUsers);
            //await _chatContext.SaveChangesAsync();

            //return chat;


            List<ChatUser> chatUsers = new List<ChatUser>();
            foreach (Guid userId in request.ChatUsers)
            {
                ChatUser chatUser = new ChatUser(request.Id, userId);
                chatUsers.Add(chatUser);
            }

            Chat chatToCreate = new Chat(request.Id, request.Name, request.CreatorId, chatUsers);

            var chat = await _chatContext.AddAsync(chatToCreate);
            await _chatContext.AddRangeAsync(chatUsers);
            //foreach (ChatUser user in chatUsers)
            //{
            //    await _chatContext.AddAsync(user);
            //}
            await _chatContext.SaveChangesAsync();

            return chat.Entity;
        }

        public async Task<Message> SendMessage(MessageCreateRequest request)
        {
            Message messageToSend = request.MapToModel();
            var message = await _chatContext.Messages.AddAsync(messageToSend);
            await _chatContext.SaveChangesAsync();
            return message.Entity;
        }
        public async Task<Message> EditMessage(MessageEditRequest request)
        {
            Message retrievedMessage = await _chatContext.Messages.SingleAsync(m => m.Id == request.MessageId);
            retrievedMessage.Content = request.MessageContent;

            await _chatContext.SaveChangesAsync();
            return retrievedMessage;
        }

//test 3
        public async Task<Message> DeleteMessage(Guid messageId)
        {
            Message retrievedMessage = await _chatContext.Messages.SingleAsync(m => m.Id == messageId);
            _chatContext.Remove(retrievedMessage);
            await _chatContext.SaveChangesAsync();

            return retrievedMessage;
        }
    }
}
