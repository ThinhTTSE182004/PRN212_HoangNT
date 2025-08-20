using Bmi;

namespace BmiManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"BMI:" + BmiCalculator.GetBmi(70,1.7));
        }
    }
}
