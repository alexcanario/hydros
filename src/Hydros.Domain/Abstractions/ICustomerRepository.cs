using Hydros.Domain.Entities.Customers;

namespace Hydros.Domain.Abstractions;

public interface ICustomerRepository
{
    void Create(Customer  customer);
}