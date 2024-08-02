using System.ComponentModel.DataAnnotations;
using InvestmentManagementSystem.Domain.Enums;

namespace InvestmentManagementSystem.Application.DTOs.FinancialProduct;

public class CreateFinancialProductDTO
{
    [Required(ErrorMessage = "O Preço Unitário é obrigatário")]
    public decimal UnitPrice { get; set; } 
    
    [Required(ErrorMessage = "A Quantidade é obrigatário")]
    public int Quantity { get; set; } 
    
    [Required(ErrorMessage = "A Descrição é obrigatária")]
    public string Description { get; set; }
    
    [Required(ErrorMessage = "O Nome é obrigatário")]
    public string Name { get; set; }
    
    public int Status { get; set; } = (int) FinancialProductStatusEnum.Inactive;
    
    [Required(ErrorMessage = "O Tipo da Categoria é obrigatária")]
    public int CategoryType { get; set; } 
}