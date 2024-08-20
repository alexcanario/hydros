using AutoMapper;

using Hydros.Domain.Abstractions;

using MediatR;

namespace Hydros.App.Customers.Queries.GetCustomerById;

public sealed class GetCustomerByIdQueryHandler(ICustomerRepository customerRepository, IMapper mapper) 
    : IRequestHandler<GetCustomerByIdQuery, CustomerResponse>
{
    public async Task<CustomerResponse> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
    {
        return mapper.Map<CustomerResponse>(await customerRepository.GetByIdAsync(request.CustomerId));
    }
}