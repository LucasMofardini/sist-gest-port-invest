using System.ComponentModel.DataAnnotations;

namespace InvestmentManagementSystem.Application.DTOs.Employee;

public class CreateEmployeeDTO
{
    [Required(ErrorMessage = "O Nome é obrigatório")]
    public string Name { get; set; }

    [Required]
    [MaxLength(65, ErrorMessage = "O Email deve ter até 65 caracteres")]
    public string Email { get; set; }
    
    [Required(ErrorMessage = "O Cargo é obrigatório")]
    public int Role { get; set; }
    
    public DateTime? AdmissionDate { get; set; } 
    
    [Required(ErrorMessage = "O Salário é obrigatório")]
    public decimal Sallary { get; set; }
}