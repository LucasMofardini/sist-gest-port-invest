namespace InvestmentManagementSystem.Application.DTOs.FinancialProduct;

public class UpdateFinancialProductDTO
{
    public decimal? UnitPrice { get; set; } 
    public int? Quantity { get; set; } 
    public string? Description { get; set; }
    public string? Name { get; set; }
    public int? Status { get; set; }
    public int? CategoryType { get; set; } 
}