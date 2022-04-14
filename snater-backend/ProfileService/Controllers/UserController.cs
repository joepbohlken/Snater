﻿using Microsoft.AspNetCore.Http;
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

            //List<Chat> chats = new List<Chat>();
            //chats.Add(new Chat()
            //{
            //    Id = Guid.NewGuid(),
            //    User = new User()
            //    {
            //        Id = Guid.NewGuid(),
            //        Username = "henk",
            //        Status = Enums.UserStatus.Online
            //    },
            //    LastMessage = "hello how is your day",
            //    LastMessageTime = DateTime.Now
            //});

            //chats.Add(new Chat()
            //{
            //    Id = Guid.NewGuid(),
            //    User = new User()
            //    {
            //        Id = Guid.NewGuid(),
            //        Username = "pieter",
            //        Status = Enums.UserStatus.Offline
            //    },
            //    LastMessage = "Wat ga jij vandaag doen?aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",
            //    LastMessageTime = DateTime.Now
            //});

            //chats.Add(new Chat()
            //{
            //    Id = Guid.NewGuid(),
            //    User = new User()
            //    {
            //        Id = Guid.NewGuid(),
            //        Username = "yuran",
            //        Status = Enums.UserStatus.DontDisturb
            //    },
            //    LastMessage = "Gefelicteerd Joep",
            //    LastMessageTime = DateTime.Now
            //});

            //chats.Add(new Chat()
            //{
            //    Id = Guid.NewGuid(),
            //    User = new User()
            //    {
            //        Id = Guid.NewGuid(),
            //        Username = "joris",
            //        Status = Enums.UserStatus.Away
            //    },
            //    LastMessage = "test",
            //    LastMessageTime = DateTime.Now
            //});
            return Ok();
        }
    }
}
