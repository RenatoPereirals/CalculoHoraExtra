using Microsoft.EntityFrameworkCore;
using WorkHourCalculator.Domain;

namespace WorkHourCalculator.Persistence.Context
{
    public class WorkerContext : DbContext
    {
        DbSet<User> Users { get; set; }
        DbSet<Worker> Workers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql
            (
                "Server=localhost;" +
                "Port=5432;Database=WorkHourCalculator;" +
                "User Id=postgres;" +
                "Password=RPS532110nat;"
            );
    }
}
