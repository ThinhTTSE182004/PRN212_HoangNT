using StudentManager.Entities;
// mượn class ở nơi khác để dùng để đúc ra object thì phải khai báo mượn , java gọi là import , c# gọi là using 
// ghé sang ngăn Entities lấy ra cái form gốc Student đi photo được gọi là new và phát cho mọi người điền 

namespace StudentManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreateStudentV2();
        }

        public static void CreateStudent()
        {
            Student an = new Student("SE1","An Nguyen",2004, 8.6);
            //photo class/form    điền vô
            // int yob = 2004;
            // double total = 1 triệu;
            // an đã là sv , giao tiếp với hắn hỏi hắn năm sinh , điểm tb
            Console.WriteLine("An gpa:" + an.GetGpa());
            Console.WriteLine("An name: {0}", an.GetName());
            Console.WriteLine($"An yob: {an.GetYob()}");

            // In full info 
            an.ShowProfile();
            Console.WriteLine(an.ToString());
            Console.WriteLine(an); // gọi thầm ToString không cần gọi trực tiếp 
        }


        public static void CreateStudentV2()
        {
            //Student an = new Student("SE1", "An Nguyen", 2004, 8.6);
            Student an = new ("SE1", "An Nguyen", 2004, 8.6); // ăn bớt tay phải không cần chỉ ra new Student vì đã có manh mối bên tay trái simplify - đơn giản kiểu new 
            an.ShowProfile();

            var binh = new Student("SE2", "Binh Nguyen", 2004, 8.6);
            // bỏ datatype bên tay trái vì có manh mối bên tay phải 
            // binh chắc chắn là Student Bình, căn theo tay phải 
            // không rõ datatype của biến cho đến khi gán value thì biết ngay 
            // type infferent : suy luận kiểu
            // muốn xài kiểu này thì dùng từ khóa var biến = value;
            // bắt buộc phải gán ngay khi khai báo

            //var a; //error vì chưa gán value ngay khi dùng var
            var b = 2025; // đúng vì biết 2025 kiểu nguyên

            Console.WriteLine(binh); // gọi thầm ToString 
        }


        public static void CreateStudentV3()
        {
            //Student an = new Student("SE1", "An Nguyen", 2004, 8.6);
            //Student an = new("SE1", "An Nguyen", 2004, 8.6);
            Student an = new(gpa: 8.6, id: "SE1", name: "An Nguyen", yob: 2004);
            //named-argument : kĩ thuật cho phép truyeefgn value vào hàm lộn xộn thứ tự miễn là ghi rõ tên tham số nào nhận value nào 
            // gpa 8.6 thì có nghĩa là giá trị 8.6 dành cho parameter gpa 
            // bất chấp gpa đứng ở vị trí nào trong tham số hàm 

            an.ShowProfile();  
        }
    }
}
