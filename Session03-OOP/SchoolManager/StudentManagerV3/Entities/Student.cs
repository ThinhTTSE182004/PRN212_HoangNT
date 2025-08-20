using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV3.Entities
{
    public class Student
    {
        private string _id; //backing field 
        private string _name; //chống lưng cho get set style mới , chống lưng cho property Id 
        private int _yob; //Yob
        private double _gpa; //Gpa

        public Student(string id, string name, int yob, double gpa)
        {
            _id = id;
            _name = name;
            _yob = yob;
            _gpa = gpa;
        }

        //get set style mới 
        public string Id 
        { 
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        { 
            get { return _name; } 
            set { _name = value; } 
        }

        public int Yob 
        { 
            get { return _yob; } 
            set { _yob = value; } 
        }

        //public double Gpa 
        //{ 
        //    get { return _gpa; } 
        //    set { _gpa = value; } 
        //}

        public double Gpa
        {
            get => _gpa; 
            set => _gpa = value; 
        }
    }
}
