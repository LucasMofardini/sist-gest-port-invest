using InvestmentManagementSystem.Application.DTOs.Employee;
using InvestmentManagementSystem.Application.Interfaces;
using InvestmentManagementSystem.Domain.Employee;
using InvestmentManagementSystem.Infrastructure.Data;

namespace InvestmentManagementSystem.Application.Services;

public class EmployeeService(Context context) : IEmployeeService
{
    public void CreateEmployee(CreateEmployeeDTO dto)
    {
        var employee = new Employee()
        {
            Name = dto.Name,
            Sallary = dto.Sallary,
            Email = dto.Email,
            Role = dto.Role,
            AdmissionDate = dto.AdmissionDate ?? DateTime.Now
        };

        context.Employee.Add(employee);
        context.SaveChanges();
    }

    public void UpdateEmployee(UpdateEmployeeDTO dto, int id)
    {
        var employee = GetEmployeeByEmployeeId(id);

        employee.Name = dto.Name ?? employee.Email;
        employee.Email = dto.Email ?? employee.Email;
        employee.Role = dto.Role ?? employee.Role;
        employee.AdmissionDate = dto.AdmissionDate ?? employee.AdmissionDate;
        employee.Sallary = dto.Sallary ?? employee.Sallary;

        context.SaveChanges();
    }

    public Employee GetEmployeeById(int id) =>
        GetEmployeeByEmployeeId(id);

    public void DeleteEmployeeById(int id)
    {
        //@TODO Quando um funcionario é deletado, o que fazer com os investimentos atrelados a ele? colocar como inativo?
        var employee = GetEmployeeByEmployeeId(id);

        context.Employee.Remove(employee);
        context.SaveChanges();    }

    public List<Employee> GetAllEmployees() =>
        context.Employee.ToList();
    
    private Employee GetEmployeeByEmployeeId(int id) =>
        context.Employee.FirstOrDefault(x =>
            x.EmployeeId == id)
        ?? throw new KeyNotFoundException($"{id} - Funcionário não encontrado");
}