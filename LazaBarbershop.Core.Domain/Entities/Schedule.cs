using LazaBarbershop.Core.Domain.Common;

namespace LazaBarbershop.Core.Domain.Entities;

/// <summary>
/// The class that represents the Schedule entity at database level.
/// </summary>
public class Schedule : AppEntity
{
    /// <summary>
    /// The ID of the barbershop that belongs this schedule.
    /// </summary>
    public int BarbershopId { get; set; }
    
    /// <summary>
    /// The WeekDay of the schedule.
    /// </summary>
    public DayOfWeek Day { get; set; }
    
    /// <summary>
    /// The open time of the schedule.
    /// </summary>
    public TimeSpan OpenTime { get; set; }
    
    /// <summary>
    /// The close time of the schedule.
    /// </summary>
    public TimeSpan CloseTime { get; set; }
    
    /// <summary>
    /// Navigation property to the Barbershop that owns this schedule
    /// </summary>
    public Barbershop Barbershop { get; set; }
}