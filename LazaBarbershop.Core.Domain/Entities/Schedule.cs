using LazaBarbershop.Core.Domain.Common;

namespace LazaBarbershop.Core.Domain.Entities;

public class Schedule : AppEntity
{
    public int BarbershopId { get; set; }
    public DayOfWeek Day { get; set; }
    public TimeSpan OpenTime { get; set; }
    public TimeSpan CloseTime { get; set; }
    public Barbershop Barbershop { get; set; }
}