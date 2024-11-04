using LazaBarbershop.Core.Domain.Common;

namespace LazaBarbershop.Core.Domain.Entities;

/// <summary>
/// The class that represents the Barbershop entity at database level.
/// </summary>
public class Barbershop : AppEntity
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
    public ICollection<Schedule> Schedules { get; set; }
    
    /// <summary>
    /// Navigation property to the appointments made in the barbershop.
    /// </summary>
    public ICollection<Appointment> Appointments { get; set; }
}