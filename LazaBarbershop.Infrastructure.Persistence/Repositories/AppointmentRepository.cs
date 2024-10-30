using LazaBarbershop.Core.Domain.Entities;
using LazaBarbershop.Infrastructure.Persistence.Contexts;

namespace LazaBarbershop.Infrastructure.Persistence.Repositories;

public class AppointmentRepository : GenericRepository<Appointment>
{
    public AppointmentRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}