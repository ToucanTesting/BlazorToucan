using System.ComponentModel.DataAnnotations;

namespace BlazorToucanTesting.Application.DTOs
{
    public class LoginUserResult : Result
    {
        public string Token { get; set; }
    }
}
