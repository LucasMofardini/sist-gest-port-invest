using InvestmentManagementSystem.Application.Interfaces;
using InvestmentManagementSystem.Domain.Investment;
using InvestmentManagementSystem.Infrastructure.Data;

namespace InvestmentManagementSystem.Application.Services;

public class ExpirationInvestmentService(
    Context context,
    IInvestmentPurchaseService investmentPurchaseService) : IExpirationInvestmentService
{
    public List<Investment> TriggerExpirationInvestments(int nextDays)
    {
        var investments = investmentPurchaseService.GetAllInvestmentPurchase();

        var filteredInvestments = 
            investments.Where(x => x.MaturityDate <= DateTime.Now.AddDays(nextDays)).ToList();
        
        return filteredInvestments;
    }
}