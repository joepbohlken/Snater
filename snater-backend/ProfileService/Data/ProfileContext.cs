using Microsoft.EntityFrameworkCore;
using Snater.Services.Profile.Models;

namespace Snater.Services.Profile.Data
{
    public class ProfileContext : DbContext
    {
        public ProfileContext(DbContextOptions<ProfileContext> options) : base(options)
        {

        }
        public DbSet<Chat> Chats { get; set; }
    }

}
