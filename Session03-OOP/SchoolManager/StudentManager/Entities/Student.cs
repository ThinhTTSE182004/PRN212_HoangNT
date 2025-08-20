using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Entities // sub folder, sub namespace 
{
    public class Student
    {
        // khuôn, form , biểu mẫu , template , blueprint
        private string _id; //id: ___
        private string _name; // name: _____
        private int _yob;   // yob:____
        private double _gpa; //gpa: ____

        //hàm constructor là cái phễu nhận vật liệu bên ngoài đổ vào cái khuôn, hành động lấy bút mực điền vào các mục trong biểu mẫu; điền xong ra được 1 object 
        public Student(string id, string name, int yob , double gpa)
        {
            _id = id; // no this. anymore 
            this._name = name; //dư chứ không sai  
            _yob = yob;        // dùng this khi có sự trùng tên
            _gpa = gpa;        // giữa tham số và bên trong obj 
        }
        //Cặp hàm/hành động huyền thoại của mỗi object khi đã được đổ full info : Get ; Set
        //
        public string GetName() => _name;

        public int GetYob() => _yob;

        public double GetGpa() => _gpa; //expression bodied 

        // Hàm set , nhận info từ bên ngoài đè vào info đang có 
        // Tương đương tẩy xóa , thay info cũ = info mới 
        // giống và khác contructor 
        public void SetGpa(double gpa) => _gpa = gpa;

        //tham số đầu vào của hàm set đặt là gì cũng được miễn không vi phạm quy tắc Coding Convention ; ta đặt trùng tên với attribute nhưng bỏ đi dấu _ hoặc đặt là value cho chung chung 
        public void SetName(string value) => _name = value;

        public void SetYob(int yob) => _yob = yob;


        //1 object được đổ info vào ra sẽ show toàn bộ info của nó, thay vì từng miếng get nho nhỏ , GetYob 
        // nay ta get hết cả nhóm 
        // 2 hàm : show hết info (như ở cửa tiệm bán đồ có miếng giấy ghi chú hết cấu hình sản phẩm) hoặc trả về chuỗi full info - toString() ToString()

        public void ShowProfile()
        {
            // 4 kĩ thuật ghép chuỗi
            Console.WriteLine($"Student info: {_id} | {_name} | {_yob} | {_gpa}");
        }

        public override string ToString()
        {
            return $"Student info: {_id} | {_name} | {_yob} | {_gpa}";
        }
        // 2 Hàm này y chang như lúc mình gặp chú csgt cccd 

    }
}
