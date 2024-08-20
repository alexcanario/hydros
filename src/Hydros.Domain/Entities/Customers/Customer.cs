namespace Hydros.Domain.Entities.Customers;

public sealed class Customer(
    Guid id, string name, string email, string address, 
    CustomerType customerType, string identification, 
    string nim, string taxPayerId, string phoneNumber, 
    bool isOwn) : Entity(id)
{
    public string Name { get; private set; } = name;
    public string Email { get; private set; } = email;
    public string Address { get; private set; } = address;
    public CustomerType CustomerType { get; set; } = customerType;
    public string Identification { get; private set; } = identification;
    public string NationalInsuranceNumber { get; private set; } = nim;
    public string TaxPayerId { get; set; } = taxPayerId;
    public string PhoneNumber { get; private set; } = phoneNumber;
    public bool IsOwn { get; set; } = isOwn;
}