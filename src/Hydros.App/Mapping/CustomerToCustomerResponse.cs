using AutoMapper;

using Hydros.App.Customers.Queries.GetCustomerById;
using Hydros.Domain.Entities.Customers;

namespace Hydros.App.Mapping;

public class CustomerToCustomerResponse : Profile
{
    public CustomerToCustomerResponse()
    {
        CreateMap<Customer, CustomerResponse>().ReverseMap();
    }
}