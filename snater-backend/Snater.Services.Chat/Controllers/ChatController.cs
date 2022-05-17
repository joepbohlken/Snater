using Microsoft.AspNetCore.Mvc;
using Snater.Services.Chats.Models;

namespace Snater.Services.Chats.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("chat")]
        public async Task<IActionResult> SendChat([FromBody] Chat chat)
        {
            throw new NotImplementedException();
        }


        [HttpGet]
        [Route("messages")]
        public async Task<IActionResult> GetChatMessagesByChatId(int chatId)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteMessageForSelf(int chatId)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteMessageForBothUsers(int chatId)
        {
            throw new NotImplementedException();
        }
    }
}