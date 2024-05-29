using System.Runtime.InteropServices.JavaScript;

namespace TeamBase.TestTask.ProrateMethods;

public interface IProrateMethod
{
    double CalculateProratedPremium(double fullPremium, DateTime joinDate, DateTime policyEndDate);
}