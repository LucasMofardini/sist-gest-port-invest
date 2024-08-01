using InvestmentManagementSystem.Domain.Enums;

namespace InvestmentManagementSystem.Application.DTOs;

public class FinancialProductDTO
{
    public decimal UnitPrice { get; set; } 
    public int Quantity { get; set; } 
    public string Description { get; set; }
    public string Name { get; set; }
    public int Status { get; set; } = (int)FinancialProductStatusEnum.Inactive;
    public int CategoryType { get; set; } 
}