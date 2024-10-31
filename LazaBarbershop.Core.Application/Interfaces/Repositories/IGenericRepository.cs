using LazaBarbershop.Core.Domain.Common;

namespace LazaBarbershop.Core.Application.Interfaces.Repositories;

public interface IGenericRepository<TEntity> where TEntity : AppEntity
{
    Task<TEntity> AddAsync(TEntity entity);
    Task UpdateAsync(int id, TEntity entity);
    Task RemoveAsync(int id);
}