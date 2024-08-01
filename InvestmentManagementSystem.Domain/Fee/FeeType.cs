namespace InvestmentManagementSystem.Domain.Investment;

public enum FeeType
{
    BrokerageFee, // Taxa de Corretagem
    ManagementFee, // Taxa de Administração
    LoadFee, // Taxa de Carregamento
    EarlyWithdrawalFee, // Taxa de Resgate Antecipado
    REITManagementFee, // Taxa de Administração de REIT
    ETFTradingFee, // Taxa de Negociação de ETFs
    DerivativesTradingFee, // Taxa de Negociação de Derivativos
    CryptocurrencyTransactionFee, // Taxa de Transação de Criptomoeda
    PensionFundManagementFee, // Taxa de Administração de Fundos de Pensão
    CommodityStorageFee // Taxa de Armazenagem de Commodities
}