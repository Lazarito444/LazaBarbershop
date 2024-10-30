using LazaBarbershop.Core.Domain.Common;

namespace LazaBarbershop.Core.Domain.Entities;

public class Barbershop : AppEntity
{
    public string Name { get; set; }
    public string Address { get; set; }
    public int OwnerId { get; set; }
    public ICollection<Schedule> Schedules { get; set; }
    public ICollection<Appointment> Appointments { get; set; }
}