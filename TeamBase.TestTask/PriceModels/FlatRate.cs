namespace TeamBase.TestTask.PriceModels;

public class FlatRate : IPriceRate
{
    private readonly int _flatRate = 1000;
    public double CalculateFullPremium()
    {
        return _flatRate;
    }
}