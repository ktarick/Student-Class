using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClassProject
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private string _Phone;
        public string Phone
        {
            get
            {
                return _Phone;
            }
            set
            {
                if (value.Length < 7 || value.Length > 10)
                    Console.WriteLine("Enter Correct Phone Numeber");
                else
                {
                    this._Phone = value;
                }
            }
            
        }
        public string Email { get; set; } // string still allows text
        public double GPA; //DOUBLE is a floating point number
        public int SAT;
        public Student(string fname, string lname, string phone, string email, double gpa, int sat)
        {
            FirstName = fname;
            LastName = lname;
            Phone = phone;
            Email = email;
            GPA = gpa;
            SAT = sat;
        }
        public Student(string fname, string lname, double gpa)
        {
            FirstName = "First";
            LastName = "Last";
            Phone = "111-111-1111";
            Email = "blank@blank.com";
            GPA = 0;
            SAT = 0;
        }
        public Student()
        {
        }
        public string FullName()
        {
            return $"{FirstName} {LastName}";
        }
        public string Print()
        {
            return $"{FirstName} {LastName}|{Phone}|{Email}|{GPA}|{SAT}";
        }
        public string Print(string message)
        {
            return $"{message} :: " + Print();
        }
        public string Print2()
        {
            return FullName() + $"{Phone}|{Email}|{GPA}|{SAT}";
        }
    }
}
