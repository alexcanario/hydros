using Hydros.Domain.Entities.Customers;
using Hydros.Infra.Data.Extensions;

using Microsoft.EntityFrameworkCore;

namespace Hydros.Infra.Data.Context;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Customer> Customers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        modelBuilder.Sow();

        base.OnModelCreating(modelBuilder);
    }
}