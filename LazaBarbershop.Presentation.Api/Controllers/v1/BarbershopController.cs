using Asp.Versioning;
using LazaBarbershop.Core.Application.Dtos.Barbershops;
using LazaBarbershop.Core.Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace LazaBarbershop.Presentation.Api.Controllers.v1;

[ApiVersion("1.0")]
public class BarbershopController : BaseApiController
{
    private readonly IBarbershopService _barbershopService;

    public BarbershopController(IBarbershopService barbershopService)
    {
        _barbershopService = barbershopService;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] SaveBarbershopDto saveBarbershopDto)
    {
        BarbershopDto barbershopDto = await _barbershopService.AddAsync(saveBarbershopDto);

        return CreatedAtAction(nameof(Get), new { Id = barbershopDto.Id }, barbershopDto);
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        List<BarbershopDto> barbershopDtos = await _barbershopService.GetAsync();

        return Ok(barbershopDtos);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> Get([FromRoute] int id)
    {
        BarbershopDto? barbershopDto = await _barbershopService.GetAsync(id);

        if (barbershopDto == null) return NotFound();

        return Ok(barbershopDto);
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete([FromRoute] int id)
    {
        await _barbershopService.DeleteAsync(id);

        return NoContent();
    }

    // [HttpPut("{id:int}")]
    // public async Task<IActionResult> Update([FromRoute] int id, [FromBody] SaveBarbershopDto saveBarbershopDto)
    // {
    //     _barbershopService.UpdateAsync(id,);
    // }
}