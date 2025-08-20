using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV2.Entities
{
    public class Student
    {
        private string _id;
        private string _name;
        private int _yob;
        private double _gpa;

        public Student(string id, string name, int yob, double gpa)
        {
            _id = id;
            _name = name;
            _yob = yob;
            _gpa = gpa;
        }

        public override string? ToString()
        {
            //return base.ToString(); chính là super trong java 
            return $"{_id} | {_name} | {_yob} | {_gpa}";
        }

        //get set phải tự gõ , vì có 1 lý do, sẽ học sau 

        public string GetName() => _name;

        public void SetName(string value) => _name = value;

        public int GetYob() => _yob;
        public void SetYob(int yob) => _yob = yob;
        public double GetGgpa() => _gpa;


        //constructor , Get , Set , ToString()
        //gõ code như java haowjc dùng phím để generate
        // ctrl .



    }
}
