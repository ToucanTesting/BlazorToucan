using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BlazorToucanTesting.Application.Infrastructure.Repository;

namespace BlazorToucanTesting.Persistence.Repositories
{
    public class BaseRepository<TEntity, TDto> : IRepository<TEntity, TDto> where TEntity : class where TDto : class
    {
        protected readonly ToucanDbContext _context;
        protected readonly IMapper _mapper;

        public BaseRepository(ToucanDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public TDto Get(Guid id)
        {
            var dto = _context.Set<TEntity>().Find(id);
            return _mapper.Map<TEntity, TDto>(dto);
        }

        public IEnumerable<TDto> GetAll()
        {
            var dtos = _context.Set<TEntity>().ToList();
            return _mapper.Map<IEnumerable<TEntity>, IEnumerable<TDto>>(dtos);
        }

        public async Task Add(TDto dto)
        {
            var entity = _mapper.Map<TDto, TEntity>(dto);
            _context.Set<TEntity>().Add(entity);
            await _context.SaveChangesAsync();
        }

        public void AddRange(IEnumerable<TDto> dtos)
        {
            var entities = _mapper.Map<IEnumerable<TDto>, IEnumerable<TEntity>>(dtos);
            _context.Set<TEntity>().AddRange(entities);
        }

        public void Remove(TDto dto)
        {
            var entity = _mapper.Map<TDto, TEntity>(dto);
            _context.Set<TEntity>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<TDto> dtos)
        {
            var entities = _mapper.Map<IEnumerable<TDto>, IEnumerable<TEntity>>(dtos);
            _context.Set<TEntity>().RemoveRange(entities);
        }
    }
}
