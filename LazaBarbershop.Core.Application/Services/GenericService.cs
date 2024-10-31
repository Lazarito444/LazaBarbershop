using AutoMapper;
using LazaBarbershop.Core.Application.Interfaces.Repositories;
using LazaBarbershop.Core.Application.Interfaces.Services;
using LazaBarbershop.Core.Domain.Common;

namespace LazaBarbershop.Core.Application.Services;

public class GenericService<TEntity, TEntityDto, TSaveEntityDto> : IGenericService<TEntity, TEntityDto, TSaveEntityDto>
    where TEntity : AppEntity
    where TEntityDto : class
    where TSaveEntityDto : class
{
    private readonly IMapper _mapper;
    private readonly IGenericRepository<TEntity> _genericRepository;
    
    public GenericService(IMapper mapper, IGenericRepository<TEntity> genericRepository)
    {
        _mapper = mapper;
        _genericRepository = genericRepository;
    }

    public async Task<TEntityDto> AddAsync(TSaveEntityDto saveEntityDto)
    {
        TEntity entity = _mapper.Map<TEntity>(saveEntityDto);
        entity = await _genericRepository.AddAsync(entity);
        TEntityDto entityDto = _mapper.Map<TEntityDto>(entity);

        return entityDto;
    }

    public async Task UpdateAsync(int id, TEntityDto entityDto)
    {
        TEntity entity = _mapper.Map<TEntity>(entityDto);
        await _genericRepository.UpdateAsync(id, entity);
    }

    public async Task DeleteAsync(int id)
    {
        await _genericRepository.RemoveAsync(id);
    }
}