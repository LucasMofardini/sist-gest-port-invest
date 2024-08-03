using System.Collections.Generic;
using InvestmentManagementSystem.Application.DTOs;
using InvestmentManagementSystem.Application.DTOs.FinancialProduct;
using InvestmentManagementSystem.Domain.FinancialProduct;
using InvestmentManagementSystem.Domain.Investment;

namespace InvestmentManagementSystem.Application.Interfaces;

public interface  IFinancialProductService
{
    void CreateFinancialProduct(CreateFinancialProductDTO dto);
    void UpdateFinancialProduct(UpdateFinancialProductDTO dto, int id);
    FinancialProduct GetFinancialProductById(int id);
    void DeleteFinancialProductById(int id);
    List<FinancialProduct> GetAllFinancialProduct();
    List<FinancialProduct> GetAllFinancialProductByCategoryId(int categoryId);
}