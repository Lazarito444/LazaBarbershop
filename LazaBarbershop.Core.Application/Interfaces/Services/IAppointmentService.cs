using LazaBarbershop.Core.Application.Dtos.Appointments;
using LazaBarbershop.Core.Domain.Entities;

namespace LazaBarbershop.Core.Application.Interfaces.Services;

public interface IAppointmentService : IGenericService<Appointment, AppointmentDto, SaveAppointmentDto>
{
    Task<AppointmentDto?> GetAsync(int id);
    Task<List<AppointmentDto>> GetAsync();
}