using Hydros.Domain.Entities.Customers;

namespace Hydros.App.Customers.Queries.GetCustomerById;

public sealed record CustomerResponse(
    Guid Id
    , string Name
    , string Email
    , string Address
    , CustomerType CustomerType
    , string Identification
    , string Nim
    , string TaxPayerId
    , string PhoneNumber
    , bool IsOwn
);