using System.Collections.Generic;
using InvestmentManagementSystem.Application.DTOs;
using InvestmentManagementSystem.Domain.Investment;

namespace InvestmentManagementSystem.Application.Interfaces;

public interface  IFinancialProductService
{
    void CreateOrUpdateFinancialProduct(FinancialProductDTO dto, int? financialProductId = null);
    FinancialProduct GetFinancialProductById(int financialProductId);
    void DeleteFinancialProductById(int financialProductId);
    List<FinancialProduct> GetAllFinancialProduct();
}