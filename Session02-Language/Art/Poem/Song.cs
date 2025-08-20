using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poem // là hộ khẩu thường trú , tên thư mục chỉ ra nơi class đang nằm  ~ Package bên Java
    // Nhờ namespace có khái niệm package bên java ta có thể tạo ra nhiều class cùng tên nhưng phải khác thư mục 
{
    internal class Song
    {
        //class là thùng chứa , bên trong biến/filed/attribute và hàm/method
        //field và method có thể static và non static 

        public static void PrintBacBlingLyric()
        {
            int publishedYear = 2025; // năm phát hành
            int views = 150_000_000;

            //Console.WriteLine("Ta về ta tắm ao ta\r\nDù trong, dù đục, ao nhà vẫn hơn (vẫn hơn)\r\nTình quê son sắt keo sơn\r\nHương đồng gió nội, cây rơm đợi chờ\r\nMời bà con về Bắc Ninh em chơi nào");

            //ghép chuỗi như Java
            Console.WriteLine("1.Ta về ta tắm ao ta " + publishedYear + " Views: " + views);

            // Placeholder (Chừa chỗ điền vào danh sách các biến được đánh số từ 0 thêm dấu phẩy)
            Console.WriteLine("2.Ta về ta tắm ao ta {0} views {1}",publishedYear,views);

            //interpolation (Nội suy biến nằm trong chuỗi) 
            Console.WriteLine($"3.Ta về ta tắm ao ta {publishedYear} {views}");

            //interpolation (Nội suy biến nằm trong chuỗi) 
            Console.WriteLine($"3.Ta về ta tắm ao ta {publishedYear} | {views} | store: C:\\newmusic");

            //interpolation (Nội suy biến nằm trong chuỗi) 
            Console.WriteLine($@"4.Ta về ta tắm ao ta {publishedYear} | {views} | store: C:\newmusic");

            string msg = $@"5.Ta về ta tắm ao ta {publishedYear} | {views} | store: C:\newmusic";
            Console.WriteLine(msg);
        }

    }
}
