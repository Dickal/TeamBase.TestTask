using TeamBase.TestTask.Enums;
using TeamBase.TestTask.PriceModels;
using TeamBase.TestTask.ProrateMethods;

namespace TeamBase.TestTask;

public interface IInsuranceCalculator
{
    Tuple<double, double> CalculatePremium(
        DateTime joinDate,
        DateTime policyEndDate,
        ProrateMethod prorateMethod,
        Gender? gender = null,
        int? age = null);
    Tuple<double, double> CalculatePremium(
        DateTime joinDate,
        DateTime policyEndDate,
        IProrateMethod prorateMethod,
        IPriceRate priceRate);
}