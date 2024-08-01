using InvestmentManagementSystem.Domain.Enums;

namespace InvestmentManagementSystem.Domain.Investment;

public class Investment
{
    /// <summary>
    /// Id do Investimento
    /// </summary>
    public int InvestmentId { get; set; }
    
    /// <summary>
    /// Id do Produto Financeiro
    /// </summary>
    public int FinancialProductId { get; set; }
    
    /// <summary>
    /// Id do Cliente
    /// </summary>
    public int CustomerId { get; set; }

    /// <summary>
    /// Quantidade de papéis comprados
    /// </summary>
    public int Quantity  { get; set; }
    
    /// <summary>
    /// Preço unitário do produto financeiro
    /// </summary>
    public decimal ProductUnitPrice  { get; set; }
    
    /// <summary>
    /// Preço montante do produto financeiro
    /// </summary>
    public decimal ProductAmountPrice  { get; set; }
    
    /// <summary>
    /// Investimento ativo?
    /// </summary>
    public bool IsActive { get; set; } 
    
    /// <summary>
    /// Data de vencimento do investimento
    /// </summary>
    public DateTime MaturityDate { get; set; }
}