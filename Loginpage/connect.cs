using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loginpage
{
    public class Student
    {
        public string StudentName { get; set; }
        public string Password { get; set; }
        public StudentDetails Details { get; set; }
    }

    public class StudentDetails
    {
        public string StudentID { get; set; }
        public  string StudentName { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
        public string MobileNumber { get; set; }
        public string MotherName { get; set; }
        public string FatherName { get; set; }
        public string Address { get; set; }
        public string ImagePath { get; set; }
    }

}

