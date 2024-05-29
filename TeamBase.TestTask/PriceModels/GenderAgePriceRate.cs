using TeamBase.TestTask.Enums;

namespace TeamBase.TestTask.PriceModels;

public class GenderAgePriceRate : AgeRate, IPriceRate
{
    private readonly Gender _gender;
    private readonly double _ageMultiplier;

    public GenderAgePriceRate(int age, Gender gender, double ageMultiplier = 1.5) : base(age)
    {
        _gender = gender;
        _ageMultiplier = ageMultiplier;
    }

    public new double CalculateFullPremium()
    {
        var basePremium = base.CalculateFullPremium();
        if (_age < 18 || _gender == Gender.Male)
            return basePremium;
        return basePremium * _ageMultiplier;
    }
}