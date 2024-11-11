using System.ComponentModel.DataAnnotations;

namespace LazaBarbershop.Core.Application.Dtos.Barbershops;

/// <summary>
/// The DTO used for creating barbershops.
/// </summary>
public class SaveBarbershopDto
{
    /// <summary>
    /// The name of the barbershop.
    /// </summary>
    [Required(ErrorMessage = "Name property is required")]
    [DataType(DataType.Text)]
    [MinLength(2, ErrorMessage = "Name property must be at least two characters long")]
    [MaxLength(32, ErrorMessage = "Length of name's property must not exceed 32 characters")]
    public string Name { get; set; }
    
    /// <summary>
    /// The address of the barbershop.
    /// </summary>
    [Required(ErrorMessage = "Address property is required")]
    [DataType(DataType.Text)]
    [MinLength(8, ErrorMessage = "Address property must be at least 8 characters long")]
    [MaxLength(80, ErrorMessage = "Length of name's property must not exceed 80 characters")]
    public string Address { get; set; }
    
    /// <summary>
    /// The ID of the owner of the barbershop.
    /// </summary>
    [Required(ErrorMessage = "Owner ID was not provided.")]
    public int OwnerId { get; set; }
}