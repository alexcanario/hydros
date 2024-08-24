using MediatR;

namespace Hydros.App.Customers.Commands.CreateCustomer;

public sealed record CreateCustomerCompanyCommand(string Name, string Email, string Address, string TaxPayerId, string PhoneNumber, string PhoneNumberBackup, bool IsOwn)
    : IRequest<Guid>;