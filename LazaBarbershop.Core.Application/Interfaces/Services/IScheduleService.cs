using LazaBarbershop.Core.Application.Dtos.Schedules;
using LazaBarbershop.Core.Domain.Entities;

namespace LazaBarbershop.Core.Application.Interfaces.Services;

public interface IScheduleService : IGenericService<Schedule, ScheduleDto, SaveScheduleDto>
{
    Task<ScheduleDto?> GetAsync(int id);
    Task<List<ScheduleDto>> GetAsync();
}