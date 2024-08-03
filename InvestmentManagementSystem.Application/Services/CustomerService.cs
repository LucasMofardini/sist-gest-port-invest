using InvestmentManagementSystem.Application.DTOs.Customer;
using InvestmentManagementSystem.Application.Interfaces;
using InvestmentManagementSystem.Application.Validations;
using InvestmentManagementSystem.Domain.Customer;
using InvestmentManagementSystem.Domain.Investment;
using InvestmentManagementSystem.Infrastructure.Data;
using InvestmentManagementSystem.Utils.Utilities;

namespace InvestmentManagementSystem.Application.Services;

public class CustomerService(Context context) : ICustomerService
{
    public void CreateCustomer(CreateCustomerDTO dto)
    {
        var validation = new CreateCustomerDTOValidator().Validate(dto);

        if (!validation.IsValid)
            throw new Exception(string.Join(", ", validation.Errors));
                
        var customer = new Customer()
        {
            Name = dto.Name,
            Balance = dto.Balance,
            Email = dto.Email,
            IdentificationNumber = dto.IdentificationNumber,
            IsActive = dto.IsActive,
            PhoneNumber = dto.PhoneNumber,
            PostalCode = dto.PostalCode
        };

        context.Customer.Add(customer);
        context.SaveChanges();
    }

    public void UpdateCustomer(UpdateCustomerDTO dto, int id)
    {
        var customer = GetCustomerById(id);

        customer.Name = StringUtils.CompareStr(dto.Name,customer.Name);
        customer.Balance = dto.Balance ?? customer.Balance;
        customer.Email = StringUtils.CompareStr(dto.Email, customer.Email);
        customer.IdentificationNumber = StringUtils.CompareStr(dto.IdentificationNumber, customer.IdentificationNumber);
        customer.PhoneNumber = StringUtils.CompareStr(dto.PhoneNumber, customer.PhoneNumber);
        customer.PostalCode = StringUtils.CompareStr(dto.PostalCode, customer.PostalCode);
        customer.IsActive = dto.IsActive;

        context.SaveChanges();
    }
    
    public List<Customer> GetAllCustomer()
        => context.Customer.ToList();
    
    public Customer GetCustomerByCustomerId(int id) =>
        GetCustomerById(id);
    
    public void DeleteCustomerById(int id)
    {
        var customer = GetCustomerById(id);

        var investments = GetAllInvestmentsByCustomerId(customer.CustomerId);
        
        // Desativando todos os investimentos do cliente.
        if(investments.Count != 0)
            investments.ForEach(investment => investment.IsActive = false);

        context.Customer.Remove(customer);
        context.SaveChanges();
    }

    private Customer GetCustomerById(int? id) =>
        context.Customer.FirstOrDefault(x =>
            x.CustomerId == id)
        ?? throw new KeyNotFoundException($"{id} - Cliente não encontrado");
    
    private List<Investment> GetAllInvestmentsByCustomerId(int id) =>
        context.InvestmentPurchase.Where(x => x.CustomerId == id).ToList();
}