using System.Linq;
using System.Threading.Tasks;
using BlazorToucanTesting.Application.DTOs;
using BlazorToucanTesting.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlazorToucanTesting.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private static UserBase LoggedOutUser = new UserBase { IsAuthenticated = false };

        private readonly UserManager<IdentityUser> _userManager;

        public AccountsController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]RegisterUser model)
        {
            var newUser = new IdentityUser { UserName = model.Email, Email = model.Email };

            var result = await _userManager.CreateAsync(newUser, model.Password);

            if (!result.Succeeded)
            {
                var errors = result.Errors.Select(x => x.Description);

                return BadRequest(new RegisterUserResult { Successful = false, Errors = errors });

            }

            return Ok(new RegisterUserResult { Successful = true });
        }

        [HttpGet("user")]
        public IActionResult GetUser()
        {
            if (User.Identity.IsAuthenticated)
            {
                var userModel = new UserBase
                {
                    Email = User.Identity.Name,
                    IsAuthenticated = true
                };

                return Ok(userModel);
            }

            return Ok(LoggedOutUser);
        }
    }
}
