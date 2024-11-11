using LazaBarbershop.Core.Application.Dtos.Appointments;
using LazaBarbershop.Core.Application.Dtos.Common;
using LazaBarbershop.Core.Application.Dtos.Schedules;

namespace LazaBarbershop.Core.Application.Dtos.Barbershops;

public class BarbershopDto : AppEntityDto
{
    /// <summary>
    /// The name of the barbershop.
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// The address of the barbershop.
    /// </summary>
    public string Address { get; set; }
    
    /// <summary>
    /// The ID of the owner of the barbershop.
    /// </summary>
    public int OwnerId { get; set; }
    
    /// <summary>
    /// Navigation property to the schedules owned by the barbershop.
    /// </summary>
    public ICollection<ScheduleDto> Schedules { get; set; }
    
    /// <summary>
    /// Navigation property to the appointments made in the barbershop.
    /// </summary>
    public ICollection<AppointmentDto> Appointments { get; set; }
}