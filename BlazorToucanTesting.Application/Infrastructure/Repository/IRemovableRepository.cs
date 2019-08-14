using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorToucanTesting.Application.Infrastructure.Repository
{
    public interface IRemovableRepository<TEntity, TDto> where TEntity : class where TDto : class
    {
        void Remove(TDto dto);
        void RemoveRange(IEnumerable<TDto> dtos);
    }
}
