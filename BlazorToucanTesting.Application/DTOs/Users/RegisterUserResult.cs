using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorToucanTesting.Application.DTOs
{
    public class RegisterUserResult : Result
    {
        public bool Successful { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}
