using System.Text;

namespace InvestmentManagementSystem.Domain.Customer;

public class Customer
{
    /// <summary>
    /// Id do Cliente
    /// </summary>
    public int CustomerId { get; set; }
    
    /// <summary>
    /// Nome
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Numero de telefone
    /// </summary>
    public string PhoneNumber { get; set; }
    
    /// <summary>
    /// Numero de identificação
    /// </summary>
    public string IdentificationNumber { get; set; }
    
    /// <summary>
    /// CEP
    /// </summary>
    public string PostalCode { get; set; }
    
    /// <summary>
    /// Email
    /// </summary>
    public string Email { get; set; }
    
    /// <summary>
    /// Saldo
    /// </summary>
    public decimal Balance { get; set; }
    
    /// <summary>
    /// Cliente ativo?
    /// </summary>
    public bool IsActive { get; set; }
}