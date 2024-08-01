using System.ComponentModel;

namespace InvestmentManagementSystem.Domain.Enums;

public enum FinancialProductStatusEnum
{
    [Description("Inativo")]
    Inactive = 0,
    
    [Description("Ativo")]
    Active = 1
}