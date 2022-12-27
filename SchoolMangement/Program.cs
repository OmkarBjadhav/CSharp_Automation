using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMangement
{
    public class Program
    {
     public static void Main(string[] args)
        {
            Console.WriteLine("************* Student Information ************");
            Student str=  new Student();
            Student str1= new Student();    
            Student str2= new Student();
            str.studentId = 1001;
            str.studentName = "Jack";
            str.studentMailid = "jack@gmail.com";
            str.studentPercentage = 45.2;

            str1.studentId = 1002;
            str1.studentName = "Peter";
            str1.studentMailid = "peter@gmail.com";
            str1.studentPercentage = 85.2;

            str2.studentId = 1003;
            str2.studentName = "Mark";
            str2.studentMailid = "mark@gmail.com";
            str2.studentPercentage = 56.5;



            //str.PrintStudentDetails();
            //str.DisplayCertification();
            str2.DisplayCertification();

           
        }
    }
}
