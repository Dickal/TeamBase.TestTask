using TeamBase.TestTask.Enums;

namespace TeamBase.TestTask.ProrateMethods;

public abstract class ProrateMethodFactory
{
    public static IProrateMethod Create(ProrateMethod prorateMethod)
    {
        if (prorateMethod == ProrateMethod.ByDays)
            return new ProrateByDays();
        if (prorateMethod == ProrateMethod.ByMonth)
            return new ProrateByMonths();
        throw new InvalidOperationException($"Can not specify correct prorate method based on the arguments");
    }
}