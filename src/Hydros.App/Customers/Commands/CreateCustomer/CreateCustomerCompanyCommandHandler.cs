using Hydros.Domain.Abstractions;
using Hydros.Domain.Entities.Customers;

using MediatR;

namespace Hydros.App.Customers.Commands.CreateCustomer;

internal sealed class CreateCustomerCompanyCommandHandler(ICustomerRepository customerRepository, IUnitOfWork unitOfWork)
    : IRequestHandler<CreateCustomerCompanyCommand, Guid>
{
    public async Task<Guid> Handle(CreateCustomerCompanyCommand request, CancellationToken cancellationToken)
    {
        var customer = new Customer(
            Guid.NewGuid()
            , request.Name
            , request.Email
            , CustomerType.Company
            , string.Empty
            , string.Empty
            , request.TaxPayerId
            , request.PhoneNumber
            , request.PhoneNumberBackup
            , request.IsOwn);

        customerRepository.Create(customer);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return customer.Id;
    }
}