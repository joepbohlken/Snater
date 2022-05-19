using Microsoft.AspNetCore.Mvc;

namespace Snater.Services.Friends.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FriendController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SendFriendRequest(string username)
        {
            throw new NotImplementedException();
        }


        [HttpGet]
        public async Task<IActionResult> GetFriendRequests(int userId)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<IActionResult> AcceptFriendRequest(int userId)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<IActionResult> DenyFriendRequest(int userId)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<IActionResult> BockFriend(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
