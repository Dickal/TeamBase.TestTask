using TeamBase.TestTask.Enums;

namespace TeamBase.TestTask.PriceModels;

public abstract class PriceModelFactory
{
    public static IPriceRate Create(Gender? gender = null, int? age = null)
    {
        if (gender == null && age == null)
            return new FlatRate();
        if (gender != null && age != null)
            return new GenderAgePriceRate(age.Value, gender.Value);
        if (age != null)
            return new AgeRate(age.Value);
        throw new InvalidOperationException($"Can not specify correct price rate based on the arguments");
    }
}