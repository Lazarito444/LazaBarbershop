using AutoMapper;
using LazaBarbershop.Core.Application.Dtos.Appointments;
using LazaBarbershop.Core.Application.Interfaces.Repositories;
using LazaBarbershop.Core.Application.Interfaces.Services;
using LazaBarbershop.Core.Domain.Entities;

namespace LazaBarbershop.Core.Application.Services;

public class AppointmentService : GenericService<Appointment, AppointmentDto, SaveAppointmentDto>, IAppointmentService
{
    private readonly IMapper _mapper;
    private readonly IAppointmentRepository _appointmentRepository;
    
    public AppointmentService(IMapper mapper, IGenericRepository<Appointment> genericRepository, IAppointmentRepository appointmentRepository) : base(mapper, genericRepository)
    {
        _mapper = mapper;
        _appointmentRepository = appointmentRepository;
    }

    public async Task<AppointmentDto?> GetAsync(int id)
    {
        Appointment? appointment = await _appointmentRepository.GetAsync(id);
        
        if (appointment == null) return null;
        
        AppointmentDto appointmentDto = _mapper.Map<AppointmentDto>(appointment);
        return appointmentDto;
    }

    public async Task<List<AppointmentDto>> GetAsync()
    {
        List<Appointment> appointments = await _appointmentRepository.GetAsync();
        List<AppointmentDto> appointmentDtos = _mapper.Map<List<AppointmentDto>>(appointments);
        
        return appointmentDtos;
    }
}