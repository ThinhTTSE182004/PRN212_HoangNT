namespace BmiManager
{

    public class BmiClaculator
    {
        public double GetBmi(double weight, double height) => weight / Math.Pow(height, 2);
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            BmiClaculator bmiClaculator = new BmiClaculator();
            Console.WriteLine("BMI :" + bmiClaculator.GetBmi(70,1.7));
            Console.WriteLine("BMI :" + new BmiClaculator().GetBmi(70,1.7));
        }

    }
}
