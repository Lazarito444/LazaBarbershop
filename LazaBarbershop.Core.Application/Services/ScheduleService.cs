using AutoMapper;
using LazaBarbershop.Core.Application.Dtos.Schedules;
using LazaBarbershop.Core.Application.Interfaces.Repositories;
using LazaBarbershop.Core.Application.Interfaces.Services;
using LazaBarbershop.Core.Domain.Entities;

namespace LazaBarbershop.Core.Application.Services;

public class ScheduleService : GenericService<Schedule, ScheduleDto, SaveScheduleDto>, IScheduleService
{
    private readonly IMapper _mapper;
    private readonly IScheduleRepository _scheduleRepository;
    
    public ScheduleService(IMapper mapper, IGenericRepository<Schedule> genericRepository, IScheduleRepository scheduleRepository) : base(mapper, genericRepository)
    {
        _mapper = mapper;
        _scheduleRepository = scheduleRepository;
    }

    public async Task<ScheduleDto?> GetAsync(int id)
    {
        Schedule? schedule = await _scheduleRepository.GetAsync(id);

        if (schedule == null) return null;

        ScheduleDto scheduleDto = _mapper.Map<ScheduleDto>(schedule);
        return scheduleDto;
    }

    public async Task<List<ScheduleDto>> GetAsync()
    {
        List<Schedule> schedules = await _scheduleRepository.GetAsync();
        List<ScheduleDto> scheduleDtos = _mapper.Map<List<ScheduleDto>>(schedules);

        return scheduleDtos;
    }
}