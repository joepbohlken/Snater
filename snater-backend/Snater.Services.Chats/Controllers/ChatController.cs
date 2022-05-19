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

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("getallchats")]
        public async Task<IActionResult> GetAllChats()
        {
            var result = await _chatRepository.GetAllChats();
            return Ok(result);
        }

        [HttpGet]
        [Route("getchatbyid/{id}")] 
        public async Task<IActionResult> GetChatMessagesByChatId(Guid chatId)
        {
            var result = await _chatRepository.GetChatById(chatId);
            return Ok(result);
        }

        [HttpPost]
        [Route("createchat")]
        public async Task<IActionResult> CreateChat(ChatCreateRequest request)
        {
            var result = await _chatRepository.CreateChat(request);
            return Ok(result);
        }

        [HttpPost]
        [Route("sendmessage")]
        public async Task<IActionResult> SendMessage([FromBody] MessageCreateRequest request)
        {
            var result = await _chatRepository.SendMessage(request);
            return Ok(result);
        }

        [HttpPost]
        [Route("editmessage/{id}")]
        public async Task<IActionResult> EditMessage([FromBody] MessageEditRequest request)
        {
            var result = await _chatRepository.EditMessage(request);
            return Ok(result);
        }

        [HttpPost]
        [Route("deletemessge/{id}")]
        public async Task<IActionResult> DeleteMessage(Guid messageId)
        {
            var result = await _chatRepository.DeleteMessage(messageId);
            return Ok(result);
        }
    }
}