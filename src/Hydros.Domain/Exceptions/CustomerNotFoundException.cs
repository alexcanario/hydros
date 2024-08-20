using Hydros.Domain.Exceptions.Base;

namespace Hydros.Domain.Exceptions;

public sealed class CustomerNotFoundException(Guid customerId) : 
    NotFoundException($"The webinar with the identifier {customerId} was not found.") { }