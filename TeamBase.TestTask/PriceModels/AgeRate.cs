namespace TeamBase.TestTask.PriceModels;

public class AgeRate : IPriceRate
{
    protected readonly int _age;

    public AgeRate(int age)
    {
        if (age < 0)
            throw new ArgumentException(nameof(age));
        _age = age;
    }

    public double CalculateFullPremium()
    {
        // With if-else statements in future we can add more logic for specific age range
        if (_age <= 9)
            return _age * 100;
        if (_age <= 19)
            return _age * 200;
        if (_age <= 29)
            return _age * 300;
        if (_age <= 39)
            return _age * 400;
        if (_age <= 49)
            return _age * 500;
        if (_age <= 59)
            return _age * 600;
        if (_age <= 69)
            return _age * 700;
        if (_age <= 79)
            return _age * 800;
        if (_age <= 89)
            return _age * 900;
        return _age * 1000;
    }
}