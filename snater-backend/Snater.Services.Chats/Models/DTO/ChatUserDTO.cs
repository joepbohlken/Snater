namespace Snater.Services.Chats.Models.DTO
{
    public class ChatUserDTO
    {
        public Guid UserId { get; set; }

        public ChatUserDTO()
        {

        }

        public ChatUserDTO(Guid userId)
        {
            UserId = userId;
        }

        public static ChatUserDTO MapFromModel(ChatUser model)
            => new(
                model.UserId);

        public static List<ChatUserDTO> MapFromList(List<ChatUser> list)
            => list.ConvertAll(x => MapFromModel(x));
    }
}
