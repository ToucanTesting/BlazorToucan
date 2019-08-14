using Microsoft.EntityFrameworkCore;
using BlazorToucanTesting.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace BlazorToucanTesting.Persistence
{
    public class ToucanDbContext : IdentityDbContext
    {
        public ToucanDbContext(DbContextOptions<ToucanDbContext> options) : base(options)
        {
        }

    }
}
