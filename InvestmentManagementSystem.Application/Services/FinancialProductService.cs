using InvestmentManagementSystem.Application.DTOs;
using InvestmentManagementSystem.Application.Interfaces;
using InvestmentManagementSystem.Domain.Investment;
using InvestmentManagementSystem.Infrastructure.Data;

namespace InvestmentManagementSystem.Application.Services;

public class FinancialProductService(Context context) : IFinancialProductService
{
    public void CreateOrUpdateFinancialProduct(FinancialProductDTO dto, int? financialProductId = null)
    {
        if (financialProductId is not null)
        {
            UpdateFinancialProduct(dto, financialProductId);
            return;
        }

        CreateFinancialProduct(dto);
    }

    public FinancialProduct GetFinancialProductById(int financialProductId)
    {
        var product = GetProductById(financialProductId);

        if (product is null)
            throw new KeyNotFoundException($"{financialProductId} - Não encontrado");

        return product;
    }

    public void DeleteFinancialProductById(int financialProductId)
    {
        var product = GetProductById(financialProductId);

        if (product is null)
            throw new KeyNotFoundException($"{financialProductId} - Não encontrado");

        context.FinancialProduct.Remove(product);
        context.SaveChanges();
    }

    private void CreateFinancialProduct(FinancialProductDTO dto)
    {
        var product = new FinancialProduct
        {
            Description = dto.Description,
            Name = dto.Name,
            CreatedDate = DateTime.Now,
            LastUpdatedDate = DateTime.Now,
            Quantity = dto.Quantity,
            UnitPrice = dto.UnitPrice,
            CategoryType = dto.CategoryType,
            Status = dto.Status
        };

        context.FinancialProduct.Add(product);
        context.SaveChanges();
    }

    private void UpdateFinancialProduct(FinancialProductDTO dto, int? financialProductId)
    {
        var financialProduct = GetProductById(financialProductId);

        if (financialProduct is null)
            throw new KeyNotFoundException($"{financialProductId} - Produto financeiro não encontrado");

        financialProduct.FinancialProductId = financialProductId.GetValueOrDefault();
        financialProduct.CategoryType = dto.CategoryType;
        financialProduct.LastUpdatedDate = DateTime.Now;
        financialProduct.Quantity = dto.Quantity;
        financialProduct.UnitPrice = dto.UnitPrice;
        financialProduct.Description = dto.Description;
        financialProduct.Name = dto.Name;

        context.SaveChanges();
    }
    
    public List<FinancialProduct> GetAllFinancialProduct()
    {
        return context.FinancialProduct.ToList();
    }
    
    private FinancialProduct? GetProductById(int? financialProductId)
    {
        return context.FinancialProduct.FirstOrDefault(x =>
            x.FinancialProductId == financialProductId);
    }
}
