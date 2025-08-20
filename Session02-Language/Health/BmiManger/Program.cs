namespace BmiManger
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    double bmi = GetBmi(70,1.7);
        //    Console.WriteLine($@"Bmi of 70kg, 1.7m : {bmi}");
        //}

        static void Main(string[] args)
        {
            double bmi = BmiCalculator.GetBmi(70, 1.7);
            Console.WriteLine(bmi);
        }

        //static tính chỉ số BMI - Body Mass Index - Chỉ số khối của cơ thể dựa trên chiều cao cân nặng -> con số chỉ mập ốm
        //cân nặng : kg , cao : mét 
        //bmi = cân nặng / chiều cao bình phương
        //bmi < 18.5 ốm so với chiều cao
        //    < 25 chuẩn form
        //    > 25 mập
        //    
        //public static double GetBmi(double weigth , double height)
        //{
        //    return weigth / (height * height);
        //}

        //bodied expression 
        public static double GetBmi(double weigth, double height) => weigth / (height * height);
        // Nếu 1 hàm chỉ có duy nhất 1 lệnh thì được phép viết theo kiểu rút gọn 
        // Loại bỏ luôn cặp đóng và mở hàm ({} và bỏ luôn return)
        // khiến hàm đi sát thân hàm , cách nhau bằng dấu => 
        // kĩ thuật này gọi là expression bodied

        // Cấm tuyệt đối nhầm lẫn expression Bodied và biểu thức lambda 
        // Lambda cũng xài => nhưng với ý nghĩa hoàn tòan khác 
        
    }
}
