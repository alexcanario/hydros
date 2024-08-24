using Hydros.Domain.Entities.Customers;

namespace Hydros.Domain.UnitTest;

public class CustomerUnitTest
{
    [Fact]
    public void Create_CustomerPerson_ReturnNotNull()
    {
        var customer = new Customer(
            Guid.NewGuid()
            , "Alex Canario"
            ,"alexcanario@gmail.com"
            , CustomerType.Person
            , "0513017682"
            , "73120162515"
            , string.Empty
            , "75999731296"
            , null
            ,true);

        Assert.NotNull(customer);
    }

    [Fact]
    public void Create_CustomerCompany_ReturnNotNull()
    {
        var customer = new Customer(
            Guid.NewGuid()
            , "iControl"
            , "icontrol@gmail.com"
            , CustomerType.Person
            , string.Empty
            , string.Empty
            , "03648873000101"
            , "75999731296"
            , null
            , true);

        Assert.NotNull(customer);
    }

}