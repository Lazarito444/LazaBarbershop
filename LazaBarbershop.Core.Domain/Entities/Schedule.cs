namespace LazaBarbershop.Core.Domain.Entities;

public class Schedule
{
    public int Id { get; set; }
    public int BarbershopId { get; set; }
    public DayOfWeek Day { get; set; }
    public TimeSpan OpenTime { get; set; }
    public TimeSpan CloseTime { get; set; }
    public Barbershop Barbershop { get; set; }
}