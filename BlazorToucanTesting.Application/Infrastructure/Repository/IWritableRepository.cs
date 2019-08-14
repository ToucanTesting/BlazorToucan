using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorToucanTesting.Application.Infrastructure.Repository
{
    public interface IWritableRepository<TEntity, TDto> where TEntity : class where TDto : class
    {
        Task Add(TDto dto);
        void AddRange(IEnumerable<TDto> dtos);
    }
}
