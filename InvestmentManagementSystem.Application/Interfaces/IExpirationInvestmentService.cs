using InvestmentManagementSystem.Domain.Investment;

namespace InvestmentManagementSystem.Application.Interfaces;

public interface IExpirationInvestmentService
{
    List<Investment> TriggerExpirationInvestments(int nextDays);
}