using InvestmentManagementSystem.Application.DTOs;
using InvestmentManagementSystem.Application.DTOs.Customer;
using InvestmentManagementSystem.Domain.Customer;
using InvestmentManagementSystem.Domain.Investment;

namespace InvestmentManagementSystem.Application.Interfaces;

public interface ICustomerService
{
    void CreateCustomer(CreateCustomerDTO dto);
    void UpdateCustomer(UpdateCustomerDTO dto, int id);
    Customer GetCustomerByCustomerId(int id);
    void DeleteCustomerById(int id);
    List<Customer> GetAllCustomer();
}