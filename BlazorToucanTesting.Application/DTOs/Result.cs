using System.Collections.Generic;

namespace BlazorToucanTesting.Application.DTOs
{
    public class Result
    {
        public bool Successful { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}
