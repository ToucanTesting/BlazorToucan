using System.ComponentModel.DataAnnotations;

namespace BlazorToucanTesting.Application.DTOs.Users
{
    public class PasswordUserDto : UserDto
    {
        [Required]
        public string Password { get; set; }
    }
}