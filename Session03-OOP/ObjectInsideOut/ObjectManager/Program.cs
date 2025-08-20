using ObjectManager.Entities;

namespace ObjectManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CreateEmptyObject();

            Student an = new Student()
            {
                Id = "SE1",
                Name = "An Nguyen",
                Yob = 2004,
                Gpa = 8.6
            };

            PLayWithObjectV3(an);
        }

        // Chốt hạ : Truyền Tham Số Mà là biến object qua hàm , bản chất là 2 chàng cùng trỏ 1 nàng , biến tham số và biến ngoài hàm trỏ cùng vùng new 
        // trong hàm mà sửa bên ngoài bị sửa theo 
        // hàm nhận vào biến object được gọi là truyền tham chiếu 2 thằng cùng chiếu 1 vùng new , pass by reference !!!!!!!!

        public static void PLayWithObjectV1()
        {
            //2 chàng cùng trỏ 1 nàng 
            Student s1 = new Student()
            {
                Id = "SE1",
                Name = "An Nguyen",
                Yob = 2004,
                Gpa = 8.6
            };
            Console.WriteLine(s1);
            Student s2 = s1; // hai chàng trỏ 1 nàng!!!!
            //s1 và s2 cùng trỏ chung 1 vùng new to , vùng new to này chứa full info , Id , Name , Yob , Gpa
            //Chứng minh trỏ cùng 
            Console.WriteLine(s2);
            s2.Gpa = 8.9; // sửa điểm s2 thế s1 thế nào 
            Console.WriteLine(s1);
            //s1 cầm chắc điểm 8.9 vì bản chất s1 và s2 đang trỏ cùng 1 vùng ram 


        }

        public static void PLayWithObjectV2()
        {
            //2 chàng cùng trỏ 1 nàng 
            Student s1 = new Student()
            {
                Id = "SE1",
                Name = "An Nguyen",
                Yob = 2004,
                Gpa = 8.6
            };
            Console.WriteLine(s1);
            Student s2 = s1; // hai chàng trỏ 1 nàng!!!!

            s1 = null; // s1 không còn trỏ ai nữa , hỏi rằng s1 s2 khi sinh ra thế nào 
            Console.WriteLine(s1); 
            Console.WriteLine(s2); // s2 vẫn còn trỏ vùng new , s1 vô thường không trỏ ai cả
            //Khi 1 biến đang trỏ null cấm tuyệt đối gọi hàm , vì sẽ bị null reference Exception , App bị chết vì vùng null không có hàm để gọi!!!!!!
            //Trong viết code, Kiểm tra != null thì mới được gọi hàm khi ta không chắc biến đó có giá trị hay không, Ví dụ Query từ DB lên 

            Student s3 = s2; // vị trí câu lệnh này cực kì quan trọng , giữ lại vùng new trước khi không còn ai trỏ , s1 đi chơi s2 sắp đi 

            s2 = null; // ram thế nào 
            // Vùng new An bị mồ côi - Orphan Memory , không có con trỏ trỏ đến
            Console.WriteLine("after s1 & s2 null " +s1);
            Console.WriteLine("after s1 & s2 null " +s2);
            // Bộ gom rác của runtime/garbage collection sẽ đi gom clear vùng new mồ côi để danh sẵn cho các new sau này

            Console.WriteLine(s3);


        }


        public static void PLayWithObjectV3(Student s)
        {
            //s là tham số , là biến object, nó sẽ trỏ vùng new nào đó !!!!
            // vùng new này có thể từ bên ngoài đưa vào , hoặc s chủ động tạo vùng new riêng

            //In thông tin object khi mới vào hàm 
            Console.WriteLine("in function before updating gpa: "+s);

            // sửa object bên trong hàm
            s.Gpa = 8.2;
            Console.WriteLine("in function, after updating gpa: " + s);
        }

        public static void CreateEmptyObject()
        {
            // Dùng constructor rỗng và default - tự có sẵn nếu class không có constructor tường minh do ta tự tạo ra 
            Student s1 = new Student(); //implcit constructor  (tự ngầm)
            Console.WriteLine(s1); // gọi thầm tostring

            // sài hàm set từng cái hoặc dùng object initiation 
            s1.Id = "SE1";
            s1.Name = "An Nguyen";
            s1.Gpa = 8.6;

            Console.WriteLine("s1 after " + s1);

            //Object initiation 
            Student s2 = new Student()
            {
                Id = "SE2",
                Name = "Binh Tran",
                Yob = 2005,
                Gpa = 8.8
            };

            Console.WriteLine(s2);
        }
    }
}
