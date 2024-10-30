using LazaBarbershop.Core.Domain.Common;

namespace LazaBarbershop.Core.Domain.Entities;

public class Appointment : AppEntity
{
    public int ClientId { get; set; }
    public int BarberId { get; set; }
    public int BarbershopId { get; set; }
    public DateTime DateTime { get; set; }
    public Barbershop Barbershop { get; set; }
}