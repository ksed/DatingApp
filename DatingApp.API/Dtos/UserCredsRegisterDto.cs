using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserCredsRegisterDto
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [StringLength(12, MinimumLength = 8, ErrorMessage = "Passwords must be between 8 and 12 characters")]
        public string Password { get; set; }
    }
}