using LazaBarbershop.Infrastructure.Persistence.Configuration;
using LazaBarbershop.Infrastructure.Persistence.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LazaBarbershop.Infrastructure.Persistence.Contexts;

public class AppDbContext : IdentityDbContext<AppUser, IdentityRole<int>, int>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        
        // Applying the configuration files
        builder.ApplyConfiguration(new AppointmentConfiguration());
        builder.ApplyConfiguration(new BarbershopConfiguration());
        builder.ApplyConfiguration(new ScheduleConfiguration());
    }
}
