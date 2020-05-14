using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.DTOs
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        
        [Required]
        [StringLength(8, MinimumLength=4, ErrorMessage="The password length must be between 4 to 8 characters")]
        public string Password { get; set; }
    }
}