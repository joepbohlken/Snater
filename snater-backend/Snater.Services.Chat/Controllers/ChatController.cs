using Microsoft.AspNetCore.Mvc;
using Snater.Services.Chats.Data.Interfaces;
using Snater.Services.Chats.Models;
using Snater.Services.Chats.Models.DTO;

namespace Snater.Services.Chats.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : Controller
    {
        private readonly IChatRepository _chatRepository;

        public ChatController(IChatRepository chatRepository)
        {
            _chatRepository = chatRepository;   
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("messages")]
        public async Task<IActionResult> GetAllChats()
        {
            var result = await _chatRepository.GetAllChats();
            return Ok(result);
        }

        [HttpGet]
        [Route("messages")]
        public async Task<IActionResult> GetChatMessagesByChatId(Guid chatId)
        {
            var result = await _chatRepository.GetChatById(chatId);
            return Ok(result);
        }

        [HttpPost]
        [Route("chat")]
        public async Task<IActionResult> SendMessage([FromBody] CreateMessageRequest createMessageRequest)
        {
            Message message =  createMessageRequest.MapToModel();
            var result = await _chatRepository.SendMessage(message);
            return Ok(result);
        }

        [HttpPost]
        [Route("chat")]
        public async Task<IActionResult> EditMessage(Guid messageId)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteMessageForSelf(Guid chatId)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteMessageForBothUsers(Guid chatId)
        {
            throw new NotImplementedException();
        }
    }
}