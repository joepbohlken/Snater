using System.ComponentModel.DataAnnotations;
using Snater.Services.Profile.Enums;

namespace Snater.Services.Profile.Models
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        public string? Username { get; set; }
        public UserStatus Status { get; set; }
    }
}
