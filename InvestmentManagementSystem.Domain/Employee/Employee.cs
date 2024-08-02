namespace InvestmentManagementSystem.Domain.Employee;

public class Employee
{
    /// <summary>
    /// Id do Funcionario
    /// </summary>
    public int EmployeeId { get; set; }

    /// <summary>
    /// Nome
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Email
    /// </summary>
    public string Email { get; set; }
    
    /// <summary>
    /// Cargo
    /// </summary>
    public int Role { get; set; }

    /// <summary>
    /// Data de admissão
    /// </summary>
    public DateTime AdmissionDate { get; set; }

    /// <summary>
    /// Salário
    /// </summary>
    public decimal Sallary { get; set; }
}