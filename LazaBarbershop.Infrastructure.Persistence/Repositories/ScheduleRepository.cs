using LazaBarbershop.Core.Application.Interfaces.Repositories;
using LazaBarbershop.Core.Domain.Entities;
using LazaBarbershop.Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace LazaBarbershop.Infrastructure.Persistence.Repositories;

public class ScheduleRepository : GenericRepository<Schedule>, IScheduleRepository
{
    private readonly AppDbContext _dbContext;
    
    public ScheduleRepository(AppDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<Schedule?> GetAsync(int id)
    {
        return await _dbContext.Set<Schedule>().FindAsync(id);
    }

    public async Task<List<Schedule>> GetAsync()
    {
        return await _dbContext.Set<Schedule>().ToListAsync();
    }
}