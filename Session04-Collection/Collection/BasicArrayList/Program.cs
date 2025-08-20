using System.Collections;
using BasicArrayList.Entities;

namespace BasicArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayWithArrayList();
        }


        public static void PlayWithArrayList()
        {
            // Java : List gồm 2 thằng con là ArrayList và Vector
            //        abstract                  cụ thể - concrete class 
            //        Cấm New                    new được , new được
            //  List x = new ArrayList();
            // ArrayList bag = new ArrayList();
            // List bag = new List() cấm !!!!!!!!!! 

            // C#: List và ArrayList rất khác nhau !!!!!!!!!!!!!!!!
            // 2 thằng đều new được luôn !!!!!!!!!!!!!!!!!!
            // 2 thằng đều là concrete class , class cụ thể 

            ArrayList bag = new ArrayList(); // có 1 cái túi sẽ đựng nhiều con trỏ sẽ trỏ vào các object khác 
            // nó là mảng nhưng khởi đầu kích thước là 0 phần tử con trỏ , Add() vào thì thêm phần tử , thêm con trỏ 

            //bag[0] = ???; theo mảng 

            bag.Add(1);
            bag.Add(2);
            bag.Add(3);
            bag.Add(4);
            bag.Add("Hello");
            bag.Add(new Student () { Id = "Se1"  });

            for (int i = 0; i < bag.Count; i++)
            {
                Console.WriteLine(bag[i]);
            }

            // Array list là cái mảng co giãn , chứa lộn xộn các loại object bên trong 
            // để không chứa lộn xộn bên trong , C# cung cấp thêm list 
            // Khi new list chỉ chứa 1 loại object nào đó mà thôi 

            // Java cấm new List()

        }
    }
}
