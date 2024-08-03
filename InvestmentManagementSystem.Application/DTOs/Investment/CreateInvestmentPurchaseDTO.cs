using System.ComponentModel.DataAnnotations;

namespace InvestmentManagementSystem.Application.DTOs.Investment;

public class CreateInvestmentPurchaseDTO
{
    [Required(ErrorMessage = "O Id do Produto Financeiro é obrigatório")]
    public int FinancialProductId { get; set; }
    
    [Required(ErrorMessage = "O Id do Cliente é obrigatório")]
    public int CustomerId { get; set; }
        
    [Required(ErrorMessage = "O Id do Funcionário é obrigatório")]
    public int EmployeeId { get; set; }
    
    [Required(ErrorMessage = "A Quantidade é obrigatório")]
    public int Quantity  { get; set; }
}