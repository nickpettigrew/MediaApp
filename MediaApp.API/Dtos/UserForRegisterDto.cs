using System.ComponentModel.DataAnnotations;

namespace MediaApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [StringLength(16, MinimumLength = 8, ErrorMessage = "You must create a password between 8 and 16 characters")]
        public string Password { get; set; }

    }
}