namespace InvestmentManagementSystem.Application.DTOs.Customer;

public class UpdateCustomerDTO
{
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public string IdentificationNumber { get; set; }
    public string PostalCode { get; set; }
    public string Email { get; set; }
    public decimal? Balance { get; set; }
    public bool IsActive { get; set; }
}