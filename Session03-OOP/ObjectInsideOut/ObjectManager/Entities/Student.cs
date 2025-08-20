using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectManager.Entities
{
    public class Student
    {
        public string Id { get; set; }  //prop tab tab
        public string Name { get; set; }
        public int Yob { get; set; } = 2004; // ~ Yob = 2004 , set default _yob = 2004;
        public double Gpa { get; set; }

        public Student(string id, string name, int yob, double gpa)
        {
            Id = id;
            Name = name;
            Yob = yob;
            Gpa = gpa;
        }
        // Nếu class đã có 1 constructor bất kỳ thì không tồn tại consttructor rỗng nữa , runtime không tạo giúp ta 1 constructor default nữa vì đã có cách tạo object khác rồi
        // nhưng c# java cho phép bạn chủ động - Explicit Tạo contructor rỗng tường minh, mình có quyền đưa contructor rỗng ra ánh sáng ctor tab tab 
        // lúc này class có 2 contructor , 1 rỗng 1 full tham số
        // không ai cấm tạo nhiều constructor
        // nhiều constructor tương đương nhiều cách đúc 1 bức tượng, nhiều cách filed vào form !!!

        public Student()
        {
            
        }


        public override string ToString()
        {
            return $"{Id} | {Name} | {Yob} | {Gpa}";
        }

        // nếu class không có constructor thì mặc định runtime sẽ tạo cho class 1 constructor rỗng/default -> Y chang Java
        // Ta chỉ gọi New Student là đủ không nhận đầu vào , không làm gì cả
        // Khi đó mọi Field của object Mang giá trị default
        // Y chang như tờ giấy Form/ Biểu Mẫu cô ngân hàng , anh công chức ở cơ quan hành chính đưa cho mình để mình khai báo 
        // Mình iguwx cái form , tức là giữ tờ giấy gốc được clone ra 1 bản cho mình , mình chưa điền vào thì nó vẫn là object cho mình 
        // vẫn chứa info trắng trơn trên form của mình default 
        // từ từ điền sau , tức là hàm điền qua hàm .Set()
        // Chữ -> rỗng 
        // Số -> 0
        // boolean -> false 
        // new class không có contructor tương đương new 1 tờ giấy trắng của mình 1 object mang default
    }
}
