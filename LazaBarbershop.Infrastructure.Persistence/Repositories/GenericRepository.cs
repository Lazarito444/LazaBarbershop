using LazaBarbershop.Core.Application.Interfaces.Repositories;
using LazaBarbershop.Core.Domain.Common;
using LazaBarbershop.Infrastructure.Persistence.Contexts;

namespace LazaBarbershop.Infrastructure.Persistence.Repositories;

public class GenericRepository<TEntity> : IGenericRepository<TEntity>
    where TEntity : AppEntity
{
    private readonly AppDbContext _dbContext;

    public GenericRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<TEntity> AddAsync(TEntity entity)
    {
        _dbContext.Set<TEntity>().Add(entity);
        await _dbContext.SaveChangesAsync();
        return entity;
    }

    public async Task UpdateAsync(int id, TEntity entity)
    {
        _dbContext.Entry(entity).CurrentValues.SetValues(entity);
        await _dbContext.SaveChangesAsync();
    }
    
    public async Task RemoveAsync(int id)
    {
        TEntity? entity = await _dbContext.Set<TEntity>().FindAsync(id);

        if (entity != null) _dbContext.Set<TEntity>().Remove(entity);
        await _dbContext.SaveChangesAsync();
    }
}