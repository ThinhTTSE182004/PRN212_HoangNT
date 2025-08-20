using StudentManagerV6.Entities;

namespace StudentManagerV6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreateStudentV3();
        }

        public static void CreateStudent()
        {
            Student an = new Student("SE1", "An Nguyen", 2004, 8.6);
            Console.WriteLine("An full info " + an);

            // hỏi riêng tên của an? 
            Console.WriteLine("An Name: " + an.Name); // không ngoặc tròn vì xài biến là get

            an.Name = "J97 5 Tỏi";
            Console.WriteLine("An full info again " + an);
        }

        public static void CreateStudentV2()
        {
            Student an = new Student(); //photo không điền 
            //object mà các thông tin mang default 
            //chữ rỗng , số là 0 boolean là 
            Console.WriteLine("An full info " + an);

            // cập nhật 
            // xài hàm set 
            an.Id = "SE1";
            an.Name = "An Nguyen";
            an.Yob = 2004;
            an.Gpa = 8.6;

            Console.WriteLine(an);
        }

        public static void CreateStudentV3()
        {
            //new full từ đầu 
            Student s1 = new Student("SE1", "An Nguyen", 2004, 8.6);

            Student s2 = new Student();
            //new và 1 đống hàm set phía sau dài quá 
            s2.Id = "Se1";
            //.....

            // Style xịn sò 
            Student s3 = new Student() { Id = "SE1", Name = "An Nguyen", Yob = 2004, Gpa = 8.6 };
            //New và 4 cái set được gọi , không nhầm với name-argument xài dấu : và trong () của contructor vì nó là tham số hàm 
            // CÒn đây là { bên trong các hàm Set = Value , Set = Value }
            // Kĩ thuật này gọi là object Initiation Khởi Tạo Object đi kèm Hàm Set !!!! Giông giống json 

            Console.WriteLine(s3);
        }
    }
}
