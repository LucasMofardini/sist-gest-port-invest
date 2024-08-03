namespace InvestmentManagementSystem.Utils.Utilities;

public static class DateUtils
{
    public static DateTime GenerateRandomDate(DateTime startDate, DateTime endDate)
    {
        Random random = new Random();
        int range = (endDate - startDate).Days;
        return startDate.AddDays(random.Next(range));
    }
}