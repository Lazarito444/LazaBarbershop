using LazaBarbershop.Core.Application.Dtos.Barbershops;
using LazaBarbershop.Core.Domain.Entities;

namespace LazaBarbershop.Core.Application.Interfaces.Services;

public interface IBarbershopService : IGenericService<Barbershop, BarbershopDto, SaveBarbershopDto>
{
    Task<BarbershopDto?> GetAsync(int id);
    Task<List<BarbershopDto>> GetAsync();
}