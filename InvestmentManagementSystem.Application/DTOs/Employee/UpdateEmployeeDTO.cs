using System.ComponentModel.DataAnnotations;

namespace InvestmentManagementSystem.Application.DTOs.Employee;

public class UpdateEmployeeDTO
{
    public string? Name { get; set; }
    public string? Email { get; set; }
    public int? Role { get; set; }
    public DateTime? AdmissionDate { get; set; } 
    public decimal? Sallary { get; set; }
}