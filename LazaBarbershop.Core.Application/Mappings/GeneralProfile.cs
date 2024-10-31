using AutoMapper;
using LazaBarbershop.Core.Application.Dtos.Appointments;
using LazaBarbershop.Core.Application.Dtos.Barbershops;
using LazaBarbershop.Core.Application.Dtos.Schedules;
using LazaBarbershop.Core.Domain.Entities;

namespace LazaBarbershop.Core.Application.Mappings;

public class GeneralProfile : Profile
{
    public GeneralProfile()
    {
        // APPOINTMENT MAPPINGS
        CreateMap<Appointment, AppointmentDto>().ReverseMap();
        CreateMap<Appointment, SaveAppointmentDto>().ReverseMap();

        // BARBERSHOP MAPPINGS
        CreateMap<Barbershop, BarbershopDto>().ReverseMap();
        CreateMap<Barbershop, SaveBarbershopDto>().ReverseMap();

        // SCHEDULE MAPPINGS
        CreateMap<Schedule, ScheduleDto>().ReverseMap();
        CreateMap<Schedule, SaveScheduleDto>().ReverseMap();
    }
}