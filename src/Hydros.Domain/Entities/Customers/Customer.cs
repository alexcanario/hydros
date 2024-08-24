namespace Hydros.Domain.Entities.Customers;

public sealed class Customer : Entity
{
    public Customer(Guid id, string name, string email, CustomerType customerType, string identification, string nim, string taxPayerId, string phoneNumber, string? phoneNumberBackup, bool isOwn)
    {
        Id = id;
        Name = name;
        Email = email;
        CustomerType = customerType;
        Identification = identification;
        TaxPayerId = taxPayerId;
        PhoneNumber = phoneNumber;
        PhoneNumberBackup = phoneNumberBackup;
        Nim = nim;
        IsOwn = isOwn;
    }

    public string Name { get; private set; }
    public string Email { get; private set; }
    public CustomerType CustomerType { get; private set; }

    /// <summary>
    /// Personal Identification for persons
    /// </summary>
    public string Identification { get; private set; }

    /// <summary>
    /// National InsuranceNumber
    /// </summary>
    public string Nim { get; private set; }

    /// <summary>
    /// Company identification
    /// </summary>
    public string TaxPayerId { get; private set; }
    public string PhoneNumber { get; private set; }
    public string? PhoneNumberBackup { get; private set; }
    public bool IsOwn { get; private set; }
}