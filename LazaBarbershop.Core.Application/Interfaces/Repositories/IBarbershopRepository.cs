using LazaBarbershop.Core.Domain.Entities;

namespace LazaBarbershop.Core.Application.Interfaces.Repositories;

public interface IBarbershopRepository : IGenericRepository<Barbershop>
{
    Task<Barbershop?> GetAsync(int id);
    Task<List<Barbershop>> GetAsync();
}