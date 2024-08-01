using System.ComponentModel;

namespace InvestmentManagementSystem.Domain.Enums;

public enum FinancialProductStatusEnum
{
    [Description("Ativo")]
    Active,
    
    [Description("Inativo")]
    Inactive
}