using InvestmentManagementSystem.Application.DTOs;
using InvestmentManagementSystem.Application.DTOs.FinancialProduct;
using InvestmentManagementSystem.Application.Interfaces;
using InvestmentManagementSystem.Domain.Investment;
using InvestmentManagementSystem.Infrastructure.Data;

namespace InvestmentManagementSystem.Application.Services;

public class FinancialProductService(Context context) : IFinancialProductService
{
    public void CreateFinancialProduct(CreateFinancialProductDTO dto)
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

    public void UpdateFinancialProduct(UpdateFinancialProductDTO dto, int id)
    {
        var financialProduct = GetProductById(id);

        financialProduct.CategoryType = dto.CategoryType ?? financialProduct.CategoryType;
        financialProduct.LastUpdatedDate = DateTime.Now;
        financialProduct.Quantity = dto.Quantity ?? financialProduct.Quantity;
        financialProduct.UnitPrice = dto.UnitPrice ?? financialProduct.UnitPrice;
        financialProduct.Description = dto.Description ?? financialProduct.Description;
        financialProduct.Name = dto.Name ?? financialProduct.Name;

        context.SaveChanges();
    }

    public FinancialProduct GetFinancialProductById(int id) =>
        GetProductById(id);

    public List<FinancialProduct> GetAllFinancialProduct()
        => context.FinancialProduct.ToList();   
    public List<FinancialProduct> GetAllFinancialProductByCategoryId (int categoryId)
        => context.FinancialProduct.Where(x => x.CategoryType == categoryId).ToList();

    public void DeleteFinancialProductById(int id)
    {
        var product = GetProductById(id);

        // TODO talvez nao devesse excluir e sim passar o FinancialProduct para inativo.
        // Jutamente com todos os investimentos desse tipo

        context.FinancialProduct.Remove(product);
        context.SaveChanges();
    }

    private FinancialProduct GetProductById(int id)
        => context.FinancialProduct.FirstOrDefault(x =>
               x.FinancialProductId == id)
           ?? throw new KeyNotFoundException($"{id} - Produto financeiro não encontrado");
}