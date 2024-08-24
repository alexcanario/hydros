using Hydros.Infra.Data.Seed;

using Microsoft.EntityFrameworkCore;

namespace Hydros.Infra.Data.Extensions;

public static class ModelBuilderExtensions
{
    public static void Sow(this ModelBuilder modelBuilder)
    {
        CustomerData.Sow(modelBuilder);
    }
}