using System.Reflection;
using TeamBase.TestTask.Enums;
using TeamBase.TestTask.PriceModels;
using TeamBase.TestTask.ProrateMethods;

namespace TeamBase.TestTask;

public class InsuranceCalculator : IInsuranceCalculator
{
    private Tuple<double, double> CalculatePremiumInternal(DateTime joinDate,
        DateTime policyEndDate, IProrateMethod prorateMethod, IPriceRate priceRate)
    {
        var fullPremium = priceRate.CalculateFullPremium();
        var proratedPremium = prorateMethod.CalculateProratedPremium(fullPremium, joinDate, policyEndDate);

        return Tuple.Create(fullPremium, proratedPremium);
    }
    public Tuple<double, double> CalculatePremium(
        DateTime joinDate,
        DateTime policyEndDate, 
        ProrateMethod prorateMethod,
        Gender? gender = null,
        int? age = null)
    {
        var priceRateImpl = PriceModelFactory.Create(gender, age);
        var prorateMethodImpl = ProrateMethodFactory.Create(prorateMethod);

        return CalculatePremiumInternal(joinDate, policyEndDate, prorateMethodImpl, priceRateImpl);
    }

    public Tuple<double, double> CalculatePremium(DateTime joinDate, DateTime policyEndDate, IProrateMethod prorateMethod, IPriceRate priceRate)
    {
        return CalculatePremiumInternal(joinDate, policyEndDate, prorateMethod, priceRate);
    }
}