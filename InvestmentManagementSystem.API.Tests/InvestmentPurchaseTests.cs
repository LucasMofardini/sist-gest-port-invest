using Xunit;

namespace InvestmentManagementSystem.API.Tests;

public class InvestmentPurchaseTests(IServiceProvider sc)
{
    private IServiceProvider _sc = sc;

    [Fact]
    public void CreateInvestment()
    {
        // Arrange
        // var dto = new CreateCustomerDTO
        // {
        //     Name = "John Doe",
        //     Balance = 1000.00m,
        //     Email = "john.doe@example.com",
        //     IdentificationNumber = "123456789",
        //     IsActive = true,
        //     PhoneNumber = "555-1234",
        //     PostalCode = "12345"
        // };
        //
        // // Act
        // var customer = _sc.GetService<CustomerService>()?.CreateCustomer(dto);
        //
        // // Assert
        // customer.Should().NotBeNull();
        // customer.Name.Should().Be(dto.Name);
        // customer.Balance.Should().Be(dto.Balance);
        // customer.Email.Should().Be(dto.Email);
        // customer.IdentificationNumber.Should().Be(dto.IdentificationNumber);
        // customer.IsActive.Should().Be(dto.IsActive);
        // customer.PhoneNumber.Should().Be(dto.PhoneNumber);
        // customer.PostalCode.Should().Be(dto.PostalCode);
    }
    
}