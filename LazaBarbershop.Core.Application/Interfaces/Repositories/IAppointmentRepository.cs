using LazaBarbershop.Core.Domain.Entities;

namespace LazaBarbershop.Core.Application.Interfaces.Repositories;

public interface IAppointmentRepository : IGenericRepository<Appointment>
{
    Task<Appointment?> GetAsync(int id);
    Task<List<Appointment>> GetAsync();
}