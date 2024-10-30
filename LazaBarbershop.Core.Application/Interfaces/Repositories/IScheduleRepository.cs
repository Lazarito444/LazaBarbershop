using LazaBarbershop.Core.Domain.Entities;

namespace LazaBarbershop.Core.Application.Interfaces.Repositories;

public interface IScheduleRepository : IGenericRepository<Schedule>
{
    Task<Schedule?> GetAsync(int id);
    Task<List<Schedule>> GetAsync();
}