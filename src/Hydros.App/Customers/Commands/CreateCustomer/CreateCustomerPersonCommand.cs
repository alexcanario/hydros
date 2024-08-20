using MediatR;

namespace Hydros.App.Customers.Commands.CreateCustomer;

public sealed record CreateCustomerPersonCommand(string Name, string Email, string Address, string Identification, string Nim, string PhoneNumber, bool IsOwn) 
    : IRequest<Guid> { }