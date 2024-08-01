using InvestmentManagementSystem.Application.DTOs;
using InvestmentManagementSystem.Application.DTOs.Investment;
using InvestmentManagementSystem.Application.Interfaces;
using InvestmentManagementSystem.Domain.Investment;
using InvestmentManagementSystem.Infrastructure.Data;

namespace InvestmentManagementSystem.Application.Services;

public class InvestmentPurchaseService(Context context) : IInvestmentPurchaseService
{
    public void CreateInvestmentPurchase(CreateInvestmentPurchaseDTO dto)
    {
        throw new NotImplementedException();
    }

    public void UpdateInvestmentPurchase(UpdateInvestmentPurchaseDTO dto, int id)
    {
        throw new NotImplementedException();
    }

    public Investment GetInvestmentPurchaseById(int id)
    {
        throw new NotImplementedException();
    }

    public void DeleteInvestmentPurchaseById(int id)
    {
        throw new NotImplementedException();
    }

    public List<Investment> GetAllInvestmentPurchase()
    {
        throw new NotImplementedException();
    }
}