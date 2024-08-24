using Hydros.Domain.Entities.Customers;

using Microsoft.EntityFrameworkCore;

namespace Hydros.Infra.Data.Seed;

public static class CustomerData 
{
    public static void Sow(ModelBuilder modelBuilder)
    {
        
        var customer = new Customer(
            Guid.Parse("768f581d-95cb-4f15-a3dc-0005ee296b47")
            , "André Luiz da Silva Lima"
            , "andreluizlima.adv@hotmail.com"
            , CustomerType.Person
            , "660152860"
            , "92635377553"
            , string.Empty
            , "73988167515"
            , string.Empty
            , true);

        modelBuilder.Entity<Customer>().HasData(customer);
    }
}