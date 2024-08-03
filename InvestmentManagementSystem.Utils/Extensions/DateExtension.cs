namespace InvestmentManagementSystem.Utils.Extensions;

public static class DateExtension
{
    public static DateTime GenerateRandomDate(this DateTime endDate)
    {
        var startDate = DateTime.Now;
        
        Random random = new Random();
        int range = (endDate - startDate).Days;
        return startDate.AddDays(random.Next(range));
    }
}