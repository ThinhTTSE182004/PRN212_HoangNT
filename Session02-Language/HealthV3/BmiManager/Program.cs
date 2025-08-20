using Bmi; // ~import bên Java 
// Tớ cần nhờ các class ở bên Package/căn nhà/namespace bmi
// ta cần import/using khi xài class ở 1 namespace khác!!

namespace BmiManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bmi = BmiCalculator.GetBmi(70, 1.7);
            Console.WriteLine($"BMI: {bmi}");
        }
    }
}
