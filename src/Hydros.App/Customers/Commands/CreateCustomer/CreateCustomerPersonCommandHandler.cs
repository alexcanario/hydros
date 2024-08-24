using Hydros.Domain.Abstractions;
using Hydros.Domain.Entities.Customers;

using MediatR;

namespace Hydros.App.Customers.Commands.CreateCustomer;

public sealed class CreateCustomerPersonCommandHandler(ICustomerRepository customerRepository, IUnitOfWork unitOfWork)
    : IRequestHandler<CreateCustomerPersonCommand, Guid>
{
    public async Task<Guid> Handle(CreateCustomerPersonCommand request, CancellationToken cancellationToken)
    {
        var customer = new Customer(
            Guid.NewGuid()
            , request.Name
            , request.Email
            , CustomerType.Person
            , request.Identification
            , request.Nim
            , string.Empty
            , request.PhoneNumber
            , request.PhoneNumberBackup
            , request.IsOwn);

        customerRepository.Create(customer);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return customer.Id;
    }
}