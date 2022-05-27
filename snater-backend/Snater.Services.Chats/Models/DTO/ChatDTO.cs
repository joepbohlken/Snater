namespace Snater.Services.Chats.Models.DTO
{
    public class ChatDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid CreatorId { get; set; }
        public List<MessageDTO> Messages { get; set; }
        public List<ChatUserDTO> ChatUsers { get; set; }

        public ChatDTO()
        {

        }

        public ChatDTO(Guid id, string name, Guid creatorId, List<Message> messages, List<ChatUser> chatUsers)
        {
            Id = id;
            Name = name;
            CreatorId = creatorId;
            Messages = messages == null ? null : MessageDTO.MapFromList(messages);
            ChatUsers = chatUsers == null ? null : ChatUserDTO.MapFromList(chatUsers);
        }

        public static ChatDTO MapFromModel(Chat model)
            => new(
                model.Id,
                model.Name,
                model.CreatorId,
                model.Messages,
                model.ChatUsers);
    }
}
