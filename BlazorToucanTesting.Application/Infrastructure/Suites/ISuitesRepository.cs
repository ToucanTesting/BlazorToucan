using BlazorToucanTesting.Application.DTOs.Suites;
using BlazorToucanTesting.Application.Infrastructure.Repository;
using BlazorToucanTesting.Domain.Entities;

namespace BlazorToucanTesting.Application.Infrastructure.Suites
{
    public interface ISuitesRepository : IRepository<Suite, SuiteDto>
    {
    }
}
