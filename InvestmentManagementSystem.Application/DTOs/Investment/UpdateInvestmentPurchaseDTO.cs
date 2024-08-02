namespace InvestmentManagementSystem.Application.DTOs.Investment;

public class UpdateInvestmentPurchaseDTO
{
    public bool? IsActive { get; set; } 
    public DateTime? MaturityDate { get; set; }
}