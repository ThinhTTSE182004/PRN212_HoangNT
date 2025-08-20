using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentmanagerV4.Entities
{
    public class Student
    {
        private string _id;
        private string _name;
        private int _yob;
        private double _gpa;


        // Get Set 
        // gõ propfull tab tab để gợi ý

        public int Yob
        {
            get { return _yob; }
            set { _yob = value; }
        }

        public double Gpa
        {
            get { return _gpa; }
            set { _gpa = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        // kĩ thuật viết get set mà đầy đủ cả shift gạch _backing field và property gồm hàm get set gộp thì được gọi là full property
        // Property đầy đủ thành phần, từ khóa propfull tab tab
        // Hay nhưng lại Boiler-plate cái công thức viết get/Set vẫn thấy dài dòng , rườm rà!!!

        //Level trùm cuối Version 5
    }
}
