using BlazorToucanTesting.Application.DTOs.Users;
using BlazorToucanTesting.Application.Infrastructure.Repository;
using BlazorToucanTesting.Domain.Entities;

namespace BlazorToucanTesting.Application.Infrastructure.Users
{
    public interface IUsersRepository : IRepository<User, UserDto>
    {
    }
}
