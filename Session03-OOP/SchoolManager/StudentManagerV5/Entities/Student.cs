using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV5.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public double Gpa { get; set; }

        //Cú pháp này là cú pháp rút gọn dẹp luôn _Backing Field cho đỡ nhàm chán 
        // Khi runtime C# tự động chèn thêm các backing field tương ứng để trả lại bản gốc Get Set full 
        // Id , Name , Yob , Gpa nó là hàm get set trá hình , bản chất đằng sau class phải có field để lưu giá trị đổ vào qua constructor 
        // Cú pháp getset ngắn gọn giấu đi backing field thì được gọi là Auto-generated property 
        // Bạn thích dùng cái full hay cách rút gọn tùy thích 
    }
}
