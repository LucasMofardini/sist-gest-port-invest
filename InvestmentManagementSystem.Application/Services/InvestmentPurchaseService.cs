using InvestmentManagementSystem.Application.DTOs;
using InvestmentManagementSystem.Application.DTOs.Investment;
using InvestmentManagementSystem.Application.Interfaces;
using InvestmentManagementSystem.Domain.Enums;
using InvestmentManagementSystem.Domain.Investment;
using InvestmentManagementSystem.Infrastructure.Data;

namespace InvestmentManagementSystem.Application.Services;

public class InvestmentPurchaseService(
    Context context,
    ICustomerService customerService,
    IFinancialProductService financialProductService) : IInvestmentPurchaseService
{
    public Investment GetInvestmentPurchaseById(int id)
    {
        var investment = GetInvestmentById(id);

        if (investment is null)
            throw new KeyNotFoundException($"{id} - Não encontrado");

        return investment;    
    }

    public void CreateInvestmentPurchase(CreateInvestmentPurchaseDTO dto)
    {
        var customer = customerService.GetCustomerByCustomerId(dto.CustomerId);

        if (!customer.IsActive)
            throw new UnauthorizedAccessException($"Usuário {customer.CustomerId} está inativo");

        var product = financialProductService.GetFinancialProductById(dto.FinancialProductId);

        if (product.Status != (int) FinancialProductStatusEnum.Active)
            throw new UnauthorizedAccessException($"Produto {product.FinancialProductId} está inativo");
        
        if (dto.Quantity > product.Quantity)
            throw new ArgumentOutOfRangeException("Quantidade não permitida");

        var amoutPrice = dto.Quantity * product.UnitPrice;

        if (amoutPrice > customer.Balance)
            throw new ArgumentOutOfRangeException("Saldo inválido");
        
        var investment = new Investment()
        {
            CustomerId = customer.CustomerId,
            FinancialProductId = product.FinancialProductId,
            Quantity = dto.Quantity,
            ProductUnitPrice = product.UnitPrice,
            IsActive = true,
            MaturityDate = GenerateRandomDate(DateTime.Now, DateTime.Now.AddDays(365)),
            ProductAmountPrice = amoutPrice
        };

        context.InvestmentPurchase.Add(investment);
        
        product.Quantity -= dto.Quantity;

        customer.Balance -= amoutPrice;
            
        context.SaveChanges();
    }

    public void UpdateInvestmentPurchase(UpdateInvestmentPurchaseDTO dto, int id)
    {
        var investment = GetInvestmentById(id);

        if (investment is null)
            throw new KeyNotFoundException($"{id} - Cliente não encontrado");
        
        
        
        context.SaveChanges();
    }
    
    public void DeleteInvestmentPurchaseById(int id)
    {
        var investment = GetInvestmentById(id);

        if (investment is null)
            throw new KeyNotFoundException($"{id} - Não encontrado");

        context.InvestmentPurchase.Remove(investment);
        context.SaveChanges();
    }

    public List<Investment> GetAllInvestmentPurchase()
    {
        return context.InvestmentPurchase.ToList();
    }
    
    private Investment? GetInvestmentById(int? id)
    {
        return context.InvestmentPurchase.FirstOrDefault(x =>
            x.InvestmentId == id);
    }
    
    private static DateTime GenerateRandomDate(DateTime startDate, DateTime endDate)
    {
        Random random = new Random();
        int range = (endDate - startDate).Days;
        return startDate.AddDays(random.Next(range));
    }
}