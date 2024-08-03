using InvestmentManagementSystem.Utils.Extensions;

namespace InvestmentManagementSystem.Utils.Utilities;

public static class StringUtils
{
    public static string CompareStr(string a, string b)
        => a.HasValue() ? a : b;
}