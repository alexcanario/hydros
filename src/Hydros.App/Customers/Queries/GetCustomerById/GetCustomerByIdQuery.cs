using MediatR;

namespace Hydros.App.Customers.Queries.GetCustomerById;

public sealed record GetCustomerByIdQuery(Guid CustomerId) : IRequest<CustomerResponse>;