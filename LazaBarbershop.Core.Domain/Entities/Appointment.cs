using LazaBarbershop.Core.Domain.Common;

namespace LazaBarbershop.Core.Domain.Entities;

/// <summary>
/// The class that represents the Appointment entity at database level.
/// </summary>
public class Appointment : AppEntity
{
    /// <summary>
    /// The ID of the client that booked the appointment.
    /// </summary>
    public int ClientId { get; set; }
    
    /// <summary>
    /// The ID of the barber that is going to serve the client.
    /// </summary>
    public int BarberId { get; set; }
    
    /// <summary>
    /// The ID of the barbershop where the appointment takes place.
    /// </summary>
    public int BarbershopId { get; set; }
    
    /// <summary>
    /// The Date and Time of the appointment.
    /// </summary>
    public DateTime DateTime { get; set; }
    
    /// <summary>
    /// Navigation property to the barbershop where the appointment takes place.
    /// </summary>
    public Barbershop Barbershop { get; set; }
}