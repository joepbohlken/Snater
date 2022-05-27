using Snater.Services.Chats.Enums;

namespace Snater.Services.Chats.Models.DTO
{
    public class MessageDTO
    {
        public Guid Id { get; set; }
        public Guid ChatId { get; set; }
        public Guid SenderId { get; set; }
        public string Content { get; set; }
        public DateTime SendTime { get; set; }
        public DateTime? ReceiveTime { get; set; }
        public DateTime? ReadTime { get; set; }
        public MessageStatus Status { get; set; }

        public MessageDTO()
        {

        }

        public MessageDTO(Guid id, Guid chatId, Guid senderId, string content, DateTime sendTime, DateTime? receiveTime, DateTime? readTime, MessageStatus status)
        {
            Id = id;
            ChatId = chatId;
            SenderId = senderId;  
            Content = content;
            SendTime = sendTime;
            ReceiveTime = receiveTime;
            ReadTime = readTime;
            Status = status;
        }

        public static MessageDTO MapFromModel(Message model)
            => new(
                model.Id,
                model.ChatId,
                model.SenderId,
                model.Content,
                model.SendTime,
                model.ReceiveTime,
                model.ReadTime,
                model.Status);
    public static List<MessageDTO> MapFromList(List<Message> list)
        => list.ConvertAll(x => MapFromModel(x));
    }
}
