﻿using Snater.Services.Chats.Data.Interfaces;
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


        public async Task<List<ChatDTO>> GetAllChats(Guid userId)
        {
            var retrievedChats = await _chatContext.ChatUsers.Include(c => c.Chat).Where(u => u.UserId == userId).ToListAsync();
            List<Chat> result = new List<Chat>();

            foreach(ChatUser chatUser in retrievedChats)
            {
                result.Add(chatUser.Chat);
            }

            return ChatDTO.MapFromList(result);
        }

        public async Task<ChatDTO> GetChatById(Guid chatId)
        {
            var retrievedChat = await _chatContext.Chats.SingleAsync(c => c.Id == chatId);
            return ChatDTO.MapFromModel(retrievedChat);
        }

        public async Task<ChatDTO> CreateChat(ChatCreateRequest request)
        {
            Chat chatToCreate = new Chat(request.Name, request.CreatorId);
            var chat = await _chatContext.AddAsync(chatToCreate);
            List<ChatUser> chatUsers = new List<ChatUser>();

            foreach (Guid userId in request.ChatUsers)
            {
                ChatUser chatUser = new ChatUser(chatToCreate.Id, userId);
                chatUsers.Add(chatUser);
            }

            await _chatContext.AddRangeAsync(chatUsers);
            await _chatContext.SaveChangesAsync();

            return ChatDTO.MapFromModel(chat.Entity);
        }

        public async Task<MessageDTO> SendMessage(MessageCreateRequest request)
        {
            Message messageToSend = request.MapToModel();
            var message = await _chatContext.Messages.AddAsync(messageToSend);
            await _chatContext.SaveChangesAsync();

            return MessageDTO.MapFromModel(message.Entity);
        }
        public async Task<MessageDTO> EditMessage(MessageEditRequest request)
        {
            Message retrievedMessage = await _chatContext.Messages.SingleAsync(m => m.Id == request.MessageId);
            retrievedMessage.Content = request.MessageContent;

            await _chatContext.SaveChangesAsync();
            return MessageDTO.MapFromModel(retrievedMessage);
        }

        public async Task<MessageDTO> DeleteMessage(Guid messageId)
        {
            Message retrievedMessage = await _chatContext.Messages.SingleAsync(m => m.Id == messageId);
            _chatContext.Remove(retrievedMessage);
            await _chatContext.SaveChangesAsync();

            return MessageDTO.MapFromModel(retrievedMessage);
        }
    }
}
