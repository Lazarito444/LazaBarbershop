using LazaBarbershop.Core.Application.Dtos.Schedules;
using LazaBarbershop.Core.Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace LazaBarbershop.Presentation.Api.Controllers.v1;

public class ScheduleController : BaseApiController
{
    private readonly IScheduleService _scheduleService;

    public ScheduleController(IScheduleService scheduleService)
    {
        _scheduleService = scheduleService;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        List<ScheduleDto> scheduleDtos = await _scheduleService.GetAsync();
        return Ok(scheduleDtos);
    }
}