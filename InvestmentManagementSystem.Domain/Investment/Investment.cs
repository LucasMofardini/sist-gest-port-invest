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
    /// Status do produto financeiro
    /// </summary>
    public FinancialProductStatusEnum Status { get; set; } 
    
    /// <summary>
    /// Tipo da categoria do produto financeiro
    /// </summary>
    public InvestmentCategoryEnum CategoryType { get; set; } 
    
    /// <summary>
    /// Id Usuário de criação do produto financeiro
    /// </summary>
    public int CreatedBy { get; set; } 
    
    /// <summary>
    /// Data de vencimento do produto financeiro
    /// </summary>
    public DateTime MaturityDate { get; set; }
}