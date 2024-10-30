using LazaBarbershop.Core.Application.Interfaces.Repositories;
using LazaBarbershop.Core.Domain.Entities;
using LazaBarbershop.Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace LazaBarbershop.Infrastructure.Persistence.Repositories;

public class AppointmentRepository : GenericRepository<Appointment>, IAppointmentRepository
{
    private readonly AppDbContext _dbContext;
    public AppointmentRepository(AppDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Appointment?> GetAsync(int id)
    {
        return await _dbContext.Set<Appointment>().FindAsync(id);
    }

    public async Task<List<Appointment>> GetAsync()
    {
        return await _dbContext.Set<Appointment>().ToListAsync();
    }
}