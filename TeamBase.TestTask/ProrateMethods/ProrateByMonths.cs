namespace TeamBase.TestTask.ProrateMethods;

public class ProrateByMonths : IProrateMethod
{
    public double CalculateProratedPremium(double fullPremium, DateTime joinDate, DateTime policyEndDate)
    {
        if (policyEndDate < joinDate)
            throw new ArgumentException($"{nameof(joinDate)} must be greater than {policyEndDate}");
        var remainingMonths = (policyEndDate.Year - joinDate.Year) * 12 + (policyEndDate.Month - joinDate.Month) + 1;
        return fullPremium / 12 * remainingMonths;
    }
}