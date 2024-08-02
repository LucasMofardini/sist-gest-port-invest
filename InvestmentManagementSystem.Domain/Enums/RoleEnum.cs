using System.ComponentModel;

namespace InvestmentManagementSystem.Domain.Enums;

public enum RoleEnum
{
    [Description("Analista Financeiro")]
    FinancialAnalyst = 0,

    [Description("Gerente de Investimentos")]
    InvestmentManager = 1,

    [Description("Consultor de Investimentos")]
    InvestmentConsultant = 2,

    [Description("Diretor Financeiro")]
    ChiefFinancialOfficer = 3
}

// @TODO se possivel adicionar as permissoes nos cargos para futuramente permitir ou
// não a criação, atualizaçao etc 

public class Permission
{
    public List<int> FinancialAnalyst { get; set; }
    public List<int> InvestmentManager { get; set; }
    public List<int> InvestmentConsultant { get; set; }
    public List<int> ChiefFinancialOfficer { get; set; }

    public Permission()
    {
        FinancialAnalyst = new List<int> { 1 }; // Exemplo de permissões
        InvestmentManager = new List<int> { 4 };
        InvestmentConsultant = new List<int> {  9 };
        ChiefFinancialOfficer = new List<int> { 15 };
    }
}
