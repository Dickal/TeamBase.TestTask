namespace TeamBase.TestTask.ProrateMethods;

public class ProrateByDays : IProrateMethod
{
    public double CalculateProratedPremium(double fullPremium, DateTime joinDate, DateTime policyEndDate)
    {
        if (policyEndDate < joinDate)
            throw new ArgumentException($"{nameof(joinDate)} must be greater than {policyEndDate}");
        var remainingDays = (int)Math.Ceiling((policyEndDate - joinDate).TotalDays);
        return fullPremium / 365 * remainingDays;
    }
}