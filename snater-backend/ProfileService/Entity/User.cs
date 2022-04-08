using System.ComponentModel.DataAnnotations;
using ProfileService.Enums;

namespace ProfileService.Entity
{


    public class User
    {
        [Key]
        public Guid Id { get; set; }
        public string? Username { get; set; }
        public  UserStatus Status {get;set;}
    }
}
