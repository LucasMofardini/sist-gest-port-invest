using System.ComponentModel.DataAnnotations;

namespace InvestmentManagementSystem.Application.DTOs;

public class CreateCustomerDTO
{
    [Required(ErrorMessage = "O Nome é obrigatório")]
    public string Name { get; set; }
    
    [MaxLength(14, ErrorMessage = "O Número de Telefone deve ter até 14 caracteres")]
    public string PhoneNumber { get; set; }
    
    [MaxLength(14, ErrorMessage = "O CPF/CNPJ deve ter até 14 caracteres")]
    [Required]
    public string IdentificationNumber { get; set; }
    
    [MaxLength(8, ErrorMessage = "O CEP deve ter até 8 caracteres")]
    public string PostalCode { get; set; }
    
    [MaxLength(65, ErrorMessage = "O Email deve ter até 65 caracteres")]
    public string Email { get; set; }
    
    [Required(ErrorMessage = "O Saldo é obrigatório")]
    public decimal Balance { get; set; }
    public bool IsActive { get; set; }
}