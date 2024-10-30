using Microsoft.AspNetCore.Identity;

namespace LazaBarbershop.Infrastructure.Persistence.Entities;

public class AppUser : IdentityUser<int>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string ImagePath { get; set; }
}