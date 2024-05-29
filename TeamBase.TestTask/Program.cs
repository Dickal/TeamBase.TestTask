using TeamBase.TestTask.Enums;
using TeamBase.TestTask.PriceModels;

namespace TeamBase.TestTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IInsuranceCalculator insuranceCalculator = new InsuranceCalculator();
            var joinDate = new DateTime(2024, 3, 15);
            var policyEndDate = new DateTime(2024, 12, 31, 23, 59, 59);
            var result_1 = insuranceCalculator.CalculatePremium(
                joinDate, policyEndDate, ProrateMethod.ByDays);
            var result_2 = insuranceCalculator.CalculatePremium(
                joinDate, policyEndDate, ProrateMethod.ByDays, Gender.Female, 21);
            var result_3 = insuranceCalculator.CalculatePremium(
                joinDate, policyEndDate, ProrateMethod.ByMonth, age: 21);
            try
            {
                var result_4 = insuranceCalculator.CalculatePremium(
                     joinDate, policyEndDate, ProrateMethod.ByMonth, Gender.Male);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.ReadKey();
        }
    }
}
