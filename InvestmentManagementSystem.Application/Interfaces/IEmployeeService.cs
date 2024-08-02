using InvestmentManagementSystem.Application.DTOs.Employee;
using InvestmentManagementSystem.Domain.Employee;

namespace InvestmentManagementSystem.Application.Interfaces;

public interface IEmployeeService
{
    void CreateEmployee(CreateEmployeeDTO dto);
    void UpdateEmployee(UpdateEmployeeDTO dto, int id);
    Employee GetEmployeeById(int id);
    void DeleteEmployeeById(int id);
    List<Employee> GetAllEmployees();
}