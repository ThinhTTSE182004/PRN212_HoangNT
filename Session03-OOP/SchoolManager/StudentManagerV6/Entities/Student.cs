using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV6.Entities
{
    public class Student
    {
        //prop tab tab
        public string Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public double Gpa { get; set; }

        //ctor tab tab ra constructor rỗng

        public Student()
        {
            
        }

        public Student(string id, string name, int yob, double gpa)
        {
            Id = id;
            Name = name;
            Yob = yob;
            Gpa = gpa;
        }

        public override string? ToString()
        {
            return $"{Id} | {Name} | {Yob} | {Gpa}";
        }           // gọi hàm get để in ra các field phía hậu trường 
    }
}
