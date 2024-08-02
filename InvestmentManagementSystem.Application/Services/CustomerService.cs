using System.Runtime.CompilerServices;
using InvestmentManagementSystem.Application.DTOs;
using InvestmentManagementSystem.Application.Interfaces;
using InvestmentManagementSystem.Domain.Customer;
using InvestmentManagementSystem.Infrastructure.Data;

namespace InvestmentManagementSystem.Application.Services;

public class CustomerService(Context context) : ICustomerService
{
    public Customer GetCustomerByCustomerId(int id)
    {
        var customer = GetCustomerById(id);

        if (customer is null)
            throw new KeyNotFoundException($"{id} - Não encontrado");

        return customer;
    }

    public void DeleteCustomerById(int id)
    {
        var customer = GetCustomerById(id);

        if (customer is null)
            throw new KeyNotFoundException($"{id} - Não encontrado");

        context.Customer.Remove(customer);
        context.SaveChanges();
    }

    public List<Customer> GetAllCustomer()
    {
        return context.Customer.ToList();
    }

    public void CreateCustomer(CreateCustomerDTO dto)
    {
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

        if (customer is null)
            throw new KeyNotFoundException($"{id} - Cliente não encontrado");

        customer.Name = dto.Name ?? customer.Name;
        customer.Balance = dto.Balance ?? customer.Balance;
        customer.Email = dto.Email ?? customer.Email;
        customer.IdentificationNumber = dto.IdentificationNumber ?? customer.IdentificationNumber;
        customer.IsActive = dto.IsActive;
        customer.PhoneNumber = dto.PhoneNumber ?? customer.PhoneNumber;
        customer.PostalCode = dto.PostalCode ?? customer.PostalCode;

        context.SaveChanges();
    }

    private Customer? GetCustomerById(int? id)
    {
        return context.Customer.FirstOrDefault(x =>
            x.CustomerId == id);
    }
}