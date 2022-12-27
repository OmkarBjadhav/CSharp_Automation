using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMangement
{
    public  class Student
    {
        public int studentId;
        public String studentName;
       public  String studentMailid;
        public double studentPercentage; 
        public  static string schoolName = "Global school";
        public static string schoolAddress = "chennai";


        public void DisplayCertification()
        {
            if (studentPercentage>=90)
            {
                Console.WriteLine("Hi "+studentName+ " You have successfully passed with grade A");
            }
            else if (studentPercentage>=80 && studentPercentage<=89)
            {
                Console.WriteLine("Hi " + studentName + " You have successfully passed with grade B");

            }
            else if (studentPercentage>=60 && studentPercentage<=79)
            {
                Console.WriteLine("Hi " + studentName + " You have successfully passed with grade C");
            }
            else
            {
                Console.WriteLine("Hi " + studentName + " You have Unfortunately  passed with grade F");

            }

        }
        public void PrintStudentDetails()
        {
            Console.WriteLine("Student Id: "+studentId);
            Console.WriteLine("Student Name: "+studentName);
            Console.WriteLine("Student Mail Id: "+studentMailid);
            Console.WriteLine("Student Percentage: "+studentPercentage);
            Console.WriteLine("School Name: "+schoolName);
            Console.WriteLine("School Address: "+schoolAddress);


        }



    }
}
