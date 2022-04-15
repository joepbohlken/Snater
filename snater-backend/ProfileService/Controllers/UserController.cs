using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Snater.Services.Profile.Services.Interfaces;

namespace Snater.Services.Profile.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IProfileService _profileService;
        public UserController(IProfileService profileService)
        {
            _profileService = profileService;
        }

        [HttpGet]
        public async Task<IActionResult> GetChats([FromQuery] Guid userId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var chats = await _profileService.GetChats(userId);

            return Ok(chats);
        }
    }
}
