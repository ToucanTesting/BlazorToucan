using AutoMapper;
using BlazorToucanTesting.Application.DTOs.Users;
using BlazorToucanTesting.Application.Infrastructure.Users;
using BlazorToucanTesting.Domain.Entities;

namespace BlazorToucanTesting.Persistence.Repositories
{
    public class UsersRepository : BaseRepository<User, UserDto>, IUsersRepository
    {
        public UsersRepository(ToucanDbContext context, IMapper mapper) : base(context, mapper)
        {
            
        }
    }
}
