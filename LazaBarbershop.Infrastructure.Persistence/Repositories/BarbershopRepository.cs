using LazaBarbershop.Core.Application.Interfaces.Repositories;
using LazaBarbershop.Core.Domain.Entities;
using LazaBarbershop.Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace LazaBarbershop.Infrastructure.Persistence.Repositories;

public class BarbershopRepository : GenericRepository<Barbershop>, IBarbershopRepository
{
    private readonly AppDbContext _dbContext;
    
    public BarbershopRepository(AppDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<Barbershop?> GetAsync(int id)
    {
        return await _dbContext.Set<Barbershop>().FindAsync(id);
    }

    public async Task<List<Barbershop>> GetAsync()
    {
        return await _dbContext.Set<Barbershop>().ToListAsync();
    }
}