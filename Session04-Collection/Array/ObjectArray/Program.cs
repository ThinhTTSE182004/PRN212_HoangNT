using ObjectArray.Entities;

namespace ObjectArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreateStudentsV2();
        }

        public static void CreateStudentsV2()
        {
            Student[] arr = new Student[60];

            arr[0] = new Student()
            {
                Id = "SE1",
                Name = "An",
                Yob = 2004,
                Gpa = 8.6
            };

            arr[1] = new Student()
            {
                Id = "SE2",
                Name = "Binh",
                Yob = 2004,
                Gpa = 8.6
            };

            arr[2] = new Student()
            {
                Id = "SE3",
                Name = "Cuong",
                Yob = 2004,
                Gpa = 8.6
            };

            arr[3] = new Student()
            {
                Id = "SE4",
                Name = "Dung",
                Yob = 2004,
                Gpa = 8.6
            };

            arr[4] = new Student()
            {
                Id = "SE5",
                Name = "Fhuong",
                Yob = 2004,
                Gpa = 8.6
            };

            // mảng chưa full chấm for each vì bị null exeption [5] [6] ...

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr[i]);
            }
            //arr.Length
            // Mảng có những hạn chế như sau: 
            //1. Không được For hết nếu chưa gán phần tử còn lại - Y chang như nhìn 1 khán phòng , phòng hợp , không được đếm số ghế , mà phải đếm số người có mặt 
            //2. Xin bao nhiêu Ram (Số Ghế , Số phần tử ) fix cứng bấy nhiêu 
            // Phòng thiết kế 30 chỗ chỉ chứa được 30 , cần thêm , thu nhỏ lại không cho

            //Java C# cung cấp thêm kĩ thuật làm cho cái túi co giãn kích thước , muốn nhiều có nhiều , muốn ít có ít , xóa thì thu nhỏ lại , cần thêm nới ra 
            // Collection Trong Java : Map (TreeMap , HashMap), Set (Tree Set , Hash Set) List(ArrayList,Vector) -> Túi chứa con trỏ , túi chứa các biến object , co giãn số con trỏ thêm bớt ~ mảng object nhưng lại linh hoạt về kích thước
            // 

            //Collection trong C# 

        }


        public static void CreateStudentsV1()
        {
            // hãy lưu dùm tôi thông tin của 30 sinh viên lớp này
            // 30 nhát new Student(....){....} -> 30 object , 30 "value"
            // ta cũng cần đặt tên cho 30 nhát new, 30 biến 
            // y chang như lưu 30 con số cần 30 biến 

            int a = 5, b = 10, c = 15, d = 20, e = 25, f = 30;  // 6 biến 6 value
            int[] arr = new int[60];
            //value nè 
            arr[0] = 5;
            arr[1] = 10;
            arr[2] = 15;
            arr[3] = 20; // value đơn giản 
            arr[4] = 25;
            arr[5] = 30;
            //arr[0]. ra vớ vẩn
            
            //6 sinh viên thì sao , 6 biến 6 value
            Student s1 = new Student();
            Student s2 = new Student();
            Student s3 = new Student();
            Student s4 = new Student();
            Student s5 = new Student();
            Student s6 = new Student();

            Student[] ss = new Student[60]; // 60 biến chưa có value 

            ss[0] = new Student()
            {

            };
            ss[1] = new Student(); // value phức tạp 
            ss[2] = new Student();
            ss[3] = new Student();
            ss[4] = new Student();

            //ss[5] ss[6] .... chứa gì bên trong -> đang trỏ đến null (0) là vùng ram null, null chính là 0

            //ss[0]. chấm ra Id hoặc Name , ....
            //ss[0].Id ...

            //ss. chấm ra gì ? ra Length 

            Console.WriteLine(ss[0].ToString()); // giá trị default 
            Console.WriteLine(ss[5].ToString()); // Exeption Null Reference 
            // Khi chơi mảng object cấm tuyệt đối for hết vì phần còn lại của mảng mang default 0 tức là null trỏ đáy ram 
            // Đáy ram thì không có hàm nào cả, chấm vào là vỡ mặt, Chấm gọi hàm là vỡ mặt

            // Tưởng tượng mảng object như 1 cái túi đựng các món đồ , mỗi món đồ là 1 object vì ta mô tả được từng món đồ : bốc ra 1 cái điện thoại thì lại hỏi tiếp điện thoại có gì ?  
            // MẢNG OBJECT CHÍNH LÀ MẢNG CON TRỎ , 2 tầng dấu chấm 

            // Tưởng tượng mảng primitive như 1 cái túi đựng các con số loto 
            // bốc ra loto thì dùng luôn 
            // Mảng primitive chỉ 1 tầng dấu chấm 

        }
    }
}
