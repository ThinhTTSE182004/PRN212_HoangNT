namespace PrimitiveArrray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayWithArrayV4();
        }

        public static void PlayWithArrayV4()
        {
            //double[] v = new double[7] { 5, 10, 15, 20, 25 , 30 , 35};
            //double[] v = new double[] { 5, 10, 15, 20, 25, 30, 35 };

            double[] v = { 5, 10, 15, 20, 25, 30, 35 };// oke luôn , new ngầm
            // nếu ta biết trước mảng có bao nhiêu value cụ thể mỗi value thì new kiểu này cho nhanh
            // cách này dùng khi biết trức value 
            // thường người dùng cách v3 , tức là khai báo sẵn 1 cái amrng dài số phần tử , rồi từ từ điền value vào sau 

            //double[] v = new double[7000]; 

            for (int i = 0; i < v.Length; i++)
            {
                Console.WriteLine($"v[{i}] = {v[i]}");
            }

            Console.WriteLine("The List Of Number Printed By for Each");
            //Toán tử với mọi chữ A ngược trong toán học
            foreach (var x in v)   // foreach(double x : v)
            {
                Console.WriteLine(x); // với mỗi x thì x là con double , x có thể mang giá trị của từng biến thứ i trong mảng v 
                // x = v[0]
                // x = v[1]
                // có thể thay bằng lệnh var x in v hay double x in v 
                // x thuộc đám biến v mà v là double thì x cũng là double 
            }

        }

        public static void PlayWithArrayV3()
        {
            double v1 = 0, v2 = 10, v3 = 50, v4 = 100, v5, v6, v7;

            double[] v = new double[7]; // ta được 8 biến 1 biến con trỏ và 7 biến lẻ 

            // In biến trong mảng thay vì dùng từng biến lẻ , ta dùng for cho nhanh 
            Console.WriteLine("The List Of Rain volumes: ");
            for (int i = 0; i < v.Length; i++)
            {
                Console.WriteLine(v[i]);
            } // Vùng new nếu không nói năng gì cả mang giá trị default , số sẽ là 0 
            // hoàn toàn khác khai báo lẻ , khai báo lẻ mà không gán giá trị -> rác !!! Cấm dùng

            v[0] = 5;
            v[1] = 10;
            v[2] = 15;
            v[3] = 20;
            v[4] = 25;
            v[5] = 30;
            v[6] = 5;

            Console.WriteLine("The List Of Rain volumes: ");
            for (int i = 0; i < v.Length; i++)
            {
                Console.WriteLine(v[i]);
            }

            // v[0] có mang ý nghĩa gì không 
            // Chấm làm gì khi v[0] đang là con số 5 giá trị 5 thì chấm làm gì (priamtive)
            // Dấu chấm chỉ dành cho biến object khi nó trỏ 1 vùng new chứa thêm nhiều giá trị bên trong


        }

        public static void PlayWithArrayV2()
        {
            double v1 = 0, v2 = 10, v3 = 50, v4 = 100, v5, v6, v7;

            double[] v = new double[7]; // ta được 8 biến 
            // 1 biến má mì v 
            // 7 biến truyền thống v[0] v[1] v[2] v[3] v[.....index từ 0]
            Console.WriteLine("v[0]: " + v[0]);
            Console.WriteLine("v[1]: " + v[1]);
            Console.WriteLine("v[2]: " + v[2]);
            Console.WriteLine("v[5]: " + v[5]);
            Console.WriteLine("v[6]: " + v[6]);
            Console.WriteLine("v length " + v.Length);

            // Mảng là kỹ thuật khai báo nhiều biến cùng 1 lúc, ở sát nhau trong ram, các biến dùng chung 1 tên, để phân biệt biến ta dùng ngoặc vuông, [index tính từ 0]
            // Tên mảng là tên chung của các biến sẽ là biến má mì biến con trỏ trỏ vùng new 

        }


        // Tui cần lưu trữ lượng mưa trong tuần trước (1 tuần 7 ngày)
        // Nâng cấp: Lưu lượng mưa của tháng, năm , thập kỉ , thế kỷ
        // 
        public static void PlayWithArrayV1()
        {
            double v1 = 0, v2 = 10, v3 = 50, v4 = 100, v5, v6, v7; //khai báo lẻ nhiều biến cùng lúc cùng kiểu , khác tên 
            // Trong ram có 7 vùng riêng biệt , mỗi vùng có 1 tên gọi 
            // 7 * 8 = 56 byte (1 biến double ngốn 8 byte ~ 8 tầng lầu) 

            //Console.WriteLine($"The rain volume: {v1} | {v2} | {v3} | {v4} | {v5} | {v6} | {v7}"); //error 3 biến cuối chưa gán value thì không được dùng 
            // Khai báo biến mà không gán value sẽ mang rác, Cấm Dùng!!!
            // Khai báo biến mà không gán value thì sẽ mang default nếu biến là property hoặc backing field của object/class 

            Console.WriteLine($"The rain volume: {v1} | {v2} | {v3} | {v4}");

            //Khai báo lẻ từng biến chỉ hiệu quả nếu có ít biến 
            //Nếu có nhiều biến, Kiểu khai báo lẻ không ổn!!!!!
            // Lượng mưa 1 tháng , 1 năm khai báo biến cực nhiều , 30 biến , 365 biến khai báo lẻ chết chắc !!!!
            // Dùng mảng Array để khai báo nhiều biến cho hiệu quả 
            // Dùng list arraylist còn hiệu quả hơn cả mảng luôn !!!
            // Nhưng viết code phức tạp hơn 
        }
    }
}
