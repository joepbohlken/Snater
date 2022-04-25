using Microsoft.AspNetCore.Mvc;

namespace Snater.Services.Chat.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
