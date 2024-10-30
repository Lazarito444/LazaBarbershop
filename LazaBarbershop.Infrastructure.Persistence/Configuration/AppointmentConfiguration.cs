using LazaBarbershop.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LazaBarbershop.Infrastructure.Persistence.Configuration;

public class AppointmentConfiguration : IEntityTypeConfiguration<Appointment>
{
    public void Configure(EntityTypeBuilder<Appointment> builder)
    {
        builder.ToTable("Appointemtns");
        builder.HasKey(appointment => appointment.Id);
    }
}