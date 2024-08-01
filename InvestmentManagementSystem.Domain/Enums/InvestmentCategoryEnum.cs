using System.ComponentModel;

namespace InvestmentManagementSystem.Domain.Enums;

public enum InvestmentCategoryEnum
{
    [Description("Ações")]
    Stocks = 0,

    [Description("Fundos Mútuos")]
    MutualFunds = 1,

    [Description("Títulos")]
    Bonds = 2,

    [Description("Certificados de Depósito")]
    CertificatesOfDeposit = 3,
    
    [Description("Fundos Imobiliários")]
    REITs = 4,

    [Description("Fundos Negociados em Bolsa")]
    ETFs = 5,

    [Description("Opções e Derivativos")]
    OptionsAndDerivatives = 6,

    [Description("Criptomoedas")]
    Cryptocurrencies = 7,

    [Description("Fundos de Pensão e Planos de Previdência")]
    PensionFunds = 8,

    [Description("Commodities")]
    Commodities = 9
}