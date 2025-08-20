using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmiManger
{
    internal class BmiCalculator
    {
        // Mỗi class lo đúng 1 việc thuộc về , tập trung vào nhóm công việc nào đó có liên quan -> nguyên Lý SRP của solid 
        // Single Responsibility Principle

        public static double GetBmi(double weigth, double height) => weigth / (height * height);
    }
}
