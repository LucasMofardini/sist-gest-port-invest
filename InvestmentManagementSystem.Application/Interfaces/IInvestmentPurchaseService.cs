using InvestmentManagementSystem.Application.DTOs;
using InvestmentManagementSystem.Application.DTOs.Investment;
using InvestmentManagementSystem.Domain.Investment;

namespace InvestmentManagementSystem.Application.Interfaces;

public interface IInvestmentPurchaseService
{
    void CreateInvestmentPurchase(CreateInvestmentPurchaseDTO dto);
    void UpdateInvestmentPurchase(UpdateInvestmentPurchaseDTO dto, int id);
    Investment GetInvestmentPurchaseById(int id);
    void DeleteInvestmentPurchaseById(int id);
    List<Investment> GetAllInvestmentPurchase();
}