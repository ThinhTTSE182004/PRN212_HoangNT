namespace Bmi
{
    /// <summary>
    /// Class này cung cấp các hàm tính BMI của ai đó 
    /// This class offers methods for calculating BMI
    /// </summary>
    public class BmiCalculator
    {
        /// <summary>
        /// This method return a BMI base on weight and height 
        /// Hàm này trả về chỉ số BMI dựa trên cân nặng và chiều cao
        /// </summary>
        /// <param name="weight">Weight is measured by (kg)</param>
        /// <param name="height">Height is measured by (m)</param>
        /// <returns></returns>
        public static double GetBmi(double weight , double height) => weight/Math.Pow(height, 2);
    }
}
