namespace InvestmentManagementSystem.Domain.Investment;

public class FeeInvestment
{
    /// <summary>
    ///  Id da taxa
    /// </summary>
    public int FeeId { get; set; }

    /// <summary>
    /// Id do investimento
    /// </summary>
    public int InvestmentId { get; set; }
    
    /// <summary>
    ///  Nome da taxa
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Tipo da taxa
    /// </summary>
    public FeeType FeeType { get; set; }
    
    /// <summary>
    /// Valor da taxa
    /// </summary>
    public decimal Value { get; set; }
}