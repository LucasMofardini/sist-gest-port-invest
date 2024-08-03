namespace InvestmentManagementSystem.Domain.FinancialProduct;

public class FinancialProduct
{   
    /// <summary>
    /// Id do Produto Financeiro
    /// </summary>
    public int FinancialProductId { get; set; }
    
    /// <summary>
    /// Valor unitário
    /// </summary>
    public decimal UnitPrice { get; set; }
    
    /// <summary>
    /// Quantidade de papeis
    /// </summary>
    public int Quantity { get; set; } 
    
    /// <summary>
    /// Descrição
    /// </summary>
    public string Description { get; set; }
    
    /// <summary>
    /// Nome do Produto Financeiro
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Data de criação
    /// </summary>
    public DateTime CreatedDate { get; set; } 
    
    /// <summary>
    /// Data da ultima atualização
    /// </summary>
    public DateTime LastUpdatedDate { get; set; } 
    
    /// <summary>
    /// Tipo da Categoria do Produto Financeiro 
    /// </summary>
    public int CategoryType { get; set; }

    /// <summary>
    /// Status do Produto Financeiro
    /// </summary>
    public int Status { get; set; }
}