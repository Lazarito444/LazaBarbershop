using LazaBarbershop.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LazaBarbershop.Infrastructure.Persistence.Configuration;

public class BarbershopConfiguration : IEntityTypeConfiguration<Barbershop>
{
    public void Configure(EntityTypeBuilder<Barbershop> builder)
    {
        builder.ToTable("Barbershops");
        builder.HasKey(barbershop => barbershop.Id);

        builder.HasMany(barbershop => barbershop.Schedules)
            .WithOne(schedule => schedule.Barbershop)
            .HasForeignKey(schedule => schedule.BarbershopId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(barbershop => barbershop.Appointments)
            .WithOne(appointment => appointment.Barbershop)
            .HasForeignKey(appointment => appointment.BarbershopId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}